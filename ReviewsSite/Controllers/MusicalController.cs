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
        Musical musical = new Musical();
        public ViewResult Index()
        {
            return View(musical);
        }
    }
}
