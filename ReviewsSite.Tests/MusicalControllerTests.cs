using System;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using ReviewsSite.Models;
using NSubstitute;
using ReviewsSite.Repository;
using System.Collections.Generic;

namespace ReviewsSite.Tests
{
    public class MusicalControllerTests
    {
    MusicalController sut;
    IRepository<Musical> musicalRepo;
        public MusicalControllerTests()
         {
            musicalRepo = Substitute.For<IRepository<Musical>>();
            sut = new MusicalController(musicalRepo);
        }

        [Fact]
        public void Index_Returns_A_View()
        {

            var result = sut.Index();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Index_Returns_Model_To_View()
        {
            List<Musical> expectedMusicals = null;
            musicalRepo.GetAll().Returns(expectedMusicals);
            var result = sut.Index();
            Assert.Equal(expectedMusicals, result.Model);
        }

        [Fact]
        public void Details_Returns_A_View()
        {
            var result = sut.Details(1);
            Assert.IsType<ViewResult>(result);


        }

        [Fact]
        public void Details_Passes_Musical_To_View()
        {
            var expectedMusical = new Musical();
            musicalRepo.GetByID(1).Returns(expectedMusical);

            var result = sut.Details(1);
            Assert.Equal(expectedMusical, result.Model);
        }

        [Fact]
        public void Create_Returns_A_View()
        {
            var result = sut.Create();
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Create_Adds_A_Model()
        {
            Musical model = new Musical() { Title = "Grease", Description = "Coming of age love tale", Genre = "Comedy", Id = 1 };
            var result = sut.Create(model);

            Assert.Equal("Your musical has been added.", result.ViewData["result"]);
        }

        [Fact]

        public void Delete_Musical_Successfully()
        {
            Musical model = new Musical() { Id = 1 };
            musicalRepo.GetByID(model.Id).Returns(model);
            var result = sut.Delete(model.Id);
            Assert.IsType<RedirectToActionResult>(result);
        }
       

    }
}
