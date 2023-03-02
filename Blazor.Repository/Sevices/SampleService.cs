using Blazor.Infrastructure.Database;
using Blazor.Infrastructure.SPModals;
using Blazor.Repository.Interface;
using Blazor.Shared;
using System.Linq;

namespace Blazor.Repository.Sevices
{
    /// <summary>
    /// SampleService
    /// </summary>
    public class SampleService : ISampleService
    {
        private readonly IBlazorRepository<SampleTable> _sampleTableRepository;
        private readonly IBaseStoredProc _baseStoredProc;
        public SampleService(IBlazorRepository<SampleTable> sampleTableRepository, IBaseStoredProc baseStoredProc)
        {
            _baseStoredProc = baseStoredProc;
            _sampleTableRepository = sampleTableRepository;
        }

        /// <summary>
        /// GetSPData
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<CustomSPModel_Get_Result>> GetSPData()
        {
            try
            {
                var result= await _baseStoredProc.ExecuteStoredProcCollectionAsync<CustomSPModel_Get_Result>("SampleSP");
                return result;
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        /// <summary>
        /// GetTableData
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<SampleTable>> GetTableData()
        {
            try
            {
                var result= await _sampleTableRepository.GetAllAsync();
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        /// <summary>
        /// AddTableData
        /// </summary>
        /// <param name="sampleTable"></param>
        /// <returns></returns>
        public async Task AddTableData(SampleTable sampleTable)
        {
            try
            {
                await _sampleTableRepository.AddAsync(sampleTable, 1);
                await _sampleTableRepository.SaveChangesAsync();
            }
            catch (Exception ex)
            {
            }
        }

        /// <summary>
        /// UpdateTableData
        /// </summary>
        /// <param name="sampleTable"></param>
        public async Task UpdateTableData(SampleTable sampleTable)
        {
            try
            {
                _sampleTableRepository.Update(sampleTable, 1);
                await _sampleTableRepository.SaveChangesAsync();
            }
            catch (Exception ex)
            {
            }
        }

        /// <summary>
        /// DeleteTableData
        /// </summary>
        /// <param name="sampleTable"></param>
        public async Task DeleteTableData(SampleTable sampleTable)
        {
            try
            {
                _sampleTableRepository.Delete(sampleTable);
                await _sampleTableRepository.SaveChangesAsync();
            }
            catch (Exception ex)
            {
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pageNo"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public async Task<IEnumerable<SampleTable>> GetPaginatedTableData(int pageNo, int pageSize)
        {
            try
            {
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
                var result = await _sampleTableRepository.GetAllPagingAsync(null
                    ,pageNo,pageSize);
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        /// <summary>
        /// Getting Data via Custum model 
        /// </summary>
        /// <returns></returns>
        public async Task<List<SampleModal>> GetDataUsingCustomModel()
        {
            try
            {
                var result = await _sampleTableRepository.GetAllAsync();
                var CustomModel = result.Select(x=> new SampleModal
                {
                    Id=x.Id,
                    FullName=x.FullName

                }).OrderBy(x=>x.FullName).ToList();
                return CustomModel;
            }
            catch (Exception ex)
            {

                return null; 
            }
        }
    }
}
