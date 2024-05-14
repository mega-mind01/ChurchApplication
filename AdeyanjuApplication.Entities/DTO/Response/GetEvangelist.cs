using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdeyanjuApplication.Entities.DTO.Response
{
    public class GetEvangelist : GetUser
    {
        public string PastorInCharge { get; set; } = string.Empty;
        public DateOnly YearsInService { get; set; }
    }
}
