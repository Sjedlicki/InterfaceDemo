﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLibrary
{
    public class PhysicalProductModel : IProductModel
    {
        public string Title { get; set; }
        public bool HasOrderBeenCompleted { get; private set; }

        public void ShipItem(CustomerModel customer)
        {
            if(HasOrderBeenCompleted == false)
            {
                Console.WriteLine($"Simulating shipping { Title } to { customer.FistName } in { customer.City }");
                HasOrderBeenCompleted = true;
            }
        }
    }
}
