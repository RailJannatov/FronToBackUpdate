using FrontToBack.DataAccessLayer;
using FrontToBack.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToBack.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _dbcontext;
        public HomeController(AppDbContext dbContext)
        {
            _dbcontext = dbContext;
        }
        public IActionResult Index()
        {
            var sliderImages = _dbcontext.SliderImages.ToList();
            var slider = _dbcontext.Slider.SingleOrDefault();
            var about = _dbcontext.About.SingleOrDefault();
            var aboutList = _dbcontext.AboutLists.ToList();
            var aboutImage = _dbcontext.AboutImage.SingleOrDefault();
            var subscribe = _dbcontext.Subscribe.FirstOrDefault();
            var subscribeImage = _dbcontext.SubscribeImage.FirstOrDefault();
            var category = _dbcontext.Categories.ToList();
            var product = _dbcontext.Products.ToList();
            var expertTitle = _dbcontext.ExpertTitle.SingleOrDefault();
            var expertItems = _dbcontext.ExpertItems.ToList();


            return View(new HomeViewModel
            {
                SliderImages = sliderImages,
                Slider = slider,
                About = about,
                AboutImage = aboutImage,
                AboutLists = aboutList,
                Subscribe = subscribe,
                SubscribeImage = subscribeImage,
                Categories = category,
                Products = product,
                ExpertTitle = expertTitle,
                ExpertItems = expertItems
            }
            );
            ;
        }
    }
}
