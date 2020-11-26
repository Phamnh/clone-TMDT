using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DoAnAsp.Models;
using System.Diagnostics;

namespace DoAnAsp.Controllers
{
    public class LoginController: Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
