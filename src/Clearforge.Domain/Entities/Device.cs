using Clearforge.Core.Domain;

namespace Clearforge.Domain.Entities
{
    public class Device : BaseEntity
    {
        public int UserId { get; set; }
        public User? User { get; set; }
        public string? Name { get; set; }
        public string? DeviceId { get; set; }
    }
}
