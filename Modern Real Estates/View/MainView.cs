using Modern_Real_Estates.Model;

namespace Modern_Real_Estates
{
    public partial class MainView : Form
    {

        private Controller.Controller controller;
        private int id = 0;
        private String selectedImage = "";
        private ImageList imageList;
        public MainView()
        {
            InitializeComponent();
            controller = new Controller.Controller();
            imageList = new ImageList();

            //Populate the country list on the GUI.
            populateCountryList();
        }

        //Create a estate object through the controller and add to the list when returned.
        private void add_btn_Click(object sender, EventArgs e)
        {
            //Creates the estate object
            try
            {
                Estate estate = controller.createEstate(type_txt.SelectedIndex, id, type_txt.Text, legalform_txt.Text, street_txt.Text, zip_txt.Text, city_txt.Text, Enum.Parse<Countries>(country_txt.GetItemText(country_txt.SelectedItem)), Image.FromFile(selectedImage), specificpropone_txt.Text, specificproptwo_txt.Text);

                //Sends the returned estate object through the parameter to add it to the list.
                AddToList(estate);
            }
            catch (Exception ex)
            {
                MessageBox.Show("You need to add an image to the entry!");
            }
        }

        //Change the information of the selected estate in the list.
        private void change_btn_Click(object sender, EventArgs e)
        {
            try
            {
                //Select the object that is stored in the list by its tag property.
                Estate selected = (Estate)list.SelectedItems[0].Tag;

                //Change all shared properties of the object.
                selected.ID = id - 1;
                selected.Category = type_txt.Text;
                selected.Type = legalform_txt.Text;
                selected.Address.City = city_txt.Text;
                selected.Address.Street = street_txt.Text;
                selected.Address.Zipcode = zip_txt.Text;
                selected.Address.Country = Enum.Parse<Countries>(country_txt.Text);

                //Change the object specific properties.
                switch (selected.print()[1])
                {
                    case "Warehouse":
                        ((Commercial)selected).Company = specificpropone_txt.Text;
                        ((Warehouse)selected).items = specificproptwo_txt.Text;
                        break;
                    case "Shop":
                        ((Commercial)selected).Company = specificpropone_txt.Text;
                        ((Shop)selected).wares = specificproptwo_txt.Text;
                        break;
                    case "Villa":
                        ((Residential)selected).Rooms = specificpropone_txt.Text;
                        ((Villa)selected).size = specificproptwo_txt.Text;
                        break;
                    case "Apartment":
                        ((Residential)selected).Rooms = specificpropone_txt.Text;
                        ((Apartment)selected).rent = specificproptwo_txt.Text;
                        break;
                    case "Townhouse":
                        ((Residential)selected).Rooms = specificpropone_txt.Text;
                        ((Townhouse)selected).floors = specificproptwo_txt.Text;
                        break;
                    case "Hospital":
                        ((Institutional)selected).Agency = specificpropone_txt.Text;
                        ((Hospital)selected).patients = specificproptwo_txt.Text;
                        break;
                    case "School":
                        ((Institutional)selected).Agency = specificpropone_txt.Text;
                        ((School)selected).pupils = specificproptwo_txt.Text;
                        break;
                    case "University":
                        ((Institutional)selected).Agency = specificpropone_txt.Text;
                        ((University)selected).students = specificproptwo_txt.Text;
                        break;
                }

                updateEstateList(selected);

            }
            catch (InvalidCastException exx)
            {
                MessageBox.Show("You can't change the type of a building!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select something from the list to edit by pressing on the ID.");
            }
        }

        //Method to update the estate list.
        private void updateEstateList(Estate estate)
        {
            ListViewItem item = new ListViewItem(Convert.ToString(id));

            //Add the objects information sent in its print method to the list columns.
            for (int i = 1; i < estate.print().Length; i++)
            {
                if (i == 7)
                {
                    list.SelectedItems[0].SubItems[i].Text = specificpropone_lbl.Text + " " + estate.print()[i];
  
                }
                else if (i == 8)
                {
                    list.SelectedItems[0].SubItems[i].Text = specificproptwo_lbl.Text + " " + estate.print()[i];
                }
                else
                {
                    list.SelectedItems[0].SubItems[i].Text = estate.print()[i];
                }
            }
        }

        //Method to populate the country list combobox from the countries enum.
        private void populateCountryList()
        {
            foreach (var i in controller.GetAllCountries())
            {
                country_txt.Items.Add(i);
            }

            type_txt.SelectedIndex = 0;
            legalform_txt.SelectedIndex = 0;
            country_txt.SelectedIndex = 0;
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                list.Items.Remove(list.SelectedItems[0]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select something from the list to delete by pressing on the ID.");
            }
        }

        //Method to add entries to the list.
        private void AddToList(Estate estate)
        {
            //Every image has a unique name by adding the incremental ID to the string.
            imageList.Images.Add("image" + id, Image.FromFile(selectedImage));
            list.SmallImageList = imageList;

            ListViewItem item = new ListViewItem(Convert.ToString(id));
            //Add the object send through the param to the list.
            item.Tag = estate;

            //Add the objects information send in its print method to the list columns.
            for (int i = 1; i < estate.print().Length; i++)
            {
                if(i == 7)
                {
                    item.SubItems.Add(specificpropone_lbl.Text+" "+ estate.print()[i]);
                }
                else if(i == 8){
                    item.SubItems.Add(specificproptwo_lbl.Text + " " +estate.print()[i]);
                }
                else
                {
                    item.SubItems.Add(estate.print()[i]);
                }
            }

            item.ImageKey = "image" + id;
            list.Items.Add(item);
            id++;
        }

        //Method that enables adding an image.
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Image files (*.png, *.jpg)|*.png;*.jpg";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openFileDialog1.FileName;
                selectedImage = selectedFileName;
            }
        }

        //Shows the specific attribute based on the selected type of estate.
        private void type_txt_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (type_txt.Text)
            {
                case "Warehouse":
                    specificpropone_lbl.Text = "Company:";
                    specificproptwo_lbl.Text = "Items:";
                    break;
                case "Shop":
                    specificpropone_lbl.Text = "Company:";
                    specificproptwo_lbl.Text = "Wares:";
                    break;
                case "Villa":
                    specificpropone_lbl.Text = "Rooms:";
                    specificproptwo_lbl.Text = "Size:";
                    break;
                case "Apartment":
                    specificpropone_lbl.Text = "Rooms:";
                    specificproptwo_lbl.Text = "Rent:";
                    break;
                case "Townhouse":
                    specificpropone_lbl.Text = "Rooms:";
                    specificproptwo_lbl.Text = "Floors:";
                    break;
                case "Hospital":
                    specificpropone_lbl.Text = "Agency:";
                    specificproptwo_lbl.Text = "Patients:";
                    break;
                case "School":
                    specificpropone_lbl.Text = "Agency:";
                    specificproptwo_lbl.Text = "Pupils:";
                    break;
                case "University":
                    specificpropone_lbl.Text = "Agency:";
                    specificproptwo_lbl.Text = "Students:";
                    break;
            }
        }
    }
}