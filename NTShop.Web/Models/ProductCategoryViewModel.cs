﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NTShop.Web.Models
{
    public class ProductCategoryViewModel
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Alias { get; set; }

        public string Description { get; set; }

        public int? ParentID { get; set; }
        public int? DisplayOrder { get; set; }

        public string Image { get; set; }

        public bool? HomeFlag { get; set; }

        public DateTime? CreatedDate { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public string UpdatedBy { get; set; }

        public string MateKeyword { get; set; }

        public string MateDescription { get; set; }

        [Required]
        public bool Status { set; get; }

        public virtual IEnumerable<ProductViewModel> Products { get; set; }
    }
}