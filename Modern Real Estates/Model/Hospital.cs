﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modern_Real_Estates.Model
{
    public class Hospital : Institutional
    {

        public Hospital(int id, String category, String type, Address address, Image image, string agency, string patients)
            : base(id, category, type, address, image, agency)
        {
            this.patients = patients;
        }

        public string patients { get; set; }

        public override string[] print()
        {
            return new[] { this.ID.ToString(), this.Category.ToString(), this.Type.ToString(), this.Address.Street.ToString(), this.Address.City.ToString(), this.Address.Country.ToString(), this.Address.Zipcode.ToString(), this.Agency, this.patients };
        }
    }
}