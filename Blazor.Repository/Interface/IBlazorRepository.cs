using System.Linq.Expressions;

namespace Blazor.Repository.Interface
{
    /// <summary>
    /// Blazor Repository Interface
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface IBlazorRepository<TEntity>
    {
        /// <summary>
        /// Save all the changes to database ***Mandatory to call this function after every transaction.
        /// </summary>
        /// <returns></returns>
        public Task<bool> SaveChangesAsync();

        #region Get Methods

        /// <summary>
        ///  Get all data list of entity.
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<TEntity>> GetAllAsync();

        /// <summary>
        /// Get all data list of entity based on given condition.
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public Task<IEnumerable<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> filter);

        /// <summary>
        /// Get all data list of entity based on given condition including joint properties.
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="includeProperties"></param>
        /// <returns></returns>
        public Task<IEnumerable<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> filter, params Expression<Func<TEntity, object>>[] includeProperties);


        /// <summary>
        /// Get all data list of entity including joint properties.
        /// </summary>
        /// <param name="includeProperties"></param>
        /// <returns></returns>
        public Task<IEnumerable<TEntity>> GetAllAsync(params Expression<Func<TEntity, object>>[] includeProperties);

        /// <summary>
        /// Get Entity based on given condition
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> filter);

        /// <summary>
        /// Get Entity based on given condition including joint properties.
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="includeProperties"></param>
        /// <returns></returns>
        public Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> filter, params Expression<Func<TEntity, object>>[] includeProperties);

        public Task<IEnumerable<TEntity>> GetAllPagingAsync(
            Expression<Func<TEntity, bool>> filter = null, int? page = null, int? pageSize = null,
            params Expression<Func<TEntity, object>>[] navigationProperties
        );

        #endregion


        #region Add Methods

        /// <summary>
        /// Add new entry
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="createdby"></param>
        /// <returns></returns>
        public Task AddAsync(TEntity entity, int createdby);

        /// <summary>
        /// Add new batch entry
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public Task AddRangeAsync(IEnumerable<TEntity> entities);
        #endregion


        #region Update Methods

        /// <summary>
        /// Update entity
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="modifiedBy"></param>
        public void Update(TEntity entity, int modifiedBy);

        /// <summary>
        /// Update batch at once
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public void UpdateRange(IEnumerable<TEntity> entities);

        #endregion


        #region Delete Methods

        /// <summary>
        ///  Remove entry from database permanently
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public void Delete(TEntity entity);

        /// <summary>
        /// Remove batch from database permanently
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public void DeleteRange(IEnumerable<TEntity> entities);


        /// <summary>
        /// Archive entry from database (Set IsDeleted = 1 or transfer to archive table)
        /// </summary>
        /// <param name="modifiedBy"></param>
        /// <param name="id"></param>
        public Task Remove(object id, int modifiedBy);

        /// <summary>
        /// Archive batch from database (Set IsDeleted = 1 or transfer to archive table)
        /// </summary>
        /// <param name="modifiedBy"></param>
        /// <param name="filter"></param>
        /// <returns></returns>
        public Task RemoveRange(Expression<Func<TEntity, bool>> filter, int modifiedBy);

        #endregion


        #region Extensions or Miscellaneous Methods

        /// <summary>
        /// To check whether entity exists or not based on (optional) filter
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public Task<bool> IsExistsAsync(Expression<Func<TEntity, bool>> filter = null);

        /// <summary>
        /// To get the data count of entity present based on (optional) filter
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public Task<int> CountAsync(Expression<Func<TEntity, bool>> filter = null);

        #endregion

    }
}
