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
    public class LoaiSPModelcsController : Controller
    {
        private readonly DPContext _context;

        public LoaiSPModelcsController(DPContext context)
        {
            _context = context;
        }

        // GET: Admin/LoaiSPModelcs
        public async Task<IActionResult> Index()
        {
            return View(await _context.loaisanpham.ToListAsync());
        }

        // GET: Admin/LoaiSPModelcs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loaiSPModelcs = await _context.loaisanpham
                .FirstOrDefaultAsync(m => m.IdLSP == id);
            if (loaiSPModelcs == null)
            {
                return NotFound();
            }

            return View(loaiSPModelcs);
        }

        // GET: Admin/LoaiSPModelcs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/LoaiSPModelcs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdLSP,TenLSP,Trangthai")] LoaiSPModelcs loaiSPModelcs)
        {
            if (ModelState.IsValid)
            {
                _context.Add(loaiSPModelcs);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(loaiSPModelcs);
        }

        // GET: Admin/LoaiSPModelcs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loaiSPModelcs = await _context.loaisanpham.FindAsync(id);
            if (loaiSPModelcs == null)
            {
                return NotFound();
            }
            return View(loaiSPModelcs);
        }

        // POST: Admin/LoaiSPModelcs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdLSP,TenLSP,Trangthai")] LoaiSPModelcs loaiSPModelcs)
        {
            if (id != loaiSPModelcs.IdLSP)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(loaiSPModelcs);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LoaiSPModelcsExists(loaiSPModelcs.IdLSP))
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
            return View(loaiSPModelcs);
        }

        // GET: Admin/LoaiSPModelcs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loaiSPModelcs = await _context.loaisanpham
                .FirstOrDefaultAsync(m => m.IdLSP == id);
            if (loaiSPModelcs == null)
            {
                return NotFound();
            }

            return View(loaiSPModelcs);
        }

        // POST: Admin/LoaiSPModelcs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var loaiSPModelcs = await _context.loaisanpham.FindAsync(id);
            _context.loaisanpham.Remove(loaiSPModelcs);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LoaiSPModelcsExists(int id)
        {
            return _context.loaisanpham.Any(e => e.IdLSP == id);
        }
    }
}
