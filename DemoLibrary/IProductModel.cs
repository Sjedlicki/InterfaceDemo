using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLibrary
{
    public interface IProductModel
    {
        string Title { get; set; }

        bool HasOrderBeenCompleted { get; }

        void ShipItem(CustomerModel customer);
    }
}
