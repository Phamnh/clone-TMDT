using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DoAnAsp.Areas.Admin.Views
{
    public class AdminModel
    {
        [Key]
        public int IdAdmin { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter a valid Username")]
        [StringLength(20)]
        public string Username { get; set; }
        [DataType(DataType.Password)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter a valid password")]
        [StringLength(20)]
        public string Password { get; set; }
        [StringLength(30)]
        public string Hoten { get; set; }
        [Phone]
        public string Sdt { get; set; }
        [EmailAddress(ErrorMessage = "Please enter a valid email")]
        public string Email { get; set; }
    }
}
