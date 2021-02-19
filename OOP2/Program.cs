using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {

            RealCustomer customer1 = new RealCustomer();
            customer1.Id = 2;
            customer1.CustomerNumber = "12345";
            customer1.Name = "ibrahim";
            customer1.LastName = "Alzamel";
            customer1.TcNumber = "0123456789";

            LegalCustomer customer2 = new LegalCustomer();
            customer2.Id = 2;
            customer2.CustomerNumber = "54321";
            customer2.CompanyNumber = "alzamel";
            customer2.TaxNumber = "1234567890";

            Customer customer3 = new RealCustomer();
            Customer customer4 = new LegalCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Add(customer4);




        }
    }
}
