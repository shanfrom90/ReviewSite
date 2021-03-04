using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReviewsSite.Models;
using ReviewsSite.Repository;

namespace ReviewsSite
{
    public class MusicalController : Controller
    {
        IRepository<Musical> musicalRepo;

        public MusicalController(IRepository<Musical> musicalRepo)
        {
            this.musicalRepo = musicalRepo;
        }

        public ViewResult Index()
        {
            var musicalList = musicalRepo.GetAll();
            return View(musicalList);
        }

        public ViewResult Details(int id)
        {
            var musical = musicalRepo.GetByID(id);

            return View(musical);
        }

        public ViewResult Create()
        {
            List<string> listOfGenres = new List<string> {"Family", "Drama", "Comedy", "Historical" };

            ViewBag.Genres = listOfGenres;

            return View(new Musical());
        }

        [HttpPost]
        public ViewResult Create(Musical model)
        {
            List<string> listOfGenres = new List<string> { "Family", "Drama", "Comedy", "Historical" };

            ViewBag.Genres = listOfGenres;

            if (musicalRepo.FindMusicalByTitle(model.Title) != null)
            {
  
                ViewBag.Error = "This musical already exists.";

                return View(new Musical());
            }

            musicalRepo.Create(model);

            ViewBag.Result = "Your musical has been added.";

            return View(model);
        }

        public ActionResult Delete(int id)
        {
            var musical = musicalRepo.GetByID(id);
            musicalRepo.Delete(musical);
            return RedirectToAction("Index");
        }

    }
}
