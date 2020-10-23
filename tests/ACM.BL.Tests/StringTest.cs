using System;
using Xunit;
using acme.common;
using System.Collections.Generic;
using ACM.BL;

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
        [Fact]
        public void WriteToFileTest()
        {
            var changedItems = new List<ILoggable>();
            var customer = new Customer(1)
            {
                EmailAddress = "fbaggings@gmail.com",
                FirstName = "Bilbo",
                LastName = "Frodo",
                AddressList = null
            };
            changedItems.Add(customer);
            var product = new Product(2)
            {
                ProductName = "Rake",
                ProductDescription = "Garden",
                CurrentPrice = 6M
            };
            changedItems.Add(product);

            LoggingService.WriteToFile(changedItems);

        }
    }
}