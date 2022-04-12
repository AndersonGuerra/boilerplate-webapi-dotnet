using WebAPI.Database;
using WebAPI.Interfaces;
using WebAPI.Models;

namespace WebAPI.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DatabaseContext _dbContext;

        public UserRepository(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public User? GetUser(int Id)
        {
            return _dbContext.User.FirstOrDefault(x => x.Id == Id);
        }

        public List<User> GetUsers()
        {
            return _dbContext.User.ToList();
        }
        public User CreateUser(User user)
        {
            _dbContext.User.Add(user);
            _dbContext.SaveChanges();
            return user;
        }
    }
}