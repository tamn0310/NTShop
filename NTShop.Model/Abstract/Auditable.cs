using System;
using System.ComponentModel.DataAnnotations;

namespace NTShop.Model.Abstract
{
    public abstract class Auditable : IAuditable
    {
        public DateTime? CreatedDate { get; set; }

        [MaxLength(256)]
        public string CreatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [MaxLength(256)]
        public string UpdatedBy { get; set; }

        [MaxLength(256)]
        public string MateKeyword { get; set; }

        [MaxLength(256)]
        public string MateDescription { get; set; }

        public bool Status { set; get; }
    }
}