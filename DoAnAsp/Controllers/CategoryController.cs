using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DoAnAsp.Models;
using System.Diagnostics;
using DoAnAsp.Areas.Admin.Data;
using Microsoft.EntityFrameworkCore;

namespace DoAnAsp.Controllers
{
    public class CategoryController : Controller
    {
        private readonly DPContext _context;

        public CategoryController(DPContext context)
        {
            _context = context;
        }


        

        public async Task<IActionResult> Index(int? id)
        {
            if(id!=null)
            {
                var ds = await _context.sanpham.ToListAsync();
                var dss = ds.Where(x => x.IdLSP == id);
                return View(dss);
            }
            else
            {
                return View(await _context.sanpham.ToListAsync());
            }
            

            
        }
    }
}
