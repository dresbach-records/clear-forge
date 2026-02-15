using Clearforge.Domain.Entities;
using System.Threading.Tasks;

namespace Clearforge.Application.Services
{
    public interface IUserService
    {
        Task<User> RegisterAsync(string name, string email, string password);
        Task<string> LoginAsync(string email, string password);
        Task<IEnumerable<User>> GetUsersAsync();
    }
}
