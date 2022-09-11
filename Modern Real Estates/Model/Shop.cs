using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modern_Real_Estates.Model
{
    internal class Shop : Commercial
    {

        public Shop(int id, String category, String type, Address address, Image image, string company, string wares)
            : base(id, category, type, address, image, company)
        {
            this.wares = wares;
        }

        public string wares { get; set; }
        public override string[] print()
        {
            return new[] { this.ID.ToString(), this.Category.ToString(), this.Type.ToString(), this.Address.Street.ToString(), this.Address.City.ToString(), this.Address.Country.ToString(), this.Address.Zipcode.ToString(), this.Company, this.wares };
        }
    }
}
