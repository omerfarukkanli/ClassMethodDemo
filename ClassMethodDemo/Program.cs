using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Id = 1;
            customer.TcNo = "11111111111";
            customer.customerName = "Ömer Faruk";
            customer.customerLname = "Kanlı";
            customer.City = "İstanbul";
            customer.Town = "Pendik";

            Customer customer1 = new Customer();
            customer1.Id = 2;
            customer1.TcNo = "22222222222";
            customer1.customerName = "Mehmet";
            customer1.customerLname = "Kanlı";
            customer1.City = "İstnabul";
            customer1.Town = "Pendik";

            CustomerManager customerManager = new CustomerManager();
            Customer[] customers = new Customer[] { customer, customer1 };
            customerManager.Add(customer);
            customerManager.Delete(customer1);
            customerManager.Update(customer);
            customerManager.List(customers);
            
        }
    }
}
