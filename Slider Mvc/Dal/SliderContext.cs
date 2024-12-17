using Slider_Mvc.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Slider_Mvc.Dal
{
    public class SliderContext : DbContext
    {
        public SliderContext()
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Slider>().ToTable("Sliders");
            //base.OnModelCreating(modelBuilder);
        }
        public DbSet<Slider> Sliders { get; set; }
    }
}