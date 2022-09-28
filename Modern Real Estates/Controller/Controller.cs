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

            //Return the created estate object to the caller after setting all properties.
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
                    estate = new Hospital();
                    break;
                case 6:
                    estate = new School();
                    break;
                case 7:
                    estate = new University();
                    break;
            }

            //Set all the estate properties
            estate.ID = id;
            estate.Type = type;
            estate.LegalForm = legalform;
            estate.EstateType = estateType;
            estate.Address = address;
            estate.Image = image;

            //Set the properties specific to the type and specific estate.
            addInstitutionalAttributes(estate, propone, proptwo);

            return estate;
        }

        //Function to add the attributes for the specific estate and estatetype.
        private void addInstitutionalAttributes(Estate estate, string propone, string proptwo)
        {
            //Add the attribute that is shared by all instituional estates.
            ((Institutional)estate).Agency = propone;

            //Set the attribute for the specific estate.
            switch (estate.Type)
            {
                case "Hospital":
                    ((Hospital)estate).patients = proptwo;
                    break;
                case "School":
                    ((School)estate).pupils = proptwo;
                    break;
                case "University":
                    ((University)estate).students = proptwo;
                    break;
            }
        }

        //Method to create all the residential types.
        private Estate createResidential(int index, int id, string type, string legalform, EstateTypes estateType, string street, string zipcode, string city, Countries country, String image, string propone, string proptwo)
        {
            Estate estate = null;
            Address address = createAddress(street, zipcode, city, country);

            switch (index)
            {
                case 1:
                    estate = new Apartment();
                    break;
                case 3:
                    estate = new Villa();
                    break;
                case 4:
                    estate = new Townhouse();
                    break;
            }

            //Set all the estate properties
            estate.ID = id;
            estate.Type = type;
            estate.LegalForm = legalform;
            estate.EstateType = estateType;
            estate.Address = address;
            estate.Image = image;

            //Set the properties specific to the type and specific estate.
            addResidentialAttributes(estate, propone, proptwo);

            return estate;

        }

        //Function to add the attributes for the specific estate and estatetype.
        private void addResidentialAttributes(Estate estate, string propone, string proptwo)
        {
            //Add the attribute that is shared by all residential estates.
            ((Residential)estate).Rooms = propone;

            //Set the attribute for the specific estate.
            switch (estate.Type)
            {
                case "Apartment":
                    ((Apartment)estate).rent = proptwo;
                    break;
                case "Villa":
                    ((Villa)estate).size = proptwo;
                    break;
                case "Townhouse":
                    ((Townhouse)estate).floors = proptwo;
                    break;
            }
        }

        //Method to create all the commercial class types.
        private Estate createCommercial(int index, int id, string type, string legalform, EstateTypes estateType, string street, string zipcode, string city, Countries country, String image, string propone, string proptwo)
        {

            Estate estate = null;
            Address address = createAddress(street, zipcode, city, country);

            switch (index)
            {
                case 0:
                    estate = new Warehouse();
                    break;
                case 2:
                    estate = new Shop();
                    break;
            }

            //Set all the estate properties
            estate.ID = id;
            estate.Type = type;
            estate.LegalForm = legalform;
            estate.EstateType = estateType;
            estate.Address = address;
            estate.Image = image;

            //Set the properties specific to the type and specific estate.
            addCommercialAttributes(estate, propone, proptwo);

            return estate;

        }

        //Function to add the attributes for the specific estate and estatetype.
        private void addCommercialAttributes(Estate estate, string propone, string proptwo)
        {
            //Add the attribute that is shared by all commercial estates.
            ((Commercial)estate).Company = propone;

            //Set the attribute for the specific estate.
            switch (estate.Type)
            {
                case "Warehouse":
                    ((Warehouse)estate).items = proptwo;
                    break;
                case "Shop":
                    ((Shop)estate).wares = proptwo;
                    break;
            }
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
