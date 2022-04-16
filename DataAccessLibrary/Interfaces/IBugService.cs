using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public interface IBugService
    {
        Task<IEnumerable<BugModel>> SelectAllBugs();
        Task<BugModel> SelectBugByID(int id);
        Task InsertBug(BugModel bug);
    }
}