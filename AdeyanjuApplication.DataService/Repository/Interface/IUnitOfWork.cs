using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdeyanjuApplication.DataService.Repository.Interface
{
    public interface IUnitOfWork
    {
        IPastorRepository Pastor { get; set; }
        IEvangelistRepository Evangelist { get; set; }
        IMemberRepository Member { get; set; }
        IAnnouncementRepository Announcement { get; set; }
        IChurchActivityRepository ChurchActivity { get; set; }
        Task<bool> CompleteAsync();
    }
}
