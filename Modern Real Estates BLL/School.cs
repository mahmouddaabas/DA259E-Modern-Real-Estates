﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modern_Real_Estates_BLL
{
    [Serializable]
    public class School : Institutional
    {

        public School()
        {
        }

        public School(int id, String type, String legalform, EstateTypes estateType, Address address, String image)
            : base(id, type, legalform, estateType, address, image)
        {
        }

        public string pupils { get; set; }

        public override string[] print()
        {
            return new[] { this.ID.ToString(), this.Type.ToString(), this.LegalForm.ToString(), this.Address.Street.ToString(), this.Address.City.ToString(), this.Address.Country.ToString(), this.Address.Zipcode.ToString(), this.Agency, this.pupils };
        }
        public override string ToString()
        {
            return "ID: " + ID.ToString() + ", " + "Type: " + this.Type.ToString() + ", " + "Legalform: " + this.LegalForm.ToString() + ", " +
                "Street: " + this.Address.Street.ToString() + ", " + "City: " + this.Address.City.ToString() + ", " +
               "Country: " + this.Address.Country.ToString() + ", " + "Zip Code: " + this.Address.Zipcode.ToString() + ", " + "Agency: " + this.Agency + ", " + "Pupils: " + this.pupils;
        }
    }
}
