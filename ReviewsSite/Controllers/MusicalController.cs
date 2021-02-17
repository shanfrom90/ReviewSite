using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ReviewsSite
{
    public class MusicalController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
    }
}
