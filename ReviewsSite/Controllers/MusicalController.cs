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

    }
}
