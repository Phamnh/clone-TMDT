using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DoAnAsp.Areas.Admin.Models
{
    public class UserModel
    {
        [Key]
        public int IdUser { get; set; }
        [StringLength(30)]
        public string HotenUser { get; set; }
        [EmailAddress(ErrorMessage = "Please enter a valid email")]
        public string EmailUser { get; set; }
        [Phone]
        public string SdtUser { get; set; }
        [StringLength(100)]
        public string DiachiUser { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter a valid Username")]
        [StringLength(20)]
        public string UsernameUser { get; set; }
        [DataType(DataType.Password)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter a valid password")]
        [StringLength(20)]
        public string PasswordUser { get; set; }
        public bool TrangthaiUser { get; set; }
        public ICollection<HoaDonModel> hoadon { get; set; }

    }
}
