using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdeyanjuApplication.Entities.DbSet
{
    public class Announcement : AuditFields
    {
        public string AnnouncementTitle { get; set; } = string.Empty;
        public string AnnouncementDetail { get; set; } = string.Empty;
        public string CoverImageUrl { get; set; } = string.Empty;
    }
}
