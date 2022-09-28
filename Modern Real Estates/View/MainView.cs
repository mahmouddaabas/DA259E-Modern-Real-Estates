using Modern_Real_Estates.Model;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Modern_Real_Estates
{
    [Serializable]
    public partial class MainView : Form
    {

        private Controller.Controller controller;
        private int id = 0;
        private String selectedImage = "";
        private ImageList imageList;
        private EstateTypes selectedEstateType;
        private EstateManager eManager = null;
        private bool saveSelected = false;
        private string selectedSavePath;
        private bool recentlySaved = false;
        public MainView()
        {
            InitializeComponent();
            controller = new Controller.Controller();
            imageList = new ImageList();
            eManager = new EstateManager();

            //Populate the country list on the GUI.
            populateCountryList();
        }

        //Create a estate object through the controller and add to the list when returned.
        private void add_btn_Click(object sender, EventArgs e)
        {
            //Creates the estate object
            try
            {
                //Creates a estate object through the method in the controller.
                Estate estate = controller.createEstate(type_txt.SelectedIndex, id, type_txt.Text, legalform_txt.Text, selectedEstateType, street_txt.Text, zip_txt.Text, city_txt.Text, Enum.Parse<Countries>(country_txt.GetItemText(country_txt.SelectedItem)), selectedImage, specificpropone_txt.Text, specificproptwo_txt.Text);

                //Adds the returned estate object through the parameter to the ListManager list.
                eManager.Add(estate);

                //Adds the estate to the GUI.
                AddToList();
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
            //Get the selected object from its tag property.
            Estate selected = (Estate)list.SelectedItems[0].Tag;

            //Change all shared properties of the object.
            //selected.ID = id;
            selected.Type = type_txt.Text;
            selected.LegalForm = legalform_txt.Text;
            selected.EstateType = selectedEstateType;
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

                int index = list.Items.IndexOf(list.SelectedItems[0]);
                eManager.ChangeAt(selected, index);
                updateEstateList(eManager.ToStringArray());
                recentlySaved = false;

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

        //Deletes an entry from the list.
        private void delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int index = list.Items.IndexOf(list.SelectedItems[0]);
                list.Items[index].Remove();
                eManager.DeleteAt(index);
                updateEstateList(eManager.ToStringArray());
                recentlySaved = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select something from the list to delete by pressing on the ID.");
            }
        }

        //Method to add entries to the list.
        private void AddToList()
        {
            //Clear the current list in the GUI.
            list.Items.Clear();

            imageList.Images.Add(selectedImage, Image.FromFile(selectedImage));
            list.SmallImageList = imageList;

            //Add the new objects from the list in the ListManager to the GUI.
            for (int i = 0; i < eManager.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                Estate estate = eManager.GetAt(i);
                item.Text = estate.ToString();
                item.Tag = estate;
                item.ImageKey = estate.Image;
                list.Items.Add(item);
            }
            recentlySaved = false;
            id++;
        }

        //Method to update the estate list.
        private void updateEstateList(string[] newList)
        {
            list.SmallImageList = imageList;

            //Clear the current list in the GUI.
            list.Items.Clear();
            for(int i = 0; i < eManager.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Text = newList[i].ToString();
                Estate estate = eManager.GetAt(i);
                item.Tag = estate;

                //Set the ID to the number of elements in the list in ListManager
                id = eManager.Count+1;

                if (!string.IsNullOrEmpty(estate.Image))
                {
                    imageList.Images.Add(estate.Image, Image.FromFile(estate.Image));
                    item.ImageKey = estate.Image;
                }

                list.Items.Add(item);
            }
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
                    selectedEstateType = EstateTypes.Commercial;
                    break;
                case "Shop":
                    specificpropone_lbl.Text = "Company:";
                    specificproptwo_lbl.Text = "Wares:";
                    selectedEstateType = EstateTypes.Commercial;
                    break;
                case "Villa":
                    specificpropone_lbl.Text = "Rooms:";
                    specificproptwo_lbl.Text = "Size:";
                    selectedEstateType = EstateTypes.Residential;
                    break;
                case "Apartment":
                    specificpropone_lbl.Text = "Rooms:";
                    specificproptwo_lbl.Text = "Rent:";
                    selectedEstateType = EstateTypes.Residential;
                    break;
                case "Townhouse":
                    specificpropone_lbl.Text = "Rooms:";
                    specificproptwo_lbl.Text = "Floors:";
                    selectedEstateType = EstateTypes.Residential;
                    break;
                case "Hospital":
                    specificpropone_lbl.Text = "Agency:";
                    specificproptwo_lbl.Text = "Patients:";
                    selectedEstateType = EstateTypes.Institutional;
                    break;
                case "School":
                    specificpropone_lbl.Text = "Agency:";
                    specificproptwo_lbl.Text = "Pupils:";
                    selectedEstateType = EstateTypes.Institutional;
                    break;
                case "University":
                    specificpropone_lbl.Text = "Agency:";
                    specificproptwo_lbl.Text = "Students:";
                    selectedEstateType = EstateTypes.Institutional;
                    break;
            }
        }

        //Opens a saved data file.
        private void Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse data files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "dat",
                Filter = "dat files (*.dat)|*.dat",
                FilterIndex = 2,
                RestoreDirectory = true,
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Clear the old list.
                list.Items.Clear();
                //Set the filepath into the variable and set the bool to true.
                selectedSavePath = openFileDialog1.FileName;
                saveSelected = true;
                //Save the file by serializing it.
                eManager.BinaryDeSerialize(openFileDialog1.FileName);
                //Update the list to show the file on the GUI.
                updateEstateList(eManager.ToStringArray());
            }
        }

        //Returns the application to an unused state.
        private void New_Click(object sender, EventArgs e)
        {
            //Check if user has recently saved or not.
            if(recentlySaved == true)
            {
                resetApplication();
            }
            else
            {
                //If user answers yes reset application.
                DialogResult dialogResult = MessageBox.Show("Press Yes or No.", "Are you sure you want to reset?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    resetApplication();
                }
            }
        }

        //Method to reset the application to its unused state.
        private void resetApplication()
        {
            //Clear the list on the GUI.
            list.Items.Clear();
            //Delete all objects in the list in ListManager and set list to null.
            eManager.DeleteAll();
            //Recreate object of the list/estatemanager.
            eManager = new EstateManager();
        }

        //Saves the current state of the application.
        private void Save_Click(object sender, EventArgs e)
        {
            if(saveSelected == true)
            {
                //If user already opened a save, rewrite it.
                eManager.BinarySerialize(selectedSavePath);
                recentlySaved = true;
            }
            else
            {
                //If user is saving for the first time, ask where they want to save.
                saveFileTo();
            }
        }

        //Save the data a place of the the users choosing.
        private void SaveAs_Click(object sender, EventArgs e)
        {
            saveFileTo();
        }

        //Method that allows saving of a file where the user wants.
        private void saveFileTo()
        {
            System.Windows.Forms.SaveFileDialog saveFileDialog1;
            saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            saveFileDialog1.Filter = "dat files (*.dat)|*.dat";
            saveFileDialog1.DefaultExt = ".dat";
            DialogResult dr = saveFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                //Save the file at the location specified by the user.
                string filename = saveFileDialog1.FileName;
                eManager.BinarySerialize(filename);
                recentlySaved = true;
            }
        }

        //Closes the program.
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}