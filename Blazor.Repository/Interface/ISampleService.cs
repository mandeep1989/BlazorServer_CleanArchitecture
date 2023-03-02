using Blazor.Infrastructure.Database;
using Blazor.Infrastructure.SPModals;
using Blazor.Shared;

namespace Blazor.Repository.Interface
{
    /// <summary>
    /// Serice interface
    /// </summary>
    public interface ISampleService
    {
        /// <summary>
        /// Get Data from SP
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<CustomSPModel_Get_Result>> GetSPData();

        /// <summary>
        /// Get Data from Table
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<SampleTable>> GetTableData();

        /// <summary>
        /// GetPaginatedTableData
        /// </summary>
        /// <param name="pageNo"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        Task<IEnumerable<SampleTable>> GetPaginatedTableData(int pageNo, int pageSize);

        /// <summary>
        /// Data via Custom Model
        /// </summary>
        /// <returns></returns>
        Task<List<SampleModal>> GetDataUsingCustomModel();

        /// <summary>
        /// AddTableData
        /// </summary>
        /// <param name="sampleTable"></param>
        /// <returns></returns>
        Task AddTableData(SampleTable sampleTable);

        /// <summary>
        /// DeleteTableData
        /// </summary>
        /// <param name="sampleTable"></param>
        /// <returns></returns>
        Task DeleteTableData(SampleTable sampleTable);

        /// <summary>
        /// UpdateTableData
        /// </summary>
        /// <param name="sampleTable"></param>
        Task UpdateTableData(SampleTable sampleTable);
    }
}
