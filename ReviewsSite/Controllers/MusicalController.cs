using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReviewsSite.Models;

namespace ReviewsSite
{
    public class MusicalController : Controller
    {
        Musical musical = new Musical(1, "Wicked", "drama", "A tale of two friends who happen to be witches. Hijinks ensue.", 5, "It was a non-stop thrill-ride!!!");
        public ViewResult Index()
        {
            return View(musical);
        }
    }
}
