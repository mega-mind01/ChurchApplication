using AdeyanjuApplication.DataService.Data;
using AdeyanjuApplication.DataService.Repository.Interface;
using AdeyanjuApplication.Entities.DbSet;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdeyanjuApplication.DataService.Repository
{
    public class ChurchActivityRepository : GenericRepository<ChurchActivity>, IChurchActivityRepository
    {
        public ChurchActivityRepository(AppDbContext dbContext, ILogger logger) : base(dbContext, logger)
        {
        }

        public override async Task<IEnumerable<ChurchActivity>> GetAll()
        {
            try
            {
                return await _dbSet.Where(x => x.Status == 1).OrderBy(x => x.Created).ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "(Repo) GetAll function error", typeof(AnnouncementRepository));
                throw;
            }
        }

        public override async Task<bool> Update(ChurchActivity churchActivity)
        {
            try
            {
                var result = await _dbSet.FirstOrDefaultAsync(x => x.Id == churchActivity.Id);
                if (result == null)
                {
                    return false;
                }
                result.Updated = DateTime.UtcNow;
                result.ActivityName = churchActivity.ActivityName;
                result.ActivityDescription = churchActivity.ActivityDescription;
                result.ActivityDay = churchActivity.ActivityDay;
                result.UpdatedBy = churchActivity.UpdatedBy;
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "(Repo) Update function error", typeof(ChurchActivityRepository));
                throw;
            }
        }

        public override async Task<bool> Delete(string Id)
        {
            try
            {
                var result = await _dbSet.FirstOrDefaultAsync(x => x.Id == Id);
                if (result == null)
                {
                    return false;
                }
                result.Status = 0;
                result.Updated = DateTime.UtcNow;
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "(Repo) Delete function error", typeof(ChurchActivityRepository));
                throw;
            }
        }
    }
}
