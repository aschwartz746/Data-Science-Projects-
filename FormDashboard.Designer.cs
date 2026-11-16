namespace Pet_Companion
{
    partial class FormDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPetName = new System.Windows.Forms.Label();
            this.btnFeedPet = new System.Windows.Forms.Button();
            this.btnPlayWithPet = new System.Windows.Forms.Button();
            this.btnCuddlePet = new System.Windows.Forms.Button();
            this.btnMoodCheckIn = new System.Windows.Forms.Button();
            this.btnViewMoodHistory = new System.Windows.Forms.Button();
            this.lblPetMessage = new System.Windows.Forms.Label();
            this.pictureBoxPet = new System.Windows.Forms.PictureBox();
            this.pictureBoxToys = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxToys)).BeginInit();
            this.SuspendLayout();
            this.Load += Dashboard_Load;

            // 
            // lblPetName
            // 
            this.lblPetName.AutoSize = true;
            this.lblPetName.Location = new System.Drawing.Point(394, 1177);
            this.lblPetName.Name = "lblPetName";
            this.lblPetName.Size = new System.Drawing.Size(70, 25);
            this.lblPetName.TabIndex = 0;
            this.lblPetName.Text = "label1";
            // 
            // btnFeedPet
            // 
            this.btnFeedPet.Location = new System.Drawing.Point(624, 1338);
            this.btnFeedPet.Name = "btnFeedPet";
            this.btnFeedPet.Size = new System.Drawing.Size(226, 107);
            this.btnFeedPet.TabIndex = 2;
            this.btnFeedPet.Text = "Feed Pet";
            this.btnFeedPet.UseVisualStyleBackColor = true;
            this.btnFeedPet.Click += new System.EventHandler(this.btnFeedPet_Click_1);
            // 
            // btnPlayWithPet
            // 
            this.btnPlayWithPet.Location = new System.Drawing.Point(335, 1338);
            this.btnPlayWithPet.Name = "btnPlayWithPet";
            this.btnPlayWithPet.Size = new System.Drawing.Size(226, 107);
            this.btnPlayWithPet.TabIndex = 3;
            this.btnPlayWithPet.Text = "Play With Pet";
            this.btnPlayWithPet.UseVisualStyleBackColor = true;
            this.btnPlayWithPet.Click += new System.EventHandler(this.btnPlayWithPet_Click);
            // 
            // btnCuddlePet
            // 
            this.btnCuddlePet.Location = new System.Drawing.Point(35, 1338);
            this.btnCuddlePet.Name = "btnCuddlePet";
            this.btnCuddlePet.Size = new System.Drawing.Size(226, 107);
            this.btnCuddlePet.TabIndex = 4;
            this.btnCuddlePet.Text = "Cuddle Pet";
            this.btnCuddlePet.UseVisualStyleBackColor = true;
            this.btnCuddlePet.Click += new System.EventHandler(this.btnCuddlePet_Click);
            // 
            // btnMoodCheckIn
            // 
            this.btnMoodCheckIn.Location = new System.Drawing.Point(170, 1505);
            this.btnMoodCheckIn.Name = "btnMoodCheckIn";
            this.btnMoodCheckIn.Size = new System.Drawing.Size(226, 107);
            this.btnMoodCheckIn.TabIndex = 5;
            this.btnMoodCheckIn.Text = "Mood Check In";
            this.btnMoodCheckIn.UseVisualStyleBackColor = true;
            this.btnMoodCheckIn.Click += new System.EventHandler(this.btnMoodCheckIn_Click);
            // 
            // btnViewMoodHistory
            // 
            this.btnViewMoodHistory.Location = new System.Drawing.Point(522, 1505);
            this.btnViewMoodHistory.Name = "btnViewMoodHistory";
            this.btnViewMoodHistory.Size = new System.Drawing.Size(226, 107);
            this.btnViewMoodHistory.TabIndex = 6;
            this.btnViewMoodHistory.Text = "View Mood History";
            this.btnViewMoodHistory.UseVisualStyleBackColor = true;
            this.btnViewMoodHistory.Click += new System.EventHandler(this.btnViewMoodHistory_Click);
            // 
            // lblPetMessage
            // 
            this.lblPetMessage.AutoSize = true;
            this.lblPetMessage.Location = new System.Drawing.Point(394, 1260);
            this.lblPetMessage.Name = "lblPetMessage";
            this.lblPetMessage.Size = new System.Drawing.Size(70, 25);
            this.lblPetMessage.TabIndex = 7;
            this.lblPetMessage.Text = "label2";
            // 
            // pictureBoxPet
            // 
            this.pictureBoxPet.Location = new System.Drawing.Point(12, 37);
            this.pictureBoxPet.Name = "pictureBoxPet";
            this.pictureBoxPet.Size = new System.Drawing.Size(1292, 1105);
            this.pictureBoxPet.TabIndex = 1;
            this.pictureBoxPet.TabStop = false;
            // 
            // pictureBoxToys
            // 
            this.pictureBoxToys.Location = new System.Drawing.Point(1344, 37);
            this.pictureBoxToys.Name = "pictureBoxToys";
            this.pictureBoxToys.Size = new System.Drawing.Size(1205, 1105);
            this.pictureBoxToys.TabIndex = 8;
            this.pictureBoxToys.TabStop = false;
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2884, 1700);
            this.Controls.Add(this.pictureBoxToys);
            this.Controls.Add(this.lblPetMessage);
            this.Controls.Add(this.btnViewMoodHistory);
            this.Controls.Add(this.btnMoodCheckIn);
            this.Controls.Add(this.btnCuddlePet);
            this.Controls.Add(this.btnPlayWithPet);
            this.Controls.Add(this.btnFeedPet);
            this.Controls.Add(this.pictureBoxPet);
            this.Controls.Add(this.lblPetName);
            this.Name = "FormDashboard";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxToys)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPetName;
        private System.Windows.Forms.PictureBox pictureBoxPet;
        private System.Windows.Forms.Button btnFeedPet;
        private System.Windows.Forms.Button btnPlayWithPet;
        private System.Windows.Forms.Button btnCuddlePet;
        private System.Windows.Forms.Button btnMoodCheckIn;
        private System.Windows.Forms.Button btnViewMoodHistory;
        private System.Windows.Forms.Label lblPetMessage;
        private System.Windows.Forms.PictureBox pictureBoxToys;
    }
}