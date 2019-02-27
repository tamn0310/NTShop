using System;
using System.Collections.Generic;

namespace NTShop.Web.Models
{
    public class PostViewModel
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Alias { get; set; }

        public int CategoryID { get; set; }

        public string Image { get; set; }

        public string Description { get; set; }

        public string Content { get; set; }

        public bool? HomeFlag { get; set; }

        public bool? HotFlag { get; set; }

        public DateTime? CreatedDate { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public string UpdatedBy { get; set; }

        public string MateKeyword { get; set; }

        public string MateDescription { get; set; }

        public bool Status { set; get; }

        public virtual PostCategoryViewModel PostCategory { get; set; }

        public virtual IEnumerable<PostTagViewModel> PostTags { get; set; }
    }
}