using NTShop.Data.Infrastructure;
using NTShop.Model.Models;
using System.Collections.Generic;
using System.Linq;

namespace NTShop.Data.Reponsitories
{
    public interface IProductCategoryRepository : IReponsitory<ProductCategory>
    {
        IEnumerable<ProductCategory> GetByAlias(string alias);
    }

    public class ProductCategoryRepository : RepositoryBase<ProductCategory>, IProductCategoryRepository
    {
        public ProductCategoryRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {
        }

        public IEnumerable<ProductCategory> GetByAlias(string alias)
        {
            return this.DbContext.ProductCategories.Where(x => x.Alias == alias);
        }
    }
}