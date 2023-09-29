using TestTask.Models;

namespace TestTask.Repositories.Interfaces
{
    public interface IUserRepository
    {
        public User GetUser();

        public List<User> GetUsers();
    }
}
