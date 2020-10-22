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
        [Fact]
        public void StaticCountTestValid()
        {
            var c1 = new Customer("Bilbo");
            Customer.InstanceCount += 1;

            var c2 = new Customer("Frodo");
            Customer.InstanceCount += 1;

            var c3 = new Customer("Rosie");
            Customer.InstanceCount += 1;

            Assert.Equal(3, Customer.InstanceCount);

        }
        [Fact]
        public void ValidateValid()
        {
            var customer = new Customer();
            customer.FirstName = "Bilbo";
            customer.LastName = "Bilbo";
            customer.EmailAddress = "bilbo@gmail.com";

            var expected = true;
            var actual = customer.Validate();

            Assert.Equal(expected, actual);

        }
    }
}
