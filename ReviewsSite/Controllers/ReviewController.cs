using Microsoft.AspNetCore.Mvc;
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
    }
}

