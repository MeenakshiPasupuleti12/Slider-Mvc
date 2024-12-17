using Slider_Mvc.Dal;
using Slider_Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Slider_Mvc.BLL
{
    public class Services
    {
        public List<Slider> GetSliders()
        {
            SliderContext dal = new SliderContext();
            List<Slider> sliders = dal.Sliders.ToList();
            return sliders;
        }

    }
}