using System;
using System.Collections.Generic;
using DemoLibrary;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IProductModel> cart = AddSampleData();
            CustomerModel customer = GetCustomer();

            foreach (IProductModel product in cart)
            {
                product.ShipItem(customer);
                
                if(product is IDigitalProductModel digital)
                {
                    Console.WriteLine($"For the { digital.Title } you have { digital.TotalDownloadsLeft } downloads left"  );
                }
            }

            Console.ReadLine();
        }

        private static CustomerModel GetCustomer()
        {
            return new CustomerModel
            {
                FistName = "Stevo",
                LastName = "Jedi",
                City = "Moon City",
                EmailAddress = "e@mail.com",
                PhoneNumber = "555-1212"
            };
        }

        private static List<IProductModel> AddSampleData()
        {
            List<IProductModel> output = new List<IProductModel>();

            output.Add(new PhysicalProductModel { Title = "Nerf Football" });
            output.Add(new PhysicalProductModel { Title = "Steve is the best TA T-Shirt" });
            output.Add(new PhysicalProductModel { Title = "Hard Drives" });
            output.Add(new DigitalProductModel { Title = "C# Lessons Source Code" });
            output.Add(new CourseProductModel { Title = ".NET Core Interfaces" });

            return output;
        }
    }
}