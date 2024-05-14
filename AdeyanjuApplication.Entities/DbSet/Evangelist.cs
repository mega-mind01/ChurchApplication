using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdeyanjuApplication.Entities.DbSet
{
    public class Evangelist : BaseEntity
    {
        public string PastorInCharge { get; set; } = string.Empty;
        public int YearsInService { get; set; }
    }
}
