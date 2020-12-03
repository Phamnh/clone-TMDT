using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DoAnAsp.Areas.Admin.Data;
using DoAnAsp.Areas.Admin.Models;

namespace DoAnAsp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ChiTietHoaDonModelsController : Controller
    {
        private readonly DPContext _context;

        public ChiTietHoaDonModelsController(DPContext context)
        {
            _context = context;
        }

        // GET: Admin/ChiTietHoaDonModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.chitiethoadon.ToListAsync());
        }

        // GET: Admin/ChiTietHoaDonModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chiTietHoaDonModel = await _context.chitiethoadon
                .FirstOrDefaultAsync(m => m.IdCTHD == id);
            if (chiTietHoaDonModel == null)
            {
                return NotFound();
            }

            return View(chiTietHoaDonModel);
        }

        // GET: Admin/ChiTietHoaDonModels/Create
        public IActionResult Create()
        {
            ViewBag.IdHD = _context.hoadon.ToList();
            ViewBag.IdSP = _context.sanpham.ToList();
            return View();
        }

        // POST: Admin/ChiTietHoaDonModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdCTHD,Soluong,Tongtien,IdHD,IdSP,Trangthai")] ChiTietHoaDonModel chiTietHoaDonModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(chiTietHoaDonModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(chiTietHoaDonModel);
        }

        // GET: Admin/ChiTietHoaDonModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chiTietHoaDonModel = await _context.chitiethoadon.FindAsync(id);
            if (chiTietHoaDonModel == null)
            {
                return NotFound();
            }
            return View(chiTietHoaDonModel);
        }

        // POST: Admin/ChiTietHoaDonModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdCTHD,Soluong,Tongtien,IdHD,IdSP,Trangthai")] ChiTietHoaDonModel chiTietHoaDonModel)
        {
            if (id != chiTietHoaDonModel.IdCTHD)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(chiTietHoaDonModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChiTietHoaDonModelExists(chiTietHoaDonModel.IdCTHD))
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
            return View(chiTietHoaDonModel);
        }

        // GET: Admin/ChiTietHoaDonModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chiTietHoaDonModel = await _context.chitiethoadon
                .FirstOrDefaultAsync(m => m.IdCTHD == id);
            if (chiTietHoaDonModel == null)
            {
                return NotFound();
            }

            return View(chiTietHoaDonModel);
        }

        // POST: Admin/ChiTietHoaDonModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var chiTietHoaDonModel = await _context.chitiethoadon.FindAsync(id);
            _context.chitiethoadon.Remove(chiTietHoaDonModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ChiTietHoaDonModelExists(int id)
        {
            return _context.chitiethoadon.Any(e => e.IdCTHD == id);
        }
    }
}
