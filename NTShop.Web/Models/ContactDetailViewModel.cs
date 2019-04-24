using System.ComponentModel.DataAnnotations;

namespace NTShop.Web.Models
{
    public class ContactDetailViewModel
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Tên không được để trống")]
        public string Name { get; set; }

        [MaxLength(50, ErrorMessage = "Số điện thoại không được vượt quá 50 kí tự")]
        public string Phone { get; set; }

        [MaxLength(250, ErrorMessage = "Địa chỉ website không được vượt quá 50 kí tự")]
        public string Website { get; set; }

        [MaxLength(250, ErrorMessage = "Địa chỉ không được vượt quá 50 kí tự")]
        public string Address { get; set; }

        [MaxLength(250, ErrorMessage = "Email không được vượt quá 50 kí tự")]
        public string Email { get; set; }

        public string Orther { get; set; }

        public double? Lat { get; set; }

        public double? Lng { get; set; }

        public bool Status { get; set; }
    }
}