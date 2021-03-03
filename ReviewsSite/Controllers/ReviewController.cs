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
            var musicalList = reviewRepo.PopulateMusicalList();

            ViewBag.Musicals = new SelectList(musicalList, "Id", "Title");

            return View(new Review(){ Rating = 1 });
        }

        [HttpPost]
        public ViewResult Create(Review model)
        {
            var musicalList = reviewRepo.PopulateMusicalList();

            ViewBag.Musicals = new SelectList(musicalList, "Id", "Title");

            reviewRepo.Create(model);

            ViewBag.Result = "Your review has been added.";

            return View(model);
        }
    }
}

