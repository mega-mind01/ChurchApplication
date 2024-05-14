using AdeyanjuApplication.DataService.Data;
using AdeyanjuApplication.DataService.Repository.Interface;
using AdeyanjuApplication.Entities.DbSet;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdeyanjuApplication.DataService.Repository
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly AppDbContext _context;
        public IPastorRepository Pastor { get; set; }
        public IEvangelistRepository Evangelist { get; set; }
        public IMemberRepository Member { get; set; }
        public IAnnouncementRepository Announcement { get; set; }
        public IChurchActivityRepository ChurchActivity { get; set; }

        public UnitOfWork(AppDbContext appDbContext, ILoggerFactory loggerFactory)
        {
            _context = appDbContext;
            var logger = loggerFactory.CreateLogger("logger");
            Pastor = new PastorRepository(appDbContext, logger);
            Evangelist = new EvangelistRepository(appDbContext, logger);
            Member = new MemberRepository(appDbContext, logger);
            Announcement = new AnnouncementRepository(appDbContext, logger);
            ChurchActivity = new ChurchActivityRepository(appDbContext,logger);
        }

        public async Task<bool> CompleteAsync ()
        {
            var result = await _context.SaveChangesAsync();
            return result > 0;
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
