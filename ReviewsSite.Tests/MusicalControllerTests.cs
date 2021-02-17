using System;
using Xunit;
using Microsoft.AspNetCore.Mvc;

namespace ReviewsSite.Tests
{
    public class MusicalControllerTests
    {
        [Fact]
        public void Index_Returns_A_View()
        {
            var underTest = new MusicalController();

            var result = underTest.Index();

            Assert.IsType<ViewResult>(result);
        }
    }
}
