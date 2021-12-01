using FrontToBack.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToBack.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _dbContext;
        private readonly int _productCount;
        public ProductController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
            _productCount = dbContext.Products.Count();

        }
        public IActionResult Index()
        {
            ViewBag.ProductCount = _productCount;
            var products = _dbContext.Products.ToList();

            return View(products);
          
        }
        public IActionResult Load(int skip)
        {
       
            if (skip >= _productCount)
            {
                return Content("Error");
            }

            var products = _dbContext.Products.Skip(skip).Take(4).ToList();

            return PartialView("_ProductPartial", products);
        }
    }
}
