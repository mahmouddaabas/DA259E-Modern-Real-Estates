using Modern_Real_Estates.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Modern_Real_Estates.Controller
{
    [Serializable]
    public class Controller
    {
        private Estate estate = null;

        //Recieve an index and data from the GUI then create the appropriate object.
        public Estate createEstate(int index, int id, string type, string legalform, EstateTypes estateType, string street, string zipcode, string city, Countries country, String image, string propone, string proptwo)
        {

            switch (estateType)
            {
                //Call method to create an object based on the estate type.
                case EstateTypes.Residential:
                        estate = createResidential(index, id, type, legalform, estateType, street, zipcode, city, country, image, propone, proptwo);
                    break;
                case EstateTypes.Institutional:
                    estate = createInstitutional(index, id, type, legalform, estateType, street, zipcode, city, country, image, propone, proptwo);
                    break;
                case EstateTypes.Commercial:
                    estate = createCommercial(index, id, type, legalform, estateType, street, zipcode, city, country, image, propone, proptwo);
                    break;
            }

            //Return the created estate object to the caller.
            return estate;
        }

        //Method to create all the instituional types.
        private Estate createInstitutional(int index, int id, string type, string legalform, EstateTypes estateType, string street, string zipcode, string city, Countries country, String image, string propone, string proptwo)
        {
            Estate estate = null;
            Address address = createAddress(street, zipcode, city, country);

            switch (index)
            {
                case 5:
                    estate = new Hospital(id, type, legalform, estateType, address, image);
                    ((Institutional)estate).Agency = propone;
                    ((Hospital)estate).patients = proptwo;
                    return estate;
                case 6:
                    estate = new School(id, type, legalform, estateType, address, image);
                    ((Institutional)estate).Agency = propone;
                    ((School)estate).pupils = proptwo;
                    return estate;
                case 7:
                    estate = new University(id, type, legalform, estateType, address, image);
                    ((Institutional)estate).Agency = propone;
                    ((University)estate).students = proptwo;
                    return estate;
            }

            return estate;
        }

        //Method to create all the residential types.
        private Estate createResidential(int index, int id, string type, string legalform, EstateTypes estateType, string street, string zipcode, string city, Countries country, String image, string propone, string proptwo)
        {
            Estate estate = null;
            Address address = createAddress(street, zipcode, city, country);

            switch (index)
            {
                case 1:
                    estate = new Apartment(id, type, legalform, estateType, address, image);
                    ((Residential)estate).Rooms = propone;
                    ((Apartment)estate).rent = proptwo;
                    return estate;
                case 3:
                    estate = new Villa(id, type, legalform, estateType, address, image);
                    ((Residential)estate).Rooms = propone;
                    ((Villa)estate).size = proptwo;
                    return estate;
                case 4:
                    estate = new Townhouse(id, type, legalform, estateType, address, image);
                    ((Residential)estate).Rooms = propone;
                    ((Townhouse)estate).floors = proptwo;
                    return estate;
            }

            return estate;

        }

        //Method to create all the commercial class types.
        private Estate createCommercial(int index, int id, string type, string legalform, EstateTypes estateType, string street, string zipcode, string city, Countries country, String image, string propone, string proptwo)
        {

            Estate estate = null;
            Address address = createAddress(street, zipcode, city, country);

            switch (index)
            {
                case 0:
                    estate = new Warehouse(id, type, legalform, estateType, address, image);
                    ((Commercial)estate).Company = propone;
                    ((Warehouse)estate).items = proptwo;
                    return estate;
                case 2:
                    estate = new Shop(id, type, legalform, estateType, address, image);
                    ((Commercial)estate).Company = propone;
                    ((Shop)estate).wares = proptwo;
                    return estate;
            }

            return estate;

        }

        //Method to create an address.
        private Address createAddress(string street, string zipcode, string city, Countries country)
        {
            //Create an address object and set the properties from the parameters.
            Address address = new Address();
            address.Street = street;
            address.Zipcode = zipcode;
            address.City = city;
            address.Country = country;

            return address;
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
