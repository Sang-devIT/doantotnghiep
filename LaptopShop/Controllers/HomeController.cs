using LaptopShop.Areas.Admin.Data;
using LaptopShop.Areas.Admin.Models;
using LaptopShop.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LaptopShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly LaptopshopContext _context;

        public HomeController(ILogger<HomeController> logger,LaptopshopContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            if (HttpContext.Session.Keys.Contains("Username"))
            {
                ViewBag.Username = HttpContext.Session.GetString("Username");
            }
            return View();
        }
        public IActionResult Product()
        {
            if (HttpContext.Session.Keys.Contains("Username"))
            {
                ViewBag.Username = HttpContext.Session.GetString("Username");
            }
            var product = _context.Products.Include(c=>c.Carts).ToList();
            return View(product);
        }
        public IActionResult Product_details(int id)
        {
            if (HttpContext.Session.Keys.Contains("Username"))
            {
                ViewBag.Username = HttpContext.Session.GetString("Username");
            }
           
            var product = _context.Products.Include(a=>a.ProductType).Where(prd => prd.Id == id);
            return View(product);
        
        }
       
        public IActionResult Cart()
        {
            if (HttpContext.Session.Keys.Contains("Username"))
            {
                ViewBag.Username = HttpContext.Session.GetString("Username");
            }
            else
            {
                return RedirectToAction("Login");
            }
            ViewBag.Username = HttpContext.Session.GetString("Username");
            string username = HttpContext.Session.GetString("Username");
            var listCart = _context.Carts.Include(c => c.User).Include(c => c.Products).Where(c => c.User.Username == username);
            return View(listCart.ToList());
        }
        public IActionResult Introduce()
        {
            if (HttpContext.Session.Keys.Contains("Username"))
            {
                ViewBag.Username = HttpContext.Session.GetString("Username");
            }
            return View();
        }
        public IActionResult Contact()
        {
            if (HttpContext.Session.Keys.Contains("Username"))
            {
                ViewBag.Username = HttpContext.Session.GetString("Username");
            }
            return View();
        }
        public IActionResult Policy()
        {
            if (HttpContext.Session.Keys.Contains("Username"))
            {
                ViewBag.Username = HttpContext.Session.GetString("Username");
            }
            return View();
        }
        public IActionResult News()
        {
            if (HttpContext.Session.Keys.Contains("Username"))
            {
                ViewBag.Username = HttpContext.Session.GetString("Username");
            }
            return View();
        }
        public IActionResult Promotion()
        {
            if (HttpContext.Session.Keys.Contains("Username"))
            {
                ViewBag.Username = HttpContext.Session.GetString("Username");
            }
            return View();
        }
        public IActionResult Privacy()
        {
            if (HttpContext.Session.Keys.Contains("Username"))
            {
                ViewBag.Username = HttpContext.Session.GetString("Username");
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
       
        public IActionResult Login(string username, string password)
        {
            if (ModelState.IsValid)
            {
                var f_password = GetMD5(password);
                User user = _context.Users.FirstOrDefault(a => a.Username.Equals(username) && a.Password.Equals(f_password));
                if (user != null)
                {
                    CookieOptions cookieOption = new CookieOptions()
                    {
                        Expires = DateTime.Now.AddDays(7)
                    };
                    HttpContext.Session.SetInt32("User_ID", user.Id);
                    HttpContext.Session.SetString("Username", user.Username);
                    return RedirectToAction("Index");
                }

                else
                {
                    ViewBag.error = "Login failed";
                    return RedirectToAction("Login");
                }
            }
            return View();
        }
        public static string GetMD5(string str)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] fromData = Encoding.UTF8.GetBytes(str);
            byte[] targetData = md5.ComputeHash(fromData);
            string byte2String = null;

            for (int i = 0; i < targetData.Length; i++)
            {
                byte2String += targetData[i].ToString("x2");

            }
            return byte2String;
        }
        public IActionResult Register()
        {
            return View();
        }

        //POST: Register
        [HttpPost]
        public IActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                var check = _context.Users.FirstOrDefault(s => s.Username == user.Username);
                if (check == null)
                {
                    user.Password = GetMD5(user.Password);
                    user.Status = true;
                    _context.Users.Add(user);
                    _context.SaveChanges();
                    return RedirectToAction("Login");
                }
                else
                {
                    ViewBag.error = "Username already exists";
                    return View();
                }
            }
            return View();
        }
        public ActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }

        public IActionResult AddToCart(int id)
        {
            return AddToCart(id,1);
        }

        [HttpPost]
        public IActionResult AddToCart(int productId, int quantity)
        {
            if (HttpContext.Session.Keys.Contains("Username"))
            {
                ViewBag.Username = HttpContext.Session.GetString("Username");
            }
            else
            {
                return RedirectToAction("Login");
            }
            string username = HttpContext.Session.GetString("Username");
            int userID = _context.Users.FirstOrDefault(a => a.Username == username).Id;
            Cart cart = _context.Carts.FirstOrDefault(c => c.UserID == userID && c.ProductId == productId);
            if (cart == null)
            {
                cart = new Cart();
                cart.UserID = userID;
                cart.ProductId = productId;
                cart.Quantity = quantity;

                _context.Carts.Add(cart);
            }
            else
            {
                cart.Quantity += quantity;

            }
            _context.SaveChanges();
            return RedirectToAction("Cart", "Home");
        }
        public async Task<IActionResult> DeleteSp(int id)
        {
            var cart = await _context.Carts.FindAsync(id);
            _context.Carts.Remove(cart);
            await _context.SaveChangesAsync();
            return RedirectToAction("Cart", "Home");
        }
    }
}
