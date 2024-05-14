using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdeyanjuApplication.Entities.DbSet
{
    public class BaseEntity :  IdentityUser
    {
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public string UpdatedBy { get; set; } = string.Empty;
        public int Status { get; set; }
        public string Title { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string StateOfOrigin { get; set; } = string.Empty;
        public string HomeAddress { get; set; } = string.Empty;
        public string Occupation { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public string DateOfBirth { get; set; } = string.Empty;
        public IdentityRole? Role { get; set; }
        public string UserRoleId { get; set; } = string.Empty;
    }
}
