using System.ComponentModel;

namespace TsdLession08Models.Models
{
    public class TsdMember
    {
        public string TsdMemberId { get; set; }
        public string TsdUserName { get; set; }
        public string TsdPassword { get; set; }

        [DisplayName("Họ và tên")]
        public string TsdFullName { get; set; }
        public string TsdEmail { get; set; }
    }
}
