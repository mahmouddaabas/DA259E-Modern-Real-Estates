using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modern_Real_Estates.Model
{
    public class Institutional : Estate
    {

        private string agency;

        public Institutional(int id, String category, String type, Address address, Image image, String agency)
            : base(id, category, type, address, image)
        {
            this.agency = agency;
        }

        public string Agency
        {
            get { return agency; }
            set { agency = value; }
        }

        public override string[] print()
        {
            return new[] { this.ID.ToString(), this.Category.ToString(), this.Type.ToString(), this.Address.Street.ToString(), this.Address.City.ToString(), this.Address.Country.ToString(), this.Address.Zipcode.ToString()};
        }
    }
}
