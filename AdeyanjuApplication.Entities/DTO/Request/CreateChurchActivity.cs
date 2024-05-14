using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdeyanjuApplication.Entities.DTO.Request
{
    public class CreateChurchActivity
    {
        public string ActivityName { get; set; } = string.Empty;
        public string ActivityDescription { get; set; } = string.Empty;
        public string ActivityDay { get; set; } = string.Empty;
        public string ActivityTime { get; set; } = string.Empty;
        public string UpdatedBy { get; set; } = string.Empty;
    }
}
