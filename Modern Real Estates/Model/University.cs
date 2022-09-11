using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modern_Real_Estates.Model
{
    public class University : Institutional
    {

        public University(int id, String category, String type, Address address, Image image, string agency, string students)
            : base(id, category, type, address, image, agency)
        {
            this.students = students;
        }

        public string students { get; set; }
    }
}
