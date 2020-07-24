using System;

namespace NTShop.Web.Models
{
    public class PageViewModel
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Alias { get; set; }

        public string Content { get; set; }

        public DateTime? CreatedDate { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public string UpdatedBy { get; set; }

        public string MateKeyword { get; set; }

        public string MateDescription { get; set; }

        public bool Status { set; get; }
    }
}