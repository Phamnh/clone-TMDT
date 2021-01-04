using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DoAnAsp.Areas.Admin.Data;
using DoAnAsp.Areas.Admin.Models;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace DoAnAsp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SanPhamModelsController : Controller
    {
        private readonly DPContext _context;

        public SanPhamModelsController(DPContext context)
        {
            _context = context;
        }

        // GET: Admin/SanPhamModels
        public async Task<IActionResult> Index()
        {
            try
            {
                var list = _context.admin.Where(s => s.Username == HttpContext.Session.GetString("username").ToString());
                if (list.Count() != 0)
                {
                    ViewBag.Username = HttpContext.Session.GetString("username").ToString();
                    return View(await _context.sanpham.ToListAsync());
                }
                else
                {
                    var url = Url.RouteUrl(new { controller = "Home", action = "Index", area = "" });
                    return Redirect(url);
                }
            }
            catch(Exception e)
            {
                var url = Url.RouteUrl(new { controller = "Login", action = "Index", area = "" });
                return Redirect(url);
            }
          
           
        }

        // GET: Admin/SanPhamModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sanPhamModel = await _context.sanpham
                .FirstOrDefaultAsync(m => m.IdSP == id);
            if (sanPhamModel == null)
            {
                return NotFound();
            }

            return View(sanPhamModel);
        }

        // GET: Admin/SanPhamModels/Create
        public IActionResult Create()
        {
            ViewBag.IdNCC = _context.nhacungcap.ToList();
            ViewBag.IdLSP = _context.loaisanpham.ToList();
            return View();
        }

        // POST: Admin/SanPhamModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdSP,TenSP,Anh,Gia,Donvitinh,Soluongton,IdNCC,IdLSP,Mota,Trangthai")] SanPhamModel sanPhamModel, IFormFile ful)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sanPhamModel);
                await _context.SaveChangesAsync();
                var parth = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/template/admin/img",
                    sanPhamModel.IdSP + "." + ful.FileName.Split(".")
                    [ful.FileName.Split(".").Length - 1]);
                using (var stream = new FileStream(parth, FileMode.Create))
                {
                    await ful.CopyToAsync(stream);
                }
                sanPhamModel.Anh = sanPhamModel.IdSP + "." + ful.FileName.Split(".")
                    [ful.FileName.Split(".").Length - 1];
                _context.Update(sanPhamModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.IdNCC = _context.nhacungcap.ToList();
            ViewBag.IdLSP = _context.loaisanpham.ToList();
            return View(sanPhamModel);
        }

        // GET: Admin/SanPhamModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sanPhamModel = await _context.sanpham.FindAsync(id);
            if (sanPhamModel == null)
            {
                return NotFound();
            }
            ViewBag.IdNCC = _context.nhacungcap.ToList();
            ViewBag.IdLSP = _context.loaisanpham.ToList();
            return View(sanPhamModel);
        }

        // POST: Admin/SanPhamModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdSP,TenSP,Anh,Gia,Donvitinh,Soluongton,IdNCC,IdLSP,Mota,Trangthai")] SanPhamModel sanPhamModel, IFormFile ful, string HinhAnh)
        {
            if (id != sanPhamModel.IdSP)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                   
                    var parth = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/template/admin/img", HinhAnh);
                    System.IO.File.Delete(parth);
                    if(ful == null)
                    {
                        sanPhamModel.Anh = HinhAnh;
                    }
                    else
                    {
                        parth = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/template/admin/img", sanPhamModel.IdSP + "." + ful.FileName.Split(".")
                        [ful.FileName.Split(".").Length - 1]);
                        using (var stream = new FileStream(parth, FileMode.Create))
                        {
                            await ful.CopyToAsync(stream);
                        }
                        sanPhamModel.Anh = sanPhamModel.IdSP + "." + ful.FileName.Split(".")
                            [ful.FileName.Split(".").Length - 1];
                    }
                    
                    _context.Update(sanPhamModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SanPhamModelExists(sanPhamModel.IdSP))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            
            return View(sanPhamModel);
        }

        // GET: Admin/SanPhamModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sanPhamModel = await _context.sanpham
                .FirstOrDefaultAsync(m => m.IdSP == id);
            if (sanPhamModel == null)
            {
                return NotFound();
            }

            return View(sanPhamModel);
        }

        // POST: Admin/SanPhamModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sanPhamModel = await _context.sanpham.FindAsync(id);
            _context.sanpham.Remove(sanPhamModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SanPhamModelExists(int id)
        {
            return _context.sanpham.Any(e => e.IdSP == id);
        }
    }
}
