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

        //Todo, do this through the controller instead.
        private void add_btn_Click(object sender, EventArgs e)
        {
            try
            {
            int option = type_txt.SelectedIndex;
            switch (option)
            {
                case 0:
                    //Institu
                    Image newImage = Image.FromFile(selectedImage);
                    Address address = new Address(street_txt.Text, city_txt.Text, zip_txt.Text, Enum.Parse<Countries>(country_txt.GetItemText(country_txt.SelectedItem)));
                    Institutional institutional = new Institutional(id, type_txt.GetItemText(type_txt.SelectedItem), legalform_txt.GetItemText(legalform_txt.SelectedItem), address, newImage);

                    var imageList = new ImageList();
                    imageList.Images.Add("pic1", newImage);
                    list.SmallImageList = imageList;

                    ListViewItem institution = new ListViewItem(Convert.ToString(id));
                    institution.SubItems.Add(institutional.print()[1]);
                    institution.SubItems.Add(institutional.print()[2]);
                    institution.SubItems.Add(institutional.print()[3]);
                    institution.SubItems.Add(institutional.print()[4]);
                    institution.SubItems.Add(institutional.print()[6]);
                    institution.SubItems.Add(institutional.print()[5]);
                    institution.ImageKey = "pic1";

                    list.Items.Add(institution);
                    id++;

                    break;
                case 1:
                    //Residential
                    break;
                case 2:
                    //Commercial
                    break;

                case 3:
                    //Residential
                    break;
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add an image!");
            }
        }

        private void change_btn_Click(object sender, EventArgs e)
        {
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

        }

        //Method to add entries to the list.
        private void AddToList()
        {

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
    }
}