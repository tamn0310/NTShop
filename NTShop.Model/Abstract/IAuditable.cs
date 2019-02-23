using System;

namespace NTShop.Model.Abstract
{
    public interface IAuditable
    {
        DateTime? CreatedDate { get; set; }
        string CreatedBy { get; set; }
        DateTime? UpdatedDate { get; set; }
        string UpdatedBy { get; set; }

        string MateKeyword { get; set; }
        string MateDescription { get; set; }

        bool Status { set; get; }
    }
}