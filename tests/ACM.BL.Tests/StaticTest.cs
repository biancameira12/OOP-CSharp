using System;
using Xunit;
using ACM.BL;

namespace tests
{
    public class StaticTest
    {
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
    }
}
