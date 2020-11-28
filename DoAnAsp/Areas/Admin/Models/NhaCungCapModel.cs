using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DoAnAsp.Areas.Admin.Models
{
    public class NhaCungCapModel
    {
        [Key]
        public int IdNCC { get; set; }
        [Required]
        [StringLength(100)]
        public string TenNCC { get; set; }
        [Phone]
        public int SdtNCC { get; set; }
        public bool TrangThai { get; set; }
        public ICollection<SanPhamModel> sanpham { get; set; }
    }
}
