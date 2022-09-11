﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modern_Real_Estates.Model
{
    public class Townhouse : Residential
    {

            public Townhouse(int id, String category, String type, Address address, Image image, string rooms, string floors)
                : base(id, category, type, address, image, rooms)
            {
                this.floors = floors;
            }

            public string floors { get; set; }

        public override string[] print()
        {
            return new[] { this.ID.ToString(), this.Category.ToString(), this.Type.ToString(), this.Address.Street.ToString(), this.Address.City.ToString(), this.Address.Country.ToString(), this.Address.Zipcode.ToString(), this.Rooms, this.floors };
        }
    }

}