using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NTShop.Web.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage ="Bạn cần nhập tên của mình.")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Bạn cần nhập tên tài khoản của mình.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Bạn cần nhập mật khẩu.")]
        [MinLength(6,ErrorMessage ="Mật khẩu ít nhất 6 kí tự.")]
        public string PassWord { get; set; }

        [Required(ErrorMessage = "Bạn cần nhập email của mình.")]
        [EmailAddress(ErrorMessage ="Địa chỉ email không đúng định dạng.")]
        public string Email { get; set; }

       
        public string Address { get; set; }

        [Required(ErrorMessage = "Bạn cần nhập số điện thoại của mình.")]
        public string PhoneNumber { get; set; }
    }
}