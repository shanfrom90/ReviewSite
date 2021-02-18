using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using ReviewsSite.Models;

namespace ReviewsSite.Tests
{
    public class MusicalTests
    {
        Musical sut;
       public MusicalTests()
        { 
           sut = new Musical(22,"Wicked", "drama");
        }

        [Fact]
        public void MusicalConstructor_Sets_ID_On_MusicalModel()
        {
            int result = sut.Id;

            Assert.Equal(22, result);
        }

        [Fact]
        public void MusicalConstructor_Sets_Title_On_MusicalModel()
        {
            string result = sut.Title;
            Assert.Equal("Wicked", result);
        }

        [Fact]
        public void MusicalConstructer_Sets_Genre_On_MusicalModel()
        {
            string result = sut.Genre;
            Assert.Equal("drama", result);
        }

    }
}
