using Slider_Mvc.Dal;
using Slider_Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Slider_Mvc.Controllers
{
    public class SliderController : Controller
    {
        private readonly SliderContext context;
        public SliderController()
        {
            context = new SliderContext();
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SaveSlider(Slider s)
        {
            s.Files = Request.Files;
            HttpPostedFileBase file = s.Files[0];
            string fp = "~/Images/Sliders/" + file.FileName;
            s.FilePath = fp;
            if (ModelState.IsValid)
            {
                return View("Index", s);
            }
            else
            {
                context.Sliders.Add(s);
                context.SaveChanges();
                file.SaveAs(Server.MapPath(fp));
                List<Slider> sliders = context.Sliders.ToList();
                return View("DisplaySliders", sliders);
            }
        }
        public ActionResult DisplaySliders()
        {
            List<Slider> sliders =context.Sliders.ToList();
            return View(sliders);
        }
    }
}