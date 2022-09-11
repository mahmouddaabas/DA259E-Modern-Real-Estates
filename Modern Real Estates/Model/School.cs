using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modern_Real_Estates.Model
{
    internal class School : Institutional
    {

        public School(int id, String category, String type, Address address, Image image, string agency, string pupils)
            : base(id, category, type, address, image, agency)
        {
            this.pupils = pupils;
        }

        public string pupils { get; set; }
    }
}
