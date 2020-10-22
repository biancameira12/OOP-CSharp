using System;

namespace ACM.BL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var customer = new CustomerRepository();
            customer.Retrieve(1);
        }
    }
}
