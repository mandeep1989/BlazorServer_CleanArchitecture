namespace Blazor.Repository.Interface
{
    /// <summary>
    /// Base Stored Proc Interface
    /// </summary>
    public interface IBaseStoredProc
    {
        /// <summary>
        /// Execute Stored Proc Async
        /// </summary>
        /// <param name="storedProcedure"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public Task<int> ExecuteStoredProcAsync
            (string storedProcedure, params object[] parameters);

        /// <summary>
        /// ExecuteStoredProcWithIDAsync
        /// </summary>
        /// <param name="storedProcedure"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public Task<int> ExecuteStoredProcWithIDAsync
            (string storedProcedure, params object[] parameters);

        /// <summary>
        /// ExecuteStoredProcAsync
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="storedProcedure"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public Task<TEntity> ExecuteStoredProcAsync<TEntity>
            (string storedProcedure, params object[] parameters) where TEntity : class;

        /// <summary>
        /// ExecuteStoredProcCollectionAsync
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="storedProcedure"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public Task<ICollection<TEntity>> ExecuteStoredProcCollectionAsync<TEntity>
            (string storedProcedure, params object[] parameters) where TEntity : class;

        /// <summary>
        /// ExecuteStoredProcDriveExecutivesDetailsAsync
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="storedProcedure"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public Task<ICollection<TEntity>> ExecuteStoredProcDriveExecutivesDetailsAsync<TEntity>
            (string storedProcedure, params object[] parameters) where TEntity : class;

        /// <summary>
        /// ExecuteStoredProcActiveExecutiveDetailsAsync
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="storedProcedure"></param>
        /// <returns></returns>
        public Task<ICollection<TEntity>> ExecuteStoredProcActiveExecutiveDetailsAsync<TEntity>
            (string storedProcedure) where TEntity : class;
    }
}
