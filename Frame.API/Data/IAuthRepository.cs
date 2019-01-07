using System.Threading.Tasks;
using Frame.API.Models;

namespace Frame.API.Data
{
    public interface IAuthRepository
    {
         Task<User> Register(User user, string email);
         Task<User> Login(string email, string password);
         Task<bool> UserExists(string email);
    }
}