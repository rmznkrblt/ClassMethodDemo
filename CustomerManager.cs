using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void customeAdd(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " added.");
        }

        public void customeDelete(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " deleted");
        }

        public void printCustomer(Customer[] customer)
        {
            foreach (Customer c in customer)
            {
                Console.WriteLine((c.Id+1) + ". Customer : " + c.FirstName +" " + c.LastName);
            }
        }

    }
}
