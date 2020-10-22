using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class AddressRepository
    {
        public Address Retrieve(int addressId)
        {
            var address = new Address(addressId);
            if (addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "Bag End";
                address.StreetLine2 = "Bagshot row";
                address.City = "Hobbiton";
                address.State = "Shire";
                address.Country = "Brazil";
                address.PostalCode = "144";
            }
            return address;
        }
        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "Bag End",
                StreetLine2 = "Bagshot row",
                City = "Hobbiton",
                State = "Shire",
                Country = "Brazil",
                PostalCode = "144",
            };
            addressList.Add(address);

            address = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "B End",
                StreetLine2 = "B row",
                City = "Hobbit",
                State = "Shir",
                Country = "Br",
                PostalCode = "1244",
            };
            addressList.Add(address);

            return addressList;
        }
        public bool Save(Address address)
        {
            return true;
        }
    }
}