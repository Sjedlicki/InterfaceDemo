using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLibrary
{
    public class CourseProductModel : IProductModel
    {
        public string Title { get; set; }

        public bool HasOrderBeenCompleted { get; private set; }

        public void ShipItem(CustomerModel customer)
        {
            if(HasOrderBeenCompleted == false)
            {
                Console.WriteLine($"Add the { Title } course to { customer.FistName }'s account.");
                HasOrderBeenCompleted = true;
            }
        }
    }
}
