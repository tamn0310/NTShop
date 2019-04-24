using System;
using System.ComponentModel.DataAnnotations;

namespace NTShop.Web.Models
{
    public class FeedbackViewModel
    {
        public int ID { get; set; }

        [MaxLength(150, ErrorMessage = "Tên không quá 100 kí tự")]
        [Required]
        public string Name { get; set; }

        [MaxLength(250, ErrorMessage = "Địa chỉ email không quá 250 kí tự")]
        public string Email { get; set; }

        [MaxLength(500, ErrorMessage = "Tin nhắn không được quá 500 kí tự")]
        public string Message { get; set; }

        public DateTime CreatedDate { get; set; }

        [Required(ErrorMessage = "Phải nhập trạng thái")]
        public bool Status { get; set; }

        public ContactDetailViewModel ContactDetail { get; set; }
    }
}