﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modern_Real_Estates.Model
{
    [Serializable]
    internal class Warehouse : Commercial
    {


        public Warehouse()
        {
        }
        public Warehouse(int id, String type, String legalform, EstateTypes estateType, Address address, String image)
            : base(id, type, legalform, estateType, address, image)
        {
        }

        public string items { get; set; }
        public override string[] print()
        {
            return new[] { this.ID.ToString(), this.Type.ToString(), this.LegalForm.ToString(), this.Address.Street.ToString(), this.Address.City.ToString(), this.Address.Country.ToString(), this.Address.Zipcode.ToString(), this.Company, this.items };
        }

        public override string ToString()
        {
            return "ID: " + ID.ToString() + ", " + "Type: " + this.Type.ToString() + ", " + "Legalform: " + this.LegalForm.ToString() + ", " +
                "Street: "+ this.Address.Street.ToString() + ", " + "City: " + this.Address.City.ToString() + ", " +
               "Country: " + this.Address.Country.ToString() + ", " + "Zip Code: " + this.Address.Zipcode.ToString() + ", " + "Company: " + this.Company + ", " + "Items: " +this.items;
        }
    }
}
