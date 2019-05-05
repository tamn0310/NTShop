using NTShop.Common.ViewModels;
using NTShop.Data.Reponsitories;
using System.Collections.Generic;

namespace NTShop.Service
{
    public interface IStatisticService
    {
        IEnumerable<RevenueStatisticViewModel> GetRevenueStatistic(string fromDate, string toDate);
    }

    public class StatisticService : IStatisticService
    {
        IOrderRepository _orderRepository;

        public StatisticService(IOrderRepository orderRepository)
        {
            this._orderRepository = orderRepository;
        }

        public IEnumerable<RevenueStatisticViewModel> GetRevenueStatistic(string fromDate, string toDate)
        {
            return _orderRepository.GetRevenueStatistic(fromDate, toDate);
        }
    }
}