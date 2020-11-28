using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DoAnAsp.Areas.Admin.Models
{
    public class BinhLuanModel
    {
        [Key]
        public int IdBL { get; set; }
        public string Anh { get; set; }
        [Required]
        [StringLength(30)]
        public string Ten { get; set; }
        [Required]
        public string Noidung { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Ngay { get; set; }
        public int IdSP { get; set; }
        [ForeignKey("IdSP")]
        public virtual SanPhamModel sanpham { get; set; }
    }
}
