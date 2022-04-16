using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    /// <summary>
    /// Service for accessing dbo.Bug data
    /// </summary>
    public class BugService : IBugService
    {
        private readonly ISqlDataAccess _db;

        public BugService(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<IEnumerable<BugModel>> SelectAllBugs()
        {
            string sql = "SELECT * FROM dbo.Bug";

            return _db.LoadData<BugModel, dynamic>(sql, new { });
        }

        public Task<BugModel> SelectBugByID(int id)
        {
            string sql = "SELECT * FROM dbo.Bug WHERE BugID = @id";

            return _db.LoadDataSingleOrDefault<BugModel, dynamic>(sql, new { id = id });
        }

        public Task InsertBug(BugModel bug)
        {
            string sql = @"INSERT INTO dbo.Bug (BugTitle, BugDescription, BugCompleted)
                            VALUES (@BugTitle, @BugDescription, @BugCompleted);";

            return _db.SaveData(sql, bug);
        }
    }
}