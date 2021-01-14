using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DoAnAsp.Areas.Admin.Models
{
    public class SanPhamModel
    {
        [Key]
        public int IdSP { get; set; }
        [Required]
        [StringLength(100)]
        public string TenSP { get; set; }
        public string Anh { get; set; }
        public double Gia { get; set; }
        [StringLength(20)]
        public string Donvitinh { get; set; }
        [Required]
        public int Soluongton { get; set; }
        public int IdNCC { get; set; }
        [ForeignKey("IdNCC")]
        public virtual NhaCungCapModel nhacungcap { get; set; }
        public int IdLSP { get; set; }
        [ForeignKey("IdLSP")]
        public virtual LoaiSPModelcs loaisp { get; set; }
        public string Mota { get; set; }
        public bool Trangthai { get; set; }
        public ICollection<BinhLuanModel> binhluan { get; set; }
        
        
    }
}
