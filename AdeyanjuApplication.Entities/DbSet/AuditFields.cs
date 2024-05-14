using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdeyanjuApplication.Entities.DbSet
{
    public class AuditFields
    {
        public string Id { get; set; } = string.Empty;
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public string UpdatedBy { get; set; } = string.Empty;
        public int Status { get; set; }
    }
}
