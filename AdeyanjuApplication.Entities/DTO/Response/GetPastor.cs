using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdeyanjuApplication.Entities.DTO.Response
{
    public class GetPastor : GetUser
    {
        public string BranchName { get; set; } = string.Empty;
        public string YearsInService { get; set; } = string.Empty;
        public string ChurchAddress { get; set; } = string.Empty;
    }
}
