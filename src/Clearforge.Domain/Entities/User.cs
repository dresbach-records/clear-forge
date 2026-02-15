using System.Collections.Generic;
using Clearforge.Core.Domain;
using Clearforge.Domain.Entities;

namespace Clearforge.Domain.Entities
{
    public class User : BaseEntity
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Username { get; set; }
        public string? PasswordHash { get; set; }
        public string? PasswordSalt { get; set; }
        public string? Role { get; set; } // e.g., "Admin", "User"

        public ICollection<License> Licenses { get; set; } = new List<License>();
        public ICollection<Device> Devices { get; set; } = new List<Device>();
        public ICollection<Subscription> Subscriptions { get; set; } = new List<Subscription>();
    }
}
