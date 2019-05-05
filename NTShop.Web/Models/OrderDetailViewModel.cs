namespace NTShop.Web.Models
{
    public class OrderDetailViewModel
    {
        public int OrderID { get; set; }

        public int ProductID { get; set; }

        public int Quantitty { get; set; }

        public decimal Price { get; set; }
    }
}