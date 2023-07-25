using Microsoft.AspNetCore.Mvc;
using TaskGNIS.Data;

namespace TaskGNIS.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var products = _context.Products.ToList();
            ViewBag.Products = products;
            return View();
        }

        public IActionResult GetProducts()
        {
            var products = _context.Products.Select(p => new
            {
                Id = p.Id,
                ProductName = p.ProductName,
                Unit = p.Unit
            }).ToList();

            return Json(products);
        }
    }
}
