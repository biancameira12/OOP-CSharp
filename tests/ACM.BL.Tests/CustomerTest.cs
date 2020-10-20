using System;
using Xunit;
using ACM.BL;

namespace tests
{
    public class CustomerTest
    {
        [Fact]
        public void FullNameTestValid()
        {
            Customer customer = new Customer("Bilbo");
            customer.FirstName = "Bilbo";
            customer.LastName = "Baggins";

            string expected = "Baggins, Bilbo";
            string actual = customer.FullName;

            Assert.Equal(expected, actual);

        }
        [Fact]
        public void FirstNameTestValid()
        {
            Customer customer = new Customer("Bilbo");
            customer.FirstName = "Bilbo";

            string expected = "Bilbo";
            string actual = customer.FullName;

            Assert.Equal(expected, actual);

        }
        [Fact]
        public void LastNameTestValid()
        {
            Customer customer = new Customer("");
            customer.LastName = "Bilbo";

            string expected = "Bilbo";
            string actual = customer.FullName;

            Assert.Equal(expected, actual);

        }
    }
}
