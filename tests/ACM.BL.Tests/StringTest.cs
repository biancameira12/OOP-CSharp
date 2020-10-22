using System;
using Xunit;
using acme.common;

namespace tests
{
    public class StringTest
    {
        [Fact]
        public void InsertSpacesTestValid()
        {
            var source = "SonicScrewdriver";
            var expected = "Sonic Screwdriver";

            var actual = source.InsertSpaces();

            Assert.Equal(expected, actual);
        }
    }
}