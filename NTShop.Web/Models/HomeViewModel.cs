using System.Collections.Generic;

namespace NTShop.Web.Models
{
    public class HomeViewModel
    {
        public IEnumerable<SlideViewModel> Slides { get; set; }
        public IEnumerable<ProductViewModel> LastestProducts { get; set; }
        public IEnumerable<ProductViewModel> TopSaleProducts { get; set; }

        public string Title { get; set; }

        public string Metakeyword { get; set; }

        public string MetaDescription { get; set; }
    }
}