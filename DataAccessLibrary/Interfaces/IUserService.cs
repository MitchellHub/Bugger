using DataAccessLibrary.Models;
using System.Threading.Tasks;

namespace DataAccessLibrary.Services
{
    public interface IUserService
    {
        Task InsertUser(UserModel user);
        Task<UserModel> SelectUserByID(int id);
    }
}