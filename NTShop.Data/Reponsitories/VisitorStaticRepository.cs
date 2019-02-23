using NTShop.Data.Infrastructure;
using NTShop.Model.Models;

namespace NTShop.Data.Reponsitories
{
    public interface IVisitorStaticRepository : IReponsitory<VisitorStatistic> { }

    public class VisitorStaticRepository : RepositoryBase<VisitorStatistic>, IVisitorStaticRepository
    {
        public VisitorStaticRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}