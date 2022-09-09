using Modern_Real_Estates.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modern_Real_Estates.Controller
{
    public class Controller
    {

        //Recieve an index from the GUI and create the appropriate object.
        public void createEstate(int index)
        {
            switch (index)
            {
                //Warhouse
                case 0:

                    break;
                //Apartment
                case 1:

                    break;
                //Shop
                case 2:
                   
                    break;
                //Villa
                case 3:
                    
                    break;
            }
        }

        //Return all the countries in a list to populate the combobox in the GUI.
        public List<String> GetAllCountries()
        {
            var countryList = new List<String>();

            foreach (string name in Enum.GetNames(typeof(Countries)))
            {
                countryList.Add(name);
                Console.WriteLine(name);
            }
            return countryList;
        }
    }
}
