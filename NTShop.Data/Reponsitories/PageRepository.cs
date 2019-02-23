using NTShop.Data.Infrastructure;
using NTShop.Model.Models;

namespace NTShop.Data.Reponsitories
{
    public interface IPageRepository : IReponsitory<Page> { }

    public class PageRepository : RepositoryBase<Page>, IPageRepository
    {
        public PageRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}