using DA_Xuong.Database;
using Microsoft.AspNetCore.Mvc;

namespace DA_Xuong.Controllers
{
    public class ChiTietSachController : Controller
    {
        private readonly ApplicationDBContext _db;
        public ChiTietSachController(ApplicationDBContext db)
        {
            _db = db;
        }
     
        public IActionResult Index(int id)

        {
            var project = _db.SACH.FirstOrDefault(p => p.IDSACH == id);

            return View(project);
        }
    }
}
