using TestTask.Models;
using TestTask.Repositories.Interfaces;
using TestTask.Services.Interfaces;

namespace TestTask.Services.Impl
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public Task<User> GetUser()
        {
            return Task.FromResult(_repository.GetUser());
        }

        public Task<List<User>> GetUsers()
        {
            return Task.FromResult(_repository.GetUsers());
        }
    }
}
