using NTShop.Data.Infrastructure;
using NTShop.Model.Models;

namespace NTShop.Data.Reponsitories
{
    public interface ISupportOnlineRepository : IReponsitory<SupportOnline> { }

    public class SupportOnlineRepository : RepositoryBase<SupportOnline>, ISupportOnlineRepository
    {
        public SupportOnlineRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}