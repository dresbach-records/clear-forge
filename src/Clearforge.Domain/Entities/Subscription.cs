using System;
using Clearforge.Core.Domain;

namespace Clearforge.Domain.Entities
{
    public class Subscription : BaseEntity
    {
        public int UserId { get; set; }
        public User? User { get; set; }
        public string? StripeSubscriptionId { get; set; }
        public string? Plan { get; set; } // e.g., "Pro", "Enterprise"
        public string? Status { get; set; } // e.g., "Active", "Canceled"
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
