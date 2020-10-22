using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Customer
    {
        public Customer() : this(0)
        {
        }
        public Customer(string name)
        {
            FirstName = name;
            AddressList = new List<Address>();
        }
        public Customer(int customerId)
        {
            CustomerId = customerId;
            AddressList = new List<Address>();
        }
        public int CustomerId { get; private set; }
        public int CustomerType { get; set; }
        public List<Address> AddressList { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string FullName
        {
            get
            {
                var fullName = LastName;
                if (!string.IsNullOrEmpty(FirstName))
                {
                    if (!string.IsNullOrEmpty(LastName))
                    {
                        fullName += ", ";
                    }
                }
                return fullName + FirstName;
            }
        }
        private string _lastName;
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }
        public static int InstanceCount { get; set; }
        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(FirstName)) isValid = false;
            return isValid;
        }

    }
}
