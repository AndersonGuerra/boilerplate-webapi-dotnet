using WebAPI.Models;

namespace WebAPI.Interfaces
{
    public interface IUserRepository
    {
        List<User> GetUsers();
        User? GetUser(int Id);
        User CreateUser(User user);
    }
}