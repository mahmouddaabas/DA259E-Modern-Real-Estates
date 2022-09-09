using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modern_Real_Estates.Model
{
    internal class Commercial : Estate
    {

        public Commercial(int id, String category, String type, Address address, Image image)
            : base(id, category, type, address, image)
        {

        }

        public override string[] print()
        {
            return new[] { this.ID.ToString(), this.Category.ToString(), this.Type.ToString(), this.Address.Street.ToString(), this.Address.Zipcode.ToString(), this.Address.City.ToString(), this.Address.Country.ToString() };
        }
    }
}
