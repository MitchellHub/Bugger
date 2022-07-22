using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public interface IBugService
    {
        Task InsertBug(BugModel bug);
        Task<IEnumerable<BugModel>> SelectAllBugs();
        Task<IEnumerable<BugModel>> spSelectAllBugs();
        //Task<BugModel> SelectBugByID(int id);
        Task<BugModel> spSelect(int id);
    }
}