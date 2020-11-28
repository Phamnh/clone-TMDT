using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DoAnAsp.Models;
using DoAnAsp.Areas.Admin.Views;
using DoAnAsp.Areas.Admin.Models;

namespace DoAnAsp.Areas.Admin.Data
{
    public class DPContext:DbContext
    {
        public DPContext(DbContextOptions<DPContext> options) : base(options) { }
        public DbSet<AdminModel> admin { get; set; }
        public DbSet<UserModel> user { get; set; }
        public DbSet<NhaCungCapModel> nhacungcap { get; set; }
        public DbSet<LoaiSPModelcs> loaisanpham { get; set; }
        public DbSet<SanPhamModel> sanpham { get; set; }
        public DbSet<HoaDonModel> hoadon { get; set; }
        public DbSet<ChiTietHoaDonModel> chitiethoadon { get; set; }
        public DbSet<BinhLuanModel> binhluan { get; set; }
    }
}
