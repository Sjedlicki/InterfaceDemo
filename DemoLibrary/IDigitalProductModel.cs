using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLibrary
{
    public interface IDigitalProductModel : IProductModel
    {
        int TotalDownloadsLeft { get; }
    }
}
