using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            Customer c2 = new Customer();
            Customer c3 = new Customer();
            Customer c4 = new Customer();
            CustomerManager manage = new CustomerManager();

            c1.Id = 0;
            c2.Id = 1;
            c3.Id = 2;
            c4.Id = 3;
            c1.FirstName = "Ramazan";
            c1.LastName = "Karabulut";
            c2.FirstName = "Damla";
            c2.LastName = "Sökmen";
            c3.FirstName = "Alper";
            c3.LastName = "Talas";
            c4.FirstName = "Ayşe";
            c4.LastName = "Yiğit";


            Customer[] cArray = new Customer[] { c1, c2, c3, c4 };

            manage.customeAdd(c1);
            manage.customeAdd(c2);
            manage.customeAdd(c3);
            manage.customeAdd(c4);


            manage.customeDelete(c1);
            manage.customeDelete(c2);
            manage.customeDelete(c3);
            manage.customeDelete(c4);

            manage.printCustomer(cArray);

        }
    }
}
