using FrontToBack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToBack.ViewModels
{
    public class HomeViewModel
    {
        public Slider Slider { get; set; }
        public List<SliderImage> SliderImages { get; set; }
        public About About { get; set; }
        public AboutImage AboutImage { get; set; }
        public List<AboutList> AboutLists { get; set; }
        public Subscribe Subscribe { get; set; }
        public SubscribeImage SubscribeImage { get; set; }
    }
}
