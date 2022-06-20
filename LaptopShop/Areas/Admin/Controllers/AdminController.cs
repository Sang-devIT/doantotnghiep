using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaptopShop.Areas.Admin.Data;

namespace LaptopShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminController : Controller
    {
        private readonly ILogger<AdminController> _logger;
        private readonly LaptopshopContext _context;

        public AdminController(ILogger<AdminController> logger, LaptopshopContext context)
        {
            _logger = logger;
            _context = context;
        }
      
            public IActionResult Index()
            {
                return View();
            }
        

    }
}
