using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using NSubstitute;
using ReviewsSite.Models;
using ReviewsSite.Controllers;
using ReviewsSite.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ReviewsSite.Tests
{
    public class ReviewControllerTests
    {
        ReviewController sut;
        IRepository<Review> reviewRepo;
       public ReviewControllerTests()
        {
            reviewRepo = Substitute.For<IRepository<Review>>();
            sut = new ReviewController(reviewRepo);
        }

        [Fact]
        public void Index_Returns_A_View()
        {
            var result = sut.Index();
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Index_Returns_ReviewModel_To_View()
        {
            List<Review> expectedReviews = null;
            reviewRepo.GetAll().Returns(expectedReviews);

            var result = sut.Index();

            Assert.Equal(expectedReviews, result.Model);
        }

        [Fact]
        public void Update_Returns_A_View()
        {
            var reviewToUpdate = new Review();
            reviewRepo.GetByID(1).Returns(reviewToUpdate);
            var result = sut.Update(1);

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Update_Passes_Review_To_View()
        {
            var reviewToUpdate = new Review();
            reviewRepo.GetByID(1).Returns(reviewToUpdate);
            reviewToUpdate.Content = "Update to content";

            var result = (ViewResult)sut.Update(reviewToUpdate);

            Assert.Equal("You have successfully updated this review.", result.ViewData["result"]);
        }
 

    }
}
