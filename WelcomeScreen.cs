using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace Pet_Companion
{
    public partial class WelcomeScreen : Form
    {
        private string selectedImagePath = "";

        public List<Pet> pet = new List<Pet>();

        //Maximizing the window
        private void Dashboard_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
        
        
        public WelcomeScreen()
        {


            InitializeComponent();

            //Creating the radio buttons
            rdoDog.CheckedChanged += PetTypeChanged;
            rdoCat.CheckedChanged += PetTypeChanged;
            rdoPig.CheckedChanged += PetTypeChanged;
            rdoHedgehog.CheckedChanged += PetTypeChanged;

        }




        private void PetTypeChanged(object sender, EventArgs e)
        {
            //Show the group based on the user's selection
            grpCustomizeDog.Visible = rdoDog.Checked; //If radio button dog is checked, show the dog groupbox
            grpCustomizeCat.Visible = rdoCat.Checked;
            grpCustomizePig.Visible = rdoPig.Checked;
            grpCustomizeHedgehog.Visible = rdoHedgehog.Checked;
        }


        private bool ValidateInput() //Whether the input is valid
        {
            if (rdoDog.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtDogName.Text)) //If its empty, has spaces or missing values
                {
                    txtDogName.Focus(); //Moves cursor to the DogName field
                    return ShowError("Dog Name is required!"); //Error message
                }
                if (cmbFavoriteDogToy.SelectedItem == null)
                {
                    txtDogName.Focus(); //Moves cursor to the DogName field
                    return ShowError("Please select your favorite dog toy!"); //Error message
                }
            }
            else if (rdoCat.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtCatName.Text)) //If its empty, has spaces or missing values
                {
                    txtCatName.Focus(); //Moves cursor to the CatName field
                    return ShowError("Cat Name is required!"); //Error message
                }
                if (cmbFavoriteCatToy.SelectedItem == null)
                {
                    txtCatName.Focus(); //Moves cursor to the CatName field
                    return ShowError("Please select your favorite cat toy!"); //Error message
                }
            }
            else if (rdoPig.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtPigName.Text)) //If its empty, has spaces or missing values
                {
                    txtPigName.Focus(); //Moves cursor to the PigName field
                    return ShowError("Pig Name is required!"); //Error message
                }
                if (cmbFavoritePigToy.SelectedItem == null)
                {
                    txtPigName.Focus(); //Moves cursor to the PigName field
                    return ShowError("Please select your favorite pig toy!"); //Error message
                }
            }
            else if (rdoHedgehog.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtHedgehogName.Text)) //If its empty, has spaces or missing values
                {
                    txtHedgehogName.Focus(); //Moves cursor to the HedgehogName field
                    return ShowError("Hedgehog Name is required!"); //Error message
                }
                if (cmbFavoriteHedgehogToy.SelectedItem == null)
                {
                    txtHedgehogName.Focus(); //Moves cursor to the HedgeHogName field
                    return ShowError("Please select your favorite hedgehog toy!"); //Error message
                }
            }
            return true;

        }
        private bool ShowError(string message) //For showing the error message
        {
            MessageBox.Show(message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); //Displays the ok button and the warning icon
            return false;
        }

        private Pet CreatePet()
        {
            Pet pet = null; //is required since we don't know what type of pet

            if (rdoDog.Checked) //if dog is checked
            {
                pet = new Dog(txtDogName.Text, cmbFavoriteDogToy.Text);




            }
            else if (rdoCat.Checked) //If cat is checked
            {
                pet = new Cat(txtCatName.Text, cmbFavoriteCatToy.Text);


            }
            else if (rdoPig.Checked) //If pig is checked
            {
                pet = new Pig(txtPigName.Text, cmbFavoritePigToy.Text);


            }
            else if (rdoHedgehog.Checked)//If hedgehog is checked
            {
                pet = new Hedgehog(txtHedgehogName.Text, cmbFavoriteHedgehogToy.Text);



            }

            return pet;
        }





        private void cmbFavoriteDogToy_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedToy = cmbFavoriteDogToy.SelectedItem.ToString();

            switch (selectedToy)
            {
                case "Bone": //If bone toy selected, show the bone image
                    pictureBoxDogToy.Image = Properties.Resources.Bone___Dog_Toy;
                    break;
                case "Ball": //if ball selected, show the ball image 
                    pictureBoxDogToy.Image = Properties.Resources.Ball___Dog_Toy;
                    break;
                case "Dog Rope": //If dog rope selected, show the dog rope image
                    pictureBoxDogToy.Image = Properties.Resources.Rope___Dog_Toy;
                    break;
            }
        }

        private void cmbFavoriteCatToy_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string selectedToy = cmbFavoriteCatToy.SelectedItem.ToString();

            switch (selectedToy)
            {
                case "Feather":
                    pictureBoxCatToy.Image = Properties.Resources.Feather___Cat_Toy;
                    break;
                case "Yarn":
                    pictureBoxCatToy.Image = Properties.Resources.Yarn_Ball___Cat_Toy;
                    break;
                case "Laser Pointer":
                    pictureBoxCatToy.Image = Properties.Resources.Laser_Pointer___Cat_Toy;
                    break;
            }
        }

        private void cmbFavoritePigToy_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedToy = cmbFavoritePigToy.SelectedItem.ToString();

            switch (selectedToy)
            {
                case "Pig Rope":
                    pictureBoxPigToy.Image = Properties.Resources.Rope___Pig_Toy;
                    break;
                case "Bell":
                    pictureBoxPigToy.Image = Properties.Resources.Bell___Pig_Toy;
                    break;
                case "Stuffed Carrot":
                    pictureBoxPigToy.Image = Properties.Resources.Stuffed_Carrot___Pig_Toy;
                    break;
            }
        }

        private void cmbFavoriteHedgehogToy_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedToy = cmbFavoriteHedgehogToy.SelectedItem.ToString();

            switch (selectedToy)
            {
                case "Insect Toy":
                    pictureBoxHedgehogToy.Image = Properties.Resources.Insect_Toy___Hedgehog_Toy;
                    break;
                case "Mini Ball":
                    pictureBoxHedgehogToy.Image = Properties.Resources.Mini_Ball___Hedgehog_Toy;
                    break;
                case "Plush Worm":
                    pictureBoxHedgehogToy.Image = Properties.Resources.Plush_Worm___Hedgehog_Toy;
                    break;
            }



        }

        private void btnSubmit_Click(object sender, EventArgs e) //Submitting all of our information and displaying it in the FormDashboard
        {
            if (!ValidateInput()) return; 

            Pet myPet = CreatePet();

            Image dogToyImage = pictureBoxDogToy.Image;
            Image catToyImage = pictureBoxCatToy.Image;
            Image pigToyImage = pictureBoxPigToy.Image;
            Image hedgehogToyImage = pictureBoxHedgehogToy.Image;

            Image petImage = null;

            if (rdoDog.Checked)
                petImage = Properties.Resources.Happy_Dog; //If dog checked, show the happy dog image
            else if (rdoCat.Checked)
                petImage = Properties.Resources.Happy_Cat; //If cat checked, show the happy cat image
            else if (rdoPig.Checked)
                petImage = Properties.Resources.Happy_Pig; //If pig checked, show the happy pig image
            else if (rdoHedgehog.Checked)
                petImage = Properties.Resources.Happy_Hedgehog; //If hedgehog checked, show the happy hedgehog image

            //Close the current form
            this.Hide();

            //Instantiate the secondary form
            // ProfileDetailForm frmDetail = new ProfileDetailForm(personObj); pass the person obj to the secondary form
            FormDashboard frmDashboard = new FormDashboard(myPet, dogToyImage, catToyImage, pigToyImage, hedgehogToyImage, petImage);

            //Show the new form
            frmDashboard.Show();
        }

        private void rdoDog_CheckedChanged(object sender, EventArgs e) //If dog is checked show the happy dog image
        {
            if (rdoDog.Checked)
                pictureBoxChoice.Image = Properties.Resources.Happy_Dog;
        
        }

        private void rdoCat_CheckedChanged(object sender, EventArgs e) //If cat is checked, show the happy cat image
        {
            if (rdoCat.Checked)
                pictureBoxChoice.Image = Properties.Resources.Happy_Cat;

        }

        private void rdoPig_CheckedChanged(object sender, EventArgs e) //If pig is checked, show the happy pig image
        {
            if (rdoPig.Checked)
                pictureBoxChoice.Image = Properties.Resources.Happy_Pig;

        }

        private void rdoHedgehog_CheckedChanged(object sender, EventArgs e) //If hedgehog is checked, show the happy hedgehog
        {
            if (rdoHedgehog.Checked)
                pictureBoxChoice.Image = Properties.Resources.Happy_Hedgehog;
        }
    }
}


