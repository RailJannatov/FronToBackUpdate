using FrontToBack.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToBack.DataAccessLayer
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
                
        }

        public DbSet<Slider> Slider { get; set; }

        public DbSet<SliderImage> SliderImages { get; set; }
        public DbSet<About> About { get; set; }
        public DbSet<AboutList> AboutLists { get; set; }
        public DbSet<AboutImage> AboutImage { get; set; }

        public DbSet<Subscribe> Subscribe { get; set; }
        public DbSet<SubscribeImage> SubscribeImage { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }
        public DbSet<ExpertTitle> ExpertTitle { get; set; }
        public DbSet<ExpertItem> ExpertItems { get; set; }

    }
}
