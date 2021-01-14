using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoAnAsp.Areas.Admin.Models
{
    public class HoaDonModel
    {
        [Key]
        public int IdHD { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime NgaylapHD { get; set; }
        public double Thanhtien { get; set; }
        [Required]
        public int IdUser { get; set; }
        [ForeignKey("IdUser")]
        public virtual UserModel user { get; set; }
        [StringLength(100)]
        public string Diachi { get; set; }
        [Phone]
        public string Sdt { get; set; }
        public bool Trangthai { get; set; }
     
        public ICollection<ChiTietHoaDonModel> chitiethoadon { get; set; }
        
    }
}
