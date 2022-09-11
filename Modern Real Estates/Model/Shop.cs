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
    }
}
