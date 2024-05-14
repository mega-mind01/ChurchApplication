using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdeyanjuApplication.Entities.DTO.Request
{
    public class CreateAnnouncement
    {
        public string AnnouncementTitle { get; set; } = string.Empty;
        public string AnnouncementDetail { get; set; } = string.Empty;
        public string CoverImageUrl { get; set; } = string.Empty;
        public string UpdatedBy { get; set; } = string.Empty;
    }
}
