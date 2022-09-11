using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modern_Real_Estates.Model
{
    internal class Commercial : Estate
    {

        private String company;

        public Commercial(int id, String category, String type, Address address, Image image, String company)
            : base(id, category, type, address, image)
        {
            this.company = company;
        }

        public string Company
        {
            get{ return company; }
            set { company = value; }
        }

        public override string[] print()
        {
            return new[] { this.ID.ToString(), this.Category.ToString(), this.Type.ToString(), this.Address.Street.ToString(), this.Address.City.ToString(), this.Address.Country.ToString(), this.Address.Zipcode.ToString() };
        }
    }
}
