using Clearforge.Application.Services;
using Clearforge.Domain.Entities;

namespace Clearforge.Infrastructure.Services
{
    public class UserService : IUserService
    {
        public async Task<IEnumerable<User>> GetUsersAsync()
        {
            // In a real application, you would fetch this from a database.
            var users = new List<User>
            {
                new User { Id = 1, Name = "Alice", Email = "alice@example.com" },
                new User { Id = 2, Name = "Bob", Email = "bob@example.com" },
            };

            return await Task.FromResult(users);
        }
    }
}
