using System.Linq;
using ProductApi.Data.Entities;

namespace ProductApi.Data
{
    /// <summary>
    /// Product repository interface
    /// </summary>
    public partial interface IProductRepository
    {
        #region Properties

        /// <summary>
        /// Gets a table
        /// </summary>
        IQueryable<Product> Table { get; }

        #endregion

        #region Methods

        /// <summary>
        /// Get entity by identifier
        /// </summary>
        /// <param name="id">Identifier</param>
        /// <returns>Entity</returns>
        Product Get(int id);

        /// <summary>
        /// Insert entity
        /// </summary>
        /// <param name="entity">Entity</param>
        /// <returns>Identifier</returns>
        int Insert(Product entity);

        /// <summary>
        /// Update entity
        /// </summary>
        /// <param name="entity">Entity</param>
        void Update(Product entity);

        /// <summary>
        /// Delete entity
        /// </summary>
        /// <param name="entity">Entity</param>
        void Delete(Product entity);

        #endregion
    }
}
