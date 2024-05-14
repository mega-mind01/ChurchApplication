using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdeyanjuApplication.Entities.DTO.Request
{
    public class CreateUser
    {
        public string Title { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string EmailAddress { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string StateOfOrigin { get; set; } = string.Empty;
        public string HomeAddress { get; set; } = string.Empty;
        public string Occupation { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public string PastorInCharge { get; set; } = string.Empty;
        public string UpdatedBy { get; set; } = string.Empty;
        public string DateOfBirth { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
    }
}
