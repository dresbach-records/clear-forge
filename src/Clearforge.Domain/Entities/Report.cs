using System;
using Clearforge.Core.Domain;

namespace Clearforge.Domain.Entities
{
    public class Report : BaseEntity
    {
        public int UserId { get; set; }
        public User? User { get; set; }
        public string? Type { get; set; } // e.g., "Cleanup", "Performance"
        public DateTime GeneratedAt { get; set; }
        public byte[]? Content { get; set; }
    }
}
