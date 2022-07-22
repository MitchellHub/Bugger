using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public interface ISqlDataAccess
    {
        string ConnectionStringName { get; set; }

        Task<IEnumerable<T>> LoadData<T, U>(string sql, U parameters);
        Task<T> LoadDataSingleOrDefault<T, U>(string sql, U parameters);
        Task<IEnumerable<T>> LoadDataUsingStoredProcedure<T, U>(string storedProcedure, U parameters);
        Task SaveData<T>(string sql, T parameters);
        Task SaveDataUsingStoredProcedure<T>(string storedProcedure, T parameters);
    }
}