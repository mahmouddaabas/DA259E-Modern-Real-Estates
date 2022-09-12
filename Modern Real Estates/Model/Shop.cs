﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modern_Real_Estates.Model
{
    internal class Shop : Commercial
    {

        public Shop(int id, String type, String legalform, EstateTypes estateType, Address address, Image image)
            : base(id, type, legalform, estateType, address, image)
        {
        }

        public string wares { get; set; }
        public override string[] print()
        {
            return new[] { this.ID.ToString(), this.Type.ToString(), this.LegalForm.ToString(), this.Address.Street.ToString(), this.Address.City.ToString(), this.Address.Country.ToString(), this.Address.Zipcode.ToString(), this.Company, this.wares };
        }
    }
}
