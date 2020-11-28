using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DoAnAsp.Areas.Admin.Models
{
    public class LoaiSPModelcs
    {
        [Key]
        public int IdLSP { get; set; }
        [Required]
        [StringLength(70)]
        public string TenLSP { get; set; }
        public bool Trangthai { get; set; }
        public ICollection<SanPhamModel> sanpham { get; set; }
    }
}
