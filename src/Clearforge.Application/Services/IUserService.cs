using Clearforge.Domain.Entities;

namespace Clearforge.Application.Services
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetUsersAsync();
    }
}
