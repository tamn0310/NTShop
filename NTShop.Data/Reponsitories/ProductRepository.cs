using NTShop.Data.Infrastructure;
using NTShop.Model.Models;

namespace NTShop.Data.Reponsitories
{
    public interface IProductRepository
    {
    }

    public class ProductRepository : RepositoryBase<Product>,IProductRepository
    {
        public ProductRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}