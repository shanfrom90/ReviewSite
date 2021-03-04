using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ReviewsSite.Models;
using ReviewsSite.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Controllers
{
    public class ReviewController : Controller
    {
        IRepository<Review> reviewRepo;

        private void ListOfMusicals()
        {
            var musicalList = reviewRepo.PopulateMusicalList();

            ViewBag.Musicals = new SelectList(musicalList, "Id", "Title");
        }

        public ReviewController(IRepository<Review> reviewRepo)
        {
            this.reviewRepo = reviewRepo;
        }

        public ViewResult Index()
        {
            var reviewList = reviewRepo.GetAll();
            return View(reviewList);
        }

        public ViewResult Create()
        {
            //var musicalList = reviewRepo.PopulateMusicalList();

            //ViewBag.Musicals = new SelectList(musicalList, "Id", "Title");

            ListOfMusicals();

            return View(new Review(){ Rating = 1 });
        }

        [HttpPost]
        public ViewResult Create(Review model)
        {
            //var musicalList = reviewRepo.PopulateMusicalList();

            //ViewBag.Musicals = new SelectList(musicalList, "Id", "Title");

            ListOfMusicals();

            reviewRepo.Create(model);

            ViewBag.Result = "Your review has been added.";

            return View(model);
        }
        public ActionResult Delete(int id)
        {
            var review = reviewRepo.GetByID(id);
            reviewRepo.Delete(review);
            return RedirectToAction("Index");
        }
        public ViewResult Update(int id)
        {
            var review = reviewRepo.GetByID(id);
            var musicalList = reviewRepo.PopulateMusicalList();

            ViewBag.Musicals = new SelectList(musicalList, "Id", "Title");
            return View(review);
        }
        [HttpPost]
        public ViewResult Update(Review model)
        {
            var musicalList = reviewRepo.PopulateMusicalList();
            ViewBag.Musicals = new SelectList(musicalList, "Id", "Title");
            reviewRepo.Update(model);
            return View(model);
        }
    }
}

