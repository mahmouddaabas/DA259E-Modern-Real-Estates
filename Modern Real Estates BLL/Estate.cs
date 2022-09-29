using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Modern_Real_Estates_BLL
{
    [Serializable]
    public abstract class Estate : IEstate
    {
        protected Estate(int id, String type, String legalform, EstateTypes estateType, Address address, String image)
        {
            ID = id;
            Type = type;
            LegalForm = legalform;
            EstateType = estateType;
            Address = address;
            Image = image;
        }

        public Estate()
        {
        }

        public abstract string[] print();

        public int ID { get; set; }
        public Address Address { get; set; }
        public string Type { get; set; }
        public string LegalForm { get; set; }
        public EstateTypes EstateType { get; set; }
        public String Image { get; set; }
    }
}
