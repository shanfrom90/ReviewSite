using ReviewsSite.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ReviewsSite.Tests
{
    public class ReviewTests
    {
        Review sut;
        public ReviewTests()
        {
            sut = new Review("It was a non-stop thrill-ride!!!", 5);
        }
        [Fact]
        public void ReviewConstructor_Sets_Rating_On_ReviewModel()
        {
            int result = sut.Rating;
            Assert.Equal(5, result);
        }
        [Fact]
        public void ReviewConstructor_Sets_Content_On_ReviewModel()
        {
            string result = sut.Content;
            Assert.Equal("It was a non-stop thrill-ride!!!", result);
        }
    }
}
