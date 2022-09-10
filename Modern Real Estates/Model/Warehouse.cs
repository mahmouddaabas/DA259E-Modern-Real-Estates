using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modern_Real_Estates.Model
{
    internal class Warehouse : Commercial
    {
        public Warehouse(int id, String category, String type, Address address, Image image)
            : base(id, category, type, address, image)
        {

        }

        public Warehouse(int id, String category, String type, Address address, Image image, string items)
            : base(id, category, type, address, image)
        {
            this.items = items;
        }

        public string items { get; set; }
    }
}
