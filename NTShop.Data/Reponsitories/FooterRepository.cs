using NTShop.Data.Infrastructure;
using NTShop.Model.Models;

namespace NTShop.Data.Reponsitories
{
    public interface IFooterRepository : IReponsitory<Footer>
    {
    }

    public class FooterRepository : RepositoryBase<Footer>, IFooterRepository
    {
        public FooterRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}