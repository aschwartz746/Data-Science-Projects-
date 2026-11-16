using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pet_Companion
{
     
    public partial class FormDashboard : Form
    {
     private Pet currentPet;
     private string lastAction;

     //Displaying the auto properties
     public Image DogToyImage { get; set; }
     public Image CatToyImage { get; set; }

     public Image PigToyImage { get; set; }

     public Image HedgehogToyImage { get; set; }

     public bool MoodCheckInComplete { get; set; } = false;

     public string SelectedMood { get; set; }
     

        public FormDashboard(Pet pet, Image dogToyImage, Image catToyImage, Image pigToyImage, Image hedgehogToyImage, Image petImage) //Calling in the information into the FormDashboard
        {
            InitializeComponent();
            currentPet = pet;

            DogToyImage = dogToyImage;
            CatToyImage = catToyImage;
            PigToyImage = pigToyImage; 
            HedgehogToyImage = hedgehogToyImage;

            lblPetName.Text = $"Welcome {currentPet.PetName}, here are your options for interacting with your pet!"; //Creating the welcome label 

            pictureBoxPet.Image = petImage;
            lblPetMessage.Text = " "; //Making the pet message clear until the user interacts with the mood 

           
            
        }

        private void Dashboard_Load(object sender, EventArgs e) //Maximizing the window
        {
            this.WindowState = FormWindowState.Maximized;
        }
        
        public void CreatePetMessage(string actionMessage) 
        {
            lblPetMessage.Text = actionMessage; 
        }


        private void FormDashboard_Load(object sender, EventArgs e) //Loading the form dashboard
        {
            
            UpdatePetImage("Happy");

            ShowToyImage();

          
       
        }





        private void UpdatePetImage(string mood) //Updating the image based on what type of pet and their mood
        {
            switch (currentPet.PetType)
            {
                case "Dog":
                    if (mood == "Happy")
                        pictureBoxPet.Image = Properties.Resources.Happy_Dog;
                    else if (mood == "Playful")
                        pictureBoxPet.Image = Properties.Resources.Playful_Dog;
                        
                    else
                        pictureBoxPet.Image = Properties.Resources.Sad_Dog;
                    break;
                case "Cat":
                    if (mood == "Happy")
                        pictureBoxPet.Image = Properties.Resources.Happy_Cat;
                    else if (mood == "Playful")
                        pictureBoxPet.Image = Properties.Resources.Playful_Cat;
                    else
                        pictureBoxPet.Image = Properties.Resources.Sad_Cat;
                    break;
                case "Pig":
                    if (mood == "Happy")
                        pictureBoxPet.Image = Properties.Resources.Happy_Pig;
                    else if (mood == "Playful")
                        pictureBoxPet.Image = Properties.Resources.Playful_Pig;
                    else
                        pictureBoxPet.Image = Properties.Resources.Sad_Pig;
                    break;
                case "Hedgehog":
                    if (mood == "Happy")
                        pictureBoxPet.Image = Properties.Resources.Happy_Hedgehog;
                    else if (mood == "Playful")
                        pictureBoxPet.Image = Properties.Resources.Playful_Hedgehog;
                    else
                        pictureBoxPet.Image = Properties.Resources.Sad_Hedgehog;
                    break;
            }
        }
         
        private void btnFeedPet_Click_1(object sender, EventArgs e) //The feed pet button
        {
            lastAction = "Feed Pet";
            byte[] petImageBytes = ImageToByteArray(pictureBoxPet.Image);
            byte[] toyImageBytes = ImageToByteArray(pictureBoxToys.Image);
            currentPet.UpdateMood("Happy", lastAction, petImageBytes, toyImageBytes);

            string actionMessage;

            actionMessage = currentPet.Interaction(lastAction);
            lblPetMessage.Text = actionMessage;

            ShowToyImage(); 
        }

        private void btnCuddlePet_Click(object sender, EventArgs e) //The cuddle pet button
        {
            lastAction = "Cuddle Pet";
            byte[] petImageBytes = ImageToByteArray(pictureBoxPet.Image);
            byte[] toyImageBytes = ImageToByteArray(pictureBoxToys.Image);
            currentPet.UpdateMood("Happy", lastAction, petImageBytes, toyImageBytes);
            UpdatePetImage("Happy");


            string actionMessage;

            actionMessage = currentPet.Interaction(lastAction);
            lblPetMessage.Text = actionMessage;

            HideToyImage();
        }

        private void btnPlayWithPet_Click(object sender, EventArgs e) //The play with pet button
        {
            lastAction = "Play With Pet";
            byte[] petImageBytes = ImageToByteArray(pictureBoxPet.Image);
            byte[] toyImageBytes = ImageToByteArray(pictureBoxToys.Image);
            currentPet.UpdateMood("Happy", lastAction, petImageBytes, toyImageBytes);
            UpdatePetImage("Playful");

            string actionMessage;

            actionMessage = currentPet.Interaction(lastAction);
            lblPetMessage.Text = actionMessage;

            ShowToyImage(); 
        }

        private void ShowToyImage() //Displaying the toy image 
        {
            switch (currentPet.PetType)
            {
                case "Dog":
                    pictureBoxToys.Image = DogToyImage;
                    break;
                case "Cat":
                    pictureBoxToys.Image= CatToyImage;
                    break;
                case "Pig":
                    pictureBoxToys.Image = PigToyImage;
                    break;
                case "Hedgehog":
                    pictureBoxToys.Image = HedgehogToyImage; 
                    break;

            }
        }

        
        private void btnMoodCheckIn_Click(object sender, EventArgs e)
        {
            this.Hide(); //Hides the FormDashboard

            MoodCheckInForm moodCheckInForm = new MoodCheckInForm(this, pictureBoxPet.Image, currentPet);
           
            moodCheckInForm.Show();
        }

        public void CreatePetImage(Image petImage) //Create the pet image
        {
            pictureBoxPet.Image = petImage;
        }

        public void SetPetMessage(string message) //Setting the pet message tex
        {
            lblPetMessage.Text = message;
        }

        public void HideToyImage() //Hide the toy image
        {
            pictureBoxToys.Image = null;
        }
        private void btnViewMoodHistory_Click(object sender, EventArgs e) //Bringing the user into the view mood history form
        {
           if(!MoodCheckInComplete)
            {
                MessageBox.Show("Please complete the Mood Check-In Form before viewing the Mood History", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.Hide();

            ShowToyImage();

            lastAction = SelectedMood;

            ViewMoodHistory moodHistoryForm = new ViewMoodHistory(this,currentPet, pictureBoxPet.Image, pictureBoxToys.Image, lastAction);

            moodHistoryForm.Show();

        }

        private byte[] ImageToByteArray(Image img) //Converting the image into bytes
        {
            if (img == null) return null;
            using (var ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }

        }

        
    }
}
