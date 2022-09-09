using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modern_Real_Estates.Model
{
    public class Apartment : Residential
    {
        public Apartment(int id, String category, String type, Address address, Image image)
            : base(id, category, type, address, image)
        {

        }

        public int Floor { get; set; }
    }
}
