using TestTask.Data;
using TestTask.Models;
using TestTask.Repositories.Interfaces;
using TestTask.Services.Interfaces;

namespace TestTask.Repositories.Impl
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public User GetUser()
        {
            return _context.Users
                .OrderByDescending(user => user.Orders.Count())
                .FirstOrDefault();
        }

        public List<User> GetUsers()
        {
            return _context.Users
                .Where(user => user.Status == Enums.UserStatus.Inactive)
                .ToList();
        }
    }
}
