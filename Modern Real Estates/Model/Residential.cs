using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modern_Real_Estates.Model
{
    public class Residential : Estate
    {

        private String rooms;

        public Residential(int id, String category, String type, Address address, Image image, String rooms)
            : base(id, category, type, address, image)
        {
            this.rooms = rooms;
        }

        public string Rooms
        {
            get { return rooms; }
            set { rooms = value; }
        }

        public override string[] print()
        {
            return new[] { this.ID.ToString(), this.Category.ToString(), this.Type.ToString(), this.Address.Street.ToString(), this.Address.City.ToString(), this.Address.Country.ToString(), this.Address.Zipcode.ToString() };
        }
    }
}
