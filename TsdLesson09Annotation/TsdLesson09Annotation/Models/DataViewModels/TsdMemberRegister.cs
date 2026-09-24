using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TsdLesson09Annotation.Models.DataViewModels
{
    public class TsdMemberRegister
    {
            public int TsdMemberId { get; set; }

            [DisplayName("Tên đăng nhập")]
            [Required(ErrorMessage = "Tên đăng nhập không để trống")]
            [StringLength(20, MinimumLength = 3, ErrorMessage = "Tên đăng nhập có độ dài khoảng 3-20 ký tự !")]
            public string TsdUserName { get; set; }

            [DisplayName("Mật khẩu")]
            [Required(ErrorMessage = "Mật khẩu không để trống")]
            [DataType(DataType.Password)]
            public string TsdPassword { get; set; }
            public string TsdEmail { get; set; }
            public string TsdPhoneNumber { get; set; }
            public string TsdFullName { get; set; }
            public DateTime TsdBirthday { get; set; }
        }

}
