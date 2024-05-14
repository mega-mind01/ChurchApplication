using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChurchApplication.Entities.DTO.Request
{
    public class UpdateChurchActivity
    {

        public string Id { get; set; } = string.Empty;
        public string ActivityName { get; set; } = string.Empty;
        public string ActivityDescription { get; set; } = string.Empty;
        public string ActivityDay { get; set; } = string.Empty;
        public string ActivityTime { get; set; } = string.Empty;
        public string UpdatedBy { get; set; } = string.Empty;
        public DateTime Created { get; set; }
        public int Status { get; set; }
    }
}
