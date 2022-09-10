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

        private Address address = null;
        private Estate estate = null;

        //Recieve an index and data from the GUI then create the appropriate object.
        public Estate createEstate(int index, int id, string category, string type, string street, string zipcode, string city, Countries country, Image image, String property)
        {
            //Create the address with the information from the parameters.
            address = new Address(street, zipcode, city, country);

            switch (index)
            {
                //Create a warehouse object and insert the address created above.
                case 0:
                    estate = new Warehouse(id, category, type, address, image, property);
                    break;
                //Create an apartment object and insert the address created above.
                case 1:
                    estate = new Apartment(id, category, type, address, image, property);
                    break;
                //Create a shop object and insert the address created above.
                case 2:
                    estate = new Shop(id, category, type, address, image, property);
                    break;
                //Create a villa object and insert the address created above.
                case 3:
                    estate = new Villa(id, category, type, address, image, property);
                    break;
            }

            //Return the created estate object to the caller.
            return estate;
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
