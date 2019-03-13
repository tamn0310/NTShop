using System.Collections.Generic;
using System.Linq;

namespace NTShop.Web.Infrastructure.Core
{
    public class PaginationSet<T>
    {
        public int Page { set; get; }
        public int TotalPages { set; get; }
        public int TotalCount { set; get; }

        public int Count
        {
            get
            {
                return (Items != null) ? Items.Count() : 0;
            }
        }

        public IEnumerable<T> Items { set; get; }
    }
}