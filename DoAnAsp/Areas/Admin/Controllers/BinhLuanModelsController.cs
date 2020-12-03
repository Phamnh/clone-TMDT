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
    public class BinhLuanModelsController : Controller
    {
        private readonly DPContext _context;

        public BinhLuanModelsController(DPContext context)
        {
            _context = context;
        }

        // GET: Admin/BinhLuanModels
        public async Task<IActionResult> Index()
        {
            var dPContext = _context.binhluan.Include(b => b.sanpham);
            return View(await dPContext.ToListAsync());
        }

        // GET: Admin/BinhLuanModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var binhLuanModel = await _context.binhluan
                .Include(b => b.sanpham)
                .FirstOrDefaultAsync(m => m.IdBL == id);
            if (binhLuanModel == null)
            {
                return NotFound();
            }

            return View(binhLuanModel);
        }

        // GET: Admin/BinhLuanModels/Create
        public IActionResult Create()
        {
            ViewBag.IdSP = _context.sanpham.ToList();
            return View();
        }

        // POST: Admin/BinhLuanModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdBL,Anh,Ten,Noidung,Ngay,IdSP")] BinhLuanModel binhLuanModel, IFormFile ful)
        {
            if (ModelState.IsValid)
            {
                _context.Add(binhLuanModel);
                await _context.SaveChangesAsync();
                var parth = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/template/admin/img", 
                    binhLuanModel.IdBL + "." + ful.FileName.Split(".")
                    [ful.FileName.Split(".").Length - 1]);
                using (var stream = new FileStream(parth,FileMode.Create))
                {
                    await ful.CopyToAsync(stream);
                }
                binhLuanModel.Anh = binhLuanModel.IdBL + "." + ful.FileName.Split(".")
                    [ful.FileName.Split(".").Length - 1];
                _context.Update(binhLuanModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.IdSP = _context.sanpham.ToList();
            return View(binhLuanModel);
        }

        // GET: Admin/BinhLuanModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var binhLuanModel = await _context.binhluan.FindAsync(id);
            if (binhLuanModel == null)
            {
                return NotFound();
            }
            ViewData["IdSP"] = new SelectList(_context.sanpham, "IdSP", "TenSP", binhLuanModel.IdSP);
            return View(binhLuanModel);
        }

        // POST: Admin/BinhLuanModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdBL,Anh,Ten,Noidung,Ngay,IdSP")] BinhLuanModel binhLuanModel)
        {
            if (id != binhLuanModel.IdBL)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(binhLuanModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BinhLuanModelExists(binhLuanModel.IdBL))
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
            ViewData["IdSP"] = new SelectList(_context.sanpham, "IdSP", "TenSP", binhLuanModel.IdSP);
            return View(binhLuanModel);
        }

        // GET: Admin/BinhLuanModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var binhLuanModel = await _context.binhluan
                .Include(b => b.sanpham)
                .FirstOrDefaultAsync(m => m.IdBL == id);
            if (binhLuanModel == null)
            {
                return NotFound();
            }

            return View(binhLuanModel);
        }

        // POST: Admin/BinhLuanModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var binhLuanModel = await _context.binhluan.FindAsync(id);
            _context.binhluan.Remove(binhLuanModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BinhLuanModelExists(int id)
        {
            return _context.binhluan.Any(e => e.IdBL == id);
        }
    }
}
