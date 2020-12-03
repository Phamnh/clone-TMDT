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
    public class HoaDonModelsController : Controller
    {
        private readonly DPContext _context;

        public HoaDonModelsController(DPContext context)
        {
            _context = context;
        }

        // GET: Admin/HoaDonModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.hoadon.ToListAsync());
        }

        // GET: Admin/HoaDonModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hoaDonModel = await _context.hoadon
                .FirstOrDefaultAsync(m => m.IdHD == id);
            if (hoaDonModel == null)
            {
                return NotFound();
            }

            return View(hoaDonModel);
        }

        // GET: Admin/HoaDonModels/Create
        public IActionResult Create()
        {
            ViewBag.IdUser = _context.user.ToList();
            return View();
        }

        // POST: Admin/HoaDonModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdHD,NgaylapHD,Thanhtien,IdUser,Diachi,Sdt,Trangthai")] HoaDonModel hoaDonModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hoaDonModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hoaDonModel);
        }

        // GET: Admin/HoaDonModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hoaDonModel = await _context.hoadon.FindAsync(id);
            if (hoaDonModel == null)
            {
                return NotFound();
            }
            return View(hoaDonModel);
        }

        // POST: Admin/HoaDonModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdHD,NgaylapHD,Thanhtien,IdUser,Diachi,Sdt,Trangthai")] HoaDonModel hoaDonModel)
        {
            if (id != hoaDonModel.IdHD)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hoaDonModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HoaDonModelExists(hoaDonModel.IdHD))
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
            return View(hoaDonModel);
        }

        // GET: Admin/HoaDonModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hoaDonModel = await _context.hoadon
                .FirstOrDefaultAsync(m => m.IdHD == id);
            if (hoaDonModel == null)
            {
                return NotFound();
            }

            return View(hoaDonModel);
        }

        // POST: Admin/HoaDonModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var hoaDonModel = await _context.hoadon.FindAsync(id);
            _context.hoadon.Remove(hoaDonModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HoaDonModelExists(int id)
        {
            return _context.hoadon.Any(e => e.IdHD == id);
        }
    }
}
