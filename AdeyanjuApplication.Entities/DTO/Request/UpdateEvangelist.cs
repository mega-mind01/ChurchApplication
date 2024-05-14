using AdeyanjuApplication.Entities.DTO.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChurchApplication.Entities.DTO.Request
{
    public class UpdateEvangelist : UpdateUser
    {
        public int YearsInService { get; set; }
    }
}
