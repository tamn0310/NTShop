using NTShop.Data.Infrastructure;
using NTShop.Model.Models;

namespace NTShop.Data.Reponsitories
{
    public interface IOrderRepository { }

    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        private OrderRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}