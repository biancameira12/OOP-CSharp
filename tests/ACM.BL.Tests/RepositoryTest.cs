using System;
using Xunit;
using ACM.BL;
using System.Collections.Generic;

namespace tests
{
    public class RepositoryTest
    {
        [Fact]
        public void RetrieveCustomerValid()
        {
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "fbaggins@gmail.com",
                FirstName = "Frodo",
                LastName = "Baggins"
            };
            var actual = customerRepository.Retrieve(1);

            Assert.Equal(expected.FirstName, actual.FirstName);
            Assert.Equal(expected.LastName, actual.LastName);
            Assert.Equal(expected.CustomerId, actual.CustomerId);
        }
        [Fact]
        public void RetrieveExistingWithAddress()
        {
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "fbaggins@gmail.com",
                FirstName = "Frodo",
                LastName = "Baggins",
                AddressList = new List<Address>()
                {
                    new Address()
                    {
                    AddressType = 1,
                    StreetLine1 = "Bag End",
                    StreetLine2 = "Bagshot row",
                    City = "Hobbiton",
                    State = "Shire",
                    Country = "Brazil",
                    PostalCode = "144",
                    },
                    new Address()
                    {
                        AddressType = 2,
                        StreetLine1 = "B End",
                        StreetLine2 = "B row",
                        City = "Hobbit",
                        State = "Shir",
                        Country = "Br",
                        PostalCode = "1244",
                    }
                }
            };
            var actual = customerRepository.Retrieve(1);

            Assert.Equal(expected.FirstName, actual.FirstName);
            Assert.Equal(expected.LastName, actual.LastName);
            Assert.Equal(expected.CustomerId, actual.CustomerId);
            for (int i = 0; i < 1; i++)
            {
                Assert.Equal(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
                Assert.Equal(expected.AddressList[i].StreetLine1, actual.AddressList[i].StreetLine1);
                Assert.Equal(expected.AddressList[i].StreetLine2, actual.AddressList[i].StreetLine2);
                Assert.Equal(expected.AddressList[i].City, actual.AddressList[i].City);
                Assert.Equal(expected.AddressList[i].Country, actual.AddressList[i].Country);
                Assert.Equal(expected.AddressList[i].State, actual.AddressList[i].State);
            }
        }
        [Fact]
        public void RetrieveOrderValid()
        {
            var orderRepository = new OrderRepository();
            var expected = new Order(10)
            {
                OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0)),
            };
            var actual = orderRepository.Retrieve(10);

            Assert.Equal(expected.OrderDate, actual.OrderDate);
        }
        [Fact]
        public void SaveTestValid()
        {
            var productRepository = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                CurrentPrice = 18M,
                ProductDescription = "Assorted Size Set of 4 Bright Yellow Mini Sunflowers",
                ProductName = "Sunflowers",
                HasChanges = true
            };

            var actual = productRepository.Save(updatedProduct);

            Assert.True(actual);
        }
        [Fact]
        public void SaveTestMissingPrice()
        {
            var productRepository = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                CurrentPrice = null,
                ProductDescription = "Assorted Size Set of 4 Bright Yellow Mini Sunflowers",
                ProductName = "Sunflowers",
                HasChanges = true
            };

            var actual = productRepository.Save(updatedProduct);

            Assert.True(!actual);
        }

    }
}
