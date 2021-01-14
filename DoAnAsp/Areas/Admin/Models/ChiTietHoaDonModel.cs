using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DoAnAsp.Areas.Admin.Models
{
    public class ChiTietHoaDonModel
    {
        [Key]
        public int IdCTHD { get; set; }
        public int Soluong { get; set; }
        public double Tongtien { get; set; }
        public int IdHD { get; set; }
        [ForeignKey("IdHD")]
        public virtual HoaDonModel hoadon { get; set; }
        public int IdSP { get; set; }
        [ForeignKey("IdSP")]
        public bool Trangthai { get; set; }
        
       
    }
}
