﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLibrary
{
    public class CustomerModel : ICustomerModel
    {
        public string FistName { get; set; }
        public string LastName { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
    }
}
