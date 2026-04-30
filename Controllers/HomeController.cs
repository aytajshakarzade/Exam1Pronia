using Exam1Pronia.DAL.Contexts;
using Exam1Pronia.Models;
using Exam1Pronia.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Exam1Pronia.Controllers
{

    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var homeVM = new HomeVM
            {
                Products = _context.Products.ToList(),
                Sliders = _context.Sliders.ToList()
            };

            return View(homeVM);
        }
        public IActionResult Details(int id)
        {
            Product singleProduct = _context.Products
                  .Include(p => p.Reviews)
                  .Include(p => p.Images)
                  .Include(p => p.Categories)
                  .Include(p => p.Tags)
                  .FirstOrDefault(p => p.Id == id);
            return View(singleProduct);
        }
    }
}