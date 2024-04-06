using DA_Xuong.Database;
using DA_Xuong.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace DA_Xuong.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDBContext _db;

        public HomeController(ILogger<HomeController> logger, ApplicationDBContext db)
        {
            _logger = logger;
            _db = db;
        }
        
        public IActionResult Index()
        {
            List<SACH> projects = _db.SACH.ToList();
          
            return View(projects);
           
        }
        [HttpPost]
        public IActionResult AddToCart(GIOHANG  add)
        {
            GIOHANG newItem = new GIOHANG
            {
                IDSACH = 2,
                SOLUONG = 1,
                IDNGUOIDUNG = 2,
             
            };

            _db.GIOHANG.Add(newItem);
            _db.SaveChanges();
            return RedirectToAction("Index", "Home");

        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult SanPham()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
