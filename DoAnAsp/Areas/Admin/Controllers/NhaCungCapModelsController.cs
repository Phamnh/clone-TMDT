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

namespace DoAnAsp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class NhaCungCapModelsController : Controller
    {
        private readonly DPContext _context;

        public NhaCungCapModelsController(DPContext context)
        {
            _context = context;
        }

        // GET: Admin/NhaCungCapModels
        public async Task<IActionResult> Index()
        {
            try
            {
                var list = _context.admin.Where(s => s.Username == HttpContext.Session.GetString("username").ToString());
                if (list.Count() != 0)
                {
                    ViewBag.Username = HttpContext.Session.GetString("username").ToString();
                    return View(await _context.nhacungcap.ToListAsync());
                }
                else
                {
                    var url = Url.RouteUrl(new { controller = "Home", action = "Index", area = "" });
                    return Redirect(url);
                }
            }
            catch (Exception e)
            {
                var url = Url.RouteUrl(new { controller = "Login", action = "Index", area = "" });
                return Redirect(url);
            }
        }

        // GET: Admin/NhaCungCapModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nhaCungCapModel = await _context.nhacungcap
                .FirstOrDefaultAsync(m => m.IdNCC == id);
            if (nhaCungCapModel == null)
            {
                return NotFound();
            }

            return View(nhaCungCapModel);
        }

        // GET: Admin/NhaCungCapModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/NhaCungCapModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdNCC,TenNCC,SdtNCC,TrangThai")] NhaCungCapModel nhaCungCapModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nhaCungCapModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nhaCungCapModel);
        }

        // GET: Admin/NhaCungCapModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nhaCungCapModel = await _context.nhacungcap.FindAsync(id);
            if (nhaCungCapModel == null)
            {
                return NotFound();
            }
            return View(nhaCungCapModel);
        }

        // POST: Admin/NhaCungCapModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdNCC,TenNCC,SdtNCC,TrangThai")] NhaCungCapModel nhaCungCapModel)
        {
            if (id != nhaCungCapModel.IdNCC)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nhaCungCapModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NhaCungCapModelExists(nhaCungCapModel.IdNCC))
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
            return View(nhaCungCapModel);
        }

        // GET: Admin/NhaCungCapModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nhaCungCapModel = await _context.nhacungcap
                .FirstOrDefaultAsync(m => m.IdNCC == id);
            if (nhaCungCapModel == null)
            {
                return NotFound();
            }

            return View(nhaCungCapModel);
        }

        // POST: Admin/NhaCungCapModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var nhaCungCapModel = await _context.nhacungcap.FindAsync(id);
            _context.nhacungcap.Remove(nhaCungCapModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NhaCungCapModelExists(int id)
        {
            return _context.nhacungcap.Any(e => e.IdNCC == id);
        }
    }
}
