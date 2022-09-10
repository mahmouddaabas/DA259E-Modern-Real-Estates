using Modern_Real_Estates.Model;

namespace Modern_Real_Estates
{
    public partial class MainView : Form
    {

        private Controller.Controller controller;
        private int id = 0;
        private String selectedImage;
        public MainView()
        {
            InitializeComponent();
            controller = new Controller.Controller();

            //Populate the country list on the GUI.
            populateCountryList();
        }

        //Create a estate object through the controller and add to the list when returned.
        private void add_btn_Click(object sender, EventArgs e)
        {
            //Creates the estate object
            try
            {
              Estate estate = controller.createEstate(type_txt.SelectedIndex, id, type_txt.Text, legalform_txt.Text, street_txt.Text, zip_txt.Text, city_txt.Text, Enum.Parse<Countries>(country_txt.GetItemText(country_txt.SelectedItem)), Image.FromFile(selectedImage), specificprop_txt.Text);

              //Sends the returned estate object through the parameter to add it to the list.
              AddToList(estate);
            }
            catch (Exception ex)
            {
                MessageBox.Show("You need to add an image!");
            }
        }

        //Change the information of the selected estate in the list.
        private void change_btn_Click(object sender, EventArgs e)
        {
            try
            {
                list.SelectedItems[0].SubItems[1].Text = type_txt.Text;
                list.SelectedItems[0].SubItems[2].Text = legalform_txt.Text;
                list.SelectedItems[0].SubItems[3].Text = street_txt.Text;
                list.SelectedItems[0].SubItems[4].Text = zip_txt.Text;
                list.SelectedItems[0].SubItems[5].Text = city_txt.Text;
                list.SelectedItems[0].SubItems[6].Text = country_txt.Text;
                list.SelectedItems[0].SubItems[7].Text = specificprop_lbl.Text+" " + specificprop_txt.Text;
            }
            catch(Exception ex)
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

        private void delete_btn_Click(object sender, EventArgs e)
        {
            try { 
            list.Items.Remove(list.SelectedItems[0]);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Select something from the list to delete by pressing on the ID.");
            }
}

        //Method to add entries to the list.
        private void AddToList(Estate estate)
        {
            var imageList = new ImageList();
            imageList.Images.Add("pic1", Image.FromFile(selectedImage));
            list.SmallImageList = imageList;

            ListViewItem estatelist = new ListViewItem(Convert.ToString(id));
            for (int i = 1; i < estate.print().Length; i++)
            {
                estatelist.SubItems.Add(estate.print()[i]);
            }

            //Find out which property of a subclass to add based on the type of estate.
            switch (estate.print()[1])
            {
                case "Warehouse":
                    estatelist.SubItems.Add(specificprop_lbl.Text +" " + ((Warehouse)estate).items);
                    break;
                case "Apartment":
                    estatelist.SubItems.Add(specificprop_lbl.Text + " " + ((Apartment)estate).rent);
                    break;
                case "Villa":
                    estatelist.SubItems.Add(specificprop_lbl.Text + " " + ((Villa)estate).rooms);
                    break;
                case "Shop":
                    estatelist.SubItems.Add(specificprop_lbl.Text + " " + ((Shop)estate).wares);
                    break;
                default:
                    estatelist.SubItems.Add(specificprop_lbl.Text + " " + estatelist.SubItems.Add("None"));
                    break;

            }
            estatelist.ImageKey = "pic1";
            list.Items.Add(estatelist);
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
                    specificprop_lbl.Text = "Items:";
                    break;
                case "Shop":
                    specificprop_lbl.Text = "Wares:";
                    break;
                case "Villa":
                    specificprop_lbl.Text = "Rooms:";
                    break;
                case "Apartment":
                    specificprop_lbl.Text = "Rent:";
                    break;
            }
        }
    }
}