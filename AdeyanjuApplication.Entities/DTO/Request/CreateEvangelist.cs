using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdeyanjuApplication.Entities.DTO.Request
{
    public class CreateEvangelist : CreateUser
    {
        public int YearsInService { get; set; }
    }
}
