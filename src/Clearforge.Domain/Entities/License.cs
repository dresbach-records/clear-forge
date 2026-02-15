using System;
using Clearforge.Core.Domain;

namespace Clearforge.Domain.Entities
{
    public class License : BaseEntity
    {
        public Guid Key { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }
        public string? Plan { get; set; } // e.g., "Free", "Pro", "Enterprise"
        public DateTime Expiration { get; set; }
        public bool IsActive { get; set; }
    }
}
