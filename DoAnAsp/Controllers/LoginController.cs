using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DoAnAsp.Models;
using System.Diagnostics;
using DoAnAsp.Areas.Admin.Data;

namespace DoAnAsp.Controllers
{
    public class LoginController: Controller
    {
        private readonly DPContext _context;

        public LoginController(DPContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult login(string UsernameUser, string PasswordUser)
        {
            var user = _context.user.Where(s => s.UsernameUser == UsernameUser).ToList();
            var admin = _context.admin.Where(s => s.Username == UsernameUser).ToList();
            if (user.Count!=0)
            {
                if(user[0].PasswordUser==PasswordUser)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return RedirectToAction(nameof(Index));
                }
            }
            else
            {
                if(admin.Count !=0)
                {
                    if(admin[0].Password==PasswordUser)
                    {
                        var url = Url.RouteUrl("areas", new { controller = "SanPhamModels", action = "Index", area = "Admin" });
                        return Redirect(url);
                    }
                    else
                    {
                        return RedirectToAction(nameof(Index));
                    }
                }
                else
                {
                    return RedirectToAction(nameof(Index));
                }
            }
        }
    }
}
