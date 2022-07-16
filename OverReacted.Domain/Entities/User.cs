using OverReacted.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverReacted.Domain.Entities
{
    public class User : BaseEntity<Guid>
    {
        public string? Name { get; set; }
        public string? Avatar { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string VerifyCode { get; set; }
        public bool IsActive { get; set; }
        public bool IsEmailActive { get; set; }
        public DateTimeOffset? LastVerificationSent { get; set; }
        public Role Role { get; set; }
        public int RoleId { get; set; }
    }
}
