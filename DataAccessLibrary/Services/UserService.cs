using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary.Services
{
    public class UserService : IUserService
    {
        private readonly ISqlDataAccess _db;

        public UserService(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<UserModel> SelectUserByID(int id)
        {
            string sql = "SELECT * FROM dbo.User WHERE UserID = @id";

            return _db.LoadDataSingleOrDefault<UserModel, dynamic>(sql, new { id = id });
        }

        public Task InsertUser(UserModel user)
        {
            string sql = @"INSERT INTO dbo.User (UserEmail, UserName)
                            VALUES (UserEmail, UserName);";

            return _db.SaveData(sql, user);
        }
    }
}
