using System.ComponentModel.DataAnnotations;

namespace NTShop.Web.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Bạn chưa nhập tên tài khoản.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Bạn chưa nhập mật khẩu.")]
        [DataType(DataType.Password)]
        public string PassWord { get; set; }

        public bool RememberMe { get; set; }
    }
}