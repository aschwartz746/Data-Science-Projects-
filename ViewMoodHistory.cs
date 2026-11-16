using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Pet_Companion
{
    public partial class ViewMoodHistory : Form
    {
        //Variable declarations 
        private readonly Pet _currentPet;
        private readonly FormDashboard _dashBoard;
        private readonly Image _petImage;
        private readonly Image _toyImage;
        private readonly string _lastAction;

        // Generating the Pet list
        public List<Pet> pet = new List<Pet>();

        
        private void Dashboard_Load(object sender, EventArgs e) //Maximizing the window
        {
            this.WindowState = FormWindowState.Maximized;
        }
        public ViewMoodHistory(FormDashboard owner, Pet currentPet, Image petImage, Image toyImage, string lastAction) //Calling in our information with the ViewMoodHistory constructor
        {
            InitializeComponent();
            Owner = owner;
            _dashBoard = owner;
            _currentPet = currentPet;
            _petImage = petImage;
            _toyImage = toyImage;
            _lastAction = lastAction;



            Load += ViewMoodHistoryForm_Load;

            LoadSummary();

        }



        private void ViewMoodHistoryForm_Load(object sender, EventArgs e) 
        {
            string message = _currentPet.Interaction(_lastAction); //Getting the mood data
            
        }
        

        private void InsertToDatabase(Pet pet, string mood, byte[] moodImage, string action, byte[] toyImage) //Inserting the data into the database
        {
            string connString = ConfigurationManager.ConnectionStrings["PetDb"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                SqlTransaction transaction = conn.BeginTransaction();
                try
                {
                    // Insert into Pet table
                    SqlCommand cmdPet = new SqlCommand(@"
                   INSERT INTO Pets (PetName, Mood, MoodImage, Action, ToyImage)
                   VALUES (@PetName, @Mood, @MoodImage, @Action, @ToyImage);", conn, transaction);

                    //Adding in the parameters
                    cmdPet.Parameters.AddWithValue("@PetName", pet.PetName);
                    cmdPet.Parameters.AddWithValue("@Mood", mood);
                    cmdPet.Parameters.AddWithValue("@MoodImage", moodImage);
                    cmdPet.Parameters.AddWithValue("@Action", action);
                    cmdPet.Parameters.AddWithValue("@ToyImage", toyImage);


                    
                    cmdPet.ExecuteNonQuery();

                    transaction.Commit(); //Commit the transaction to save data
                    MessageBox.Show("Mood Logged successfully!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                { //If there is an error
                    transaction.Rollback();
                    MessageBox.Show($"Error with the database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
        

        private byte[] ConvertImageToBytes(Image img) //Converting the image into bytes
        {
            if (img == null) return null;
            using (var ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }

        }

        private void btnBackToFormDashboard_Click(object sender, EventArgs e) //This method takes you back to your FormDashboard
        {
            try
            {
                this.Hide();

                _dashBoard.Show();

            }
            catch
            {
                MessageBox.Show($"Error");
            }
        }





        private void LoadSummary() //Loading in the database
        {
            string connStr = ConfigurationManager.ConnectionStrings["PetDb"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                //Join combines two tables based on the primary key and the foreign key
                string query = @"
             SELECT   
                 PetName,
                 Mood,
                 MoodImage,
                 Action,
                 ToyImage
             FROM Pets 
             ORDER BY PetID DESC;";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                DataTable table = new DataTable();
                adapter.Fill(table);

                dgvMoodHistory.DataSource = table;
                dgvMoodHistory.Refresh();
            }
        }

        private void btnDisplayPetInformation_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] moodImageBytes = ConvertImageToBytes(_petImage);
                byte[] toyImageBytes = ConvertImageToBytes(_toyImage);

                InsertToDatabase(_currentPet, _currentPet.Mood, moodImageBytes, _lastAction, toyImageBytes);


                LoadSummary();

               



            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error: {ex.Message}");
            }
        }



        private void dgvMoodHistory_CellContentClick(object sender, DataGridViewCellEventArgs e) //This method is used for adjusting the size of the images in the database
        {
            foreach (DataGridViewColumn column in dgvMoodHistory.Columns)
            {
                if (column.Name == "MoodImage" || column.Name == "ToyImage")
                {
                    DataGridViewImageColumn imageColumn = (DataGridViewImageColumn)column;
                    imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
                    imageColumn.Width = 400;
                }
                else
                {
                    column.Width = 130;
                }


            }
            dgvMoodHistory.RowTemplate.Height = 400;
        }

        
    }
}