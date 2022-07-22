using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Linq;
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

        public Task<IEnumerable<BugModel>> spSelectAllBugs() => _db.LoadDataUsingStoredProcedure<BugModel, dynamic>("dbo.spBug_SelectAllBugs", new { });


        //public Task<BugModel> SelectBugByID(int id)
        //{
        //    string sql = "SELECT * FROM dbo.Bug WHERE BugID = @id";

        //    return _db.LoadDataSingleOrDefault<BugModel, dynamic>(sql, new { id = id });
        //}

        public async Task<BugModel?> spSelect(int BugId)
        {
            var results = await _db.LoadDataUsingStoredProcedure<BugModel, dynamic>("dbo.spBug_Select", new { BugId = BugId });

            return results.FirstOrDefault();
        }

        public Task InsertBug(BugModel bug)
        {
            string sql = @"INSERT INTO dbo.Bug (BugTitle, BugDescription, BugCompleted)
                            VALUES (@BugTitle, @BugDescription, @BugCompleted);";

            return _db.SaveData(sql, bug);
        }

    }
}