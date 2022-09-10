using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Modern_Real_Estates.Model
{
    public abstract class Estate : IEstate
    {
        protected Estate(int id, String category, String type, Address address, Image image)
        {
            ID = id;
            Category = category;
            Type = type;
            Address = address;
            Image = image;
        }

        public abstract string[] print();

        public int ID { get; set; }
        public Address Address { get; set; }
        public string Category { get; set; }
        public string Type { get; set; }
        public Image Image { get; set; }
    }
}
