﻿using System;
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
    public class UserModelsController : Controller
    {
        private readonly DPContext _context;

        public UserModelsController(DPContext context)
        {
            _context = context;
        }

        // GET: Admin/UserModels
        public async Task<IActionResult> Index()
        {
            try
            {
                var list = _context.admin.Where(s => s.Username == HttpContext.Session.GetString("username").ToString());
                if (list.Count() != 0)
                {
                    ViewBag.Username = HttpContext.Session.GetString("username").ToString();
                    return View(await _context.user.ToListAsync());
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

        // GET: Admin/UserModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userModel = await _context.user
                .FirstOrDefaultAsync(m => m.IdUser == id);
            if (userModel == null)
            {
                return NotFound();
            }

            return View(userModel);
        }

        // GET: Admin/UserModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/UserModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdUser,HotenUser,EmailUser,SdtUser,DiachiUser,UsernameUser,PasswordUser,TrangthaiUser")] UserModel userModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(userModel);
        }

        // GET: Admin/UserModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userModel = await _context.user.FindAsync(id);
            if (userModel == null)
            {
                return NotFound();
            }
            return View(userModel);
        }

        // POST: Admin/UserModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdUser,HotenUser,EmailUser,SdtUser,DiachiUser,UsernameUser,PasswordUser,TrangthaiUser")] UserModel userModel)
        {
            if (id != userModel.IdUser)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserModelExists(userModel.IdUser))
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
            return View(userModel);
        }

        // GET: Admin/UserModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userModel = await _context.user
                .FirstOrDefaultAsync(m => m.IdUser == id);
            if (userModel == null)
            {
                return NotFound();
            }

            return View(userModel);
        }

        // POST: Admin/UserModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var userModel = await _context.user.FindAsync(id);
            _context.user.Remove(userModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserModelExists(int id)
        {
            return _context.user.Any(e => e.IdUser == id);
        }
    }
}
