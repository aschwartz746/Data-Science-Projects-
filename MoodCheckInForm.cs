using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Pet_Companion
{
    public partial class MoodCheckInForm : Form
    {
        private Pet currentPet;
        private FormDashboard dashBoard;
        private Image _petImage;
        public MoodCheckInForm(FormDashboard formDashboard, Image petImage, Pet pet) //Bringing in the information from the form dashboard
        {
            InitializeComponent();
            currentPet = pet;
            dashBoard = formDashboard;
            _petImage = petImage;
            lblWelcome.Text = $"Welcome {currentPet.PetName}  ";
            lblMood.Text = " ";
        }

        private void Dashboard_Load(object sender, EventArgs e) //Loading the dashboard
        {
            this.WindowState = FormWindowState.Maximized;
        }
        private void btnLogMood_Click(object sender, EventArgs e) //This method allows users to log in there mood
        {
            if (cmbSelectMood.SelectedItem == null)
            {
                cmbSelectMood.Focus();
                lblMood.Text = "Please select a mood before logging in "; //Prompting users to log their mood before exiting the form
                pictureBoxMood.Image = null;
                return;
            }

            //Variable decarations 
            string selectedMood;
            string petType;
            string message;
            selectedMood = cmbSelectMood.SelectedItem.ToString();



            if (string.IsNullOrEmpty(selectedMood)) //If no mood was selected
            {
                lblMood.Text = "Please select a mood before logging."; //Displays this message
                pictureBoxMood.Image = null; //Clear image if no mood is selected
                return;

            }
            selectedMood = cmbSelectMood.SelectedItem.ToString();
            message = " ";
            petType = currentPet.PetType;
            message = " ";
            Image moodImage = null;


            byte[] petImageBytes = ImageToByteArray(_petImage);





            if (petType == "Dog") //If the pet type is a dog
            {
                if (selectedMood == "Happy" || selectedMood == "Joyful" || selectedMood == "Energetic") //If their happy, joyful, or energetic
                {
                    message = "Yay, your dog is feeling awesome today! "; //Display this message
                    moodImage = Properties.Resources.Happy_Dog; //Display the Happy dog image
                }
                else if (selectedMood == "Playful") //If their feeling playful
                {
                    message = "Yay, lets play a game!"; //Display this message
                    moodImage = Properties.Resources.Playful_Dog; //Display the playful dog image
                }
                else if (selectedMood == "Sad") //If their sad
                {
                    message = "Oh no, your dog is feeling down today. Lets lift up your mood!"; //Display this message
                    moodImage = Properties.Resources.Sad_Dog; //Display the sad dog image 
                }
            }
            else if (petType == "Cat")
            {
                if (selectedMood == "Happy" || selectedMood == "Joyful" || selectedMood == "Energetic")
                {
                    message = "Yay, your Cat is feeling awesome today! ";
                    moodImage = Properties.Resources.Happy_Cat;
                }
                else if (selectedMood == "Playful")
                {
                    message = "Yay, lets play a game!";
                    moodImage = Properties.Resources.Playful_Cat;
                }
                else if (selectedMood == "Sad")
                {
                    message = "Oh no, your cat is feeling down today. Lets lift up your mood!";
                    moodImage = Properties.Resources.Sad_Cat;
                }
            }
            else if (petType == "Pig")
            {
                if (selectedMood == "Happy" || selectedMood == "Joyful" || selectedMood == "Energetic")
                {
                    message = "Yay, your pig is feeling awesome today! ";
                    moodImage = Properties.Resources.Happy_Pig;
                }
                else if (selectedMood == "Playful")
                {
                    message = "Yay, lets play a game!";
                    moodImage = Properties.Resources.Playful_Pig;
                }
                else if (selectedMood == "Sad")
                {
                    message = "Oh no, your pig is feeling down today. Lets lift up your mood";
                    moodImage = Properties.Resources.Sad_Pig;
                }
            }
            else if (petType == "Hedgehog")
            {
                if (selectedMood == "Happy" || selectedMood == "Joyful" || selectedMood == "Energetic")
                {
                    message = "Yay, your hedgehog is feeling awesome today! ";
                    moodImage = Properties.Resources.Happy_Hedgehog;
                }
                else if (selectedMood == "Playful")
                {
                    message = "Lets play fetch";
                    moodImage = Properties.Resources.Playful_Hedgehog;
                }
                else if (selectedMood == "Sad")
                {
                    message = "Oh no, your hedgehog is feeling down today. Lets lift up your mood";
                    moodImage = Properties.Resources.Sad_Hedgehog;
                }
            }

            lblMood.Text = message;
            pictureBoxMood.Image = moodImage;
            _petImage = moodImage;
            dashBoard.SetPetMessage(message);

            if (selectedMood != "Playful") //If playful
            {
                dashBoard.HideToyImage(); //Hide the toy image
            }
            dashBoard.SelectedMood = selectedMood;
            currentPet.UpdateMood(selectedMood, "Mood Check-In", ImageToByteArray(_petImage), null);
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

        private void btnExit_Click(object sender, EventArgs e) //Exiting the MoodCheckInForm and going back to the FormDashboard
        {
            //Transfer the updated image back to the FormDashboard
            if (_petImage != null && dashBoard != null)
            {
                dashBoard.CreatePetImage(_petImage);
            }


            dashBoard.MoodCheckInComplete = true;

            dashBoard.Show();
            this.Hide();
        }

        
        
    }
}


