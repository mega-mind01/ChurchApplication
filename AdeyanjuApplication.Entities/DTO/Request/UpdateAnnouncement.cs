using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChurchApplication.Entities.DTO.Request
{
    public class UpdateAnnouncement
    {
        public string Id { get; set; } = string.Empty;
        public string AnnouncementTitle { get; set; } = string.Empty;
        public string AnnouncementDetail { get; set; } = string.Empty;
        public string CoverImageUrl { get; set; } = string.Empty;
        public string UpdatedBy { get; set; } = string.Empty;
        public DateTime Created { get; set; }
        public int Status { get; set; }
    }
}
