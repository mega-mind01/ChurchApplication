using AdeyanjuApplication.Entities.DTO.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChurchApplication.Entities.DTO.Request
{
    public class UpdatePastor : UpdateUser
    {
        public string BranchName { get; set; } = string.Empty;
        public int YearsInService { get; set; }
        public string ChurchAddress { get; set; } = string.Empty;
    }
}
