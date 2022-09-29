using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modern_Real_Estates_BLL
{
    [Serializable]
    public abstract class Institutional : Estate
    {

        private string agency;

        public Institutional()
        {
        }

        public Institutional(int id, String type, String legalform, EstateTypes estateType, Address address, String image)
            : base(id, type, legalform, estateType, address, image)
        {
        }

        public string Agency
        {
            get { return agency; }
            set { agency = value; }
        }

        public override string[] print()
        {
            return new[] { this.ID.ToString(), this.Type.ToString(), this.LegalForm.ToString(), this.Address.Street.ToString(), this.Address.City.ToString(), this.Address.Country.ToString(), this.Address.Zipcode.ToString() };
        }
    }
}
