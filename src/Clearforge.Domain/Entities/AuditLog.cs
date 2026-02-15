using System;
using Clearforge.Core.Domain;

namespace Clearforge.Domain.Entities
{
    public class AuditLog : BaseEntity
    {
        public DateTime Timestamp { get; set; }
        public string? Level { get; set; } // e.g., "Info", "Warning", "Error"
        public string? Message { get; set; }
        public int? UserId { get; set; }
        public User? User { get; set; }
    }
}
