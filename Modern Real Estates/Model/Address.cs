﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modern_Real_Estates.Model
{
    [Serializable]
    public class Address
    {
        public Address()
        {
        }
        public Address(string street, string zipcode, string city, Countries country)
        {
            Street = street;
            Zipcode = zipcode;
            City = city;
            Country = country;
        }

        public string Street { get; set; }
        public string Zipcode { get; set; }
        public string City { get; set; }
        public Countries Country { get; set; }
    }
}
