using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.DAL.Entity
{
    public class User
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string? Username { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public long? PhotoAttachmentId { get; set; }
        public string? Password { get; set; } 
        public int SystemRoleId { get; set; }
        public bool Active { get; set; }
        public long? CreatedByUserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int MobileNumber { get; set; }

    }
}
