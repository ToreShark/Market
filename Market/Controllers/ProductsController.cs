using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Market.Models;

namespace Market.Controllers
{
    public class ProductsController : Controller
    {
        private readonly MarketContext _context;

        public ProductsController(MarketContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Product> products = _context.Product.ToList();
                
            return View(products);
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.brands = _context.Brand.ToList();
            ViewBag.categories = _context.Category.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Add(product);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(product);
        }
    }
}