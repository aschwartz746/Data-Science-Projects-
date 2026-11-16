namespace Pet_Companion
{
    partial class MoodCheckInForm
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
            this.cmbSelectMood = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpCheckMood = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblMood = new System.Windows.Forms.Label();
            this.btnLogMood = new System.Windows.Forms.Button();
            this.pictureBoxMood = new System.Windows.Forms.PictureBox();
            this.grpCheckMood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMood)).BeginInit();
            this.SuspendLayout();
            this.Load += Dashboard_Load;

            // 
            // cmbSelectMood
            // 
            this.cmbSelectMood.FormattingEnabled = true;
            this.cmbSelectMood.Items.AddRange(new object[] {
            "Happy",
            "Joyful",
            "Energetic",
            "Playful",
            "Sad"});
            this.cmbSelectMood.Location = new System.Drawing.Point(322, 192);
            this.cmbSelectMood.Name = "cmbSelectMood";
            this.cmbSelectMood.Size = new System.Drawing.Size(111, 33);
            this.cmbSelectMood.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "How is your pet feeling today?";
            // 
            // grpCheckMood
            // 
            this.grpCheckMood.Controls.Add(this.btnExit);
            this.grpCheckMood.Controls.Add(this.lblWelcome);
            this.grpCheckMood.Controls.Add(this.lblMood);
            this.grpCheckMood.Controls.Add(this.btnLogMood);
            this.grpCheckMood.Controls.Add(this.pictureBoxMood);
            this.grpCheckMood.Controls.Add(this.cmbSelectMood);
            this.grpCheckMood.Controls.Add(this.label2);
            this.grpCheckMood.Location = new System.Drawing.Point(215, 87);
            this.grpCheckMood.Name = "grpCheckMood";
            this.grpCheckMood.Size = new System.Drawing.Size(1587, 1102);
            this.grpCheckMood.TabIndex = 3;
            this.grpCheckMood.TabStop = false;
            this.grpCheckMood.Text = "Mood Check In Form ";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(95, 634);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(269, 294);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Back To Interaction Menu";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(170, 83);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(70, 25);
            this.lblWelcome.TabIndex = 6;
            this.lblWelcome.Text = "label4";
            // 
            // lblMood
            // 
            this.lblMood.AutoSize = true;
            this.lblMood.Location = new System.Drawing.Point(15, 282);
            this.lblMood.Name = "lblMood";
            this.lblMood.Size = new System.Drawing.Size(70, 25);
            this.lblMood.TabIndex = 5;
            this.lblMood.Text = "label3";
            // 
            // btnLogMood
            // 
            this.btnLogMood.Location = new System.Drawing.Point(95, 362);
            this.btnLogMood.Name = "btnLogMood";
            this.btnLogMood.Size = new System.Drawing.Size(269, 250);
            this.btnLogMood.TabIndex = 4;
            this.btnLogMood.Text = "Log Mood";
            this.btnLogMood.UseVisualStyleBackColor = true;
            this.btnLogMood.Click += new System.EventHandler(this.btnLogMood_Click);
            // 
            // pictureBoxMood
            // 
            this.pictureBoxMood.Location = new System.Drawing.Point(520, 68);
            this.pictureBoxMood.Name = "pictureBoxMood";
            this.pictureBoxMood.Size = new System.Drawing.Size(990, 930);
            this.pictureBoxMood.TabIndex = 3;
            this.pictureBoxMood.TabStop = false;
            // 
            // MoodCheckInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1880, 1083);
            this.Controls.Add(this.grpCheckMood);
            this.Controls.Add(this.label1);
            this.Name = "MoodCheckInForm";
            this.Text = "`";
            this.grpCheckMood.ResumeLayout(false);
            this.grpCheckMood.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSelectMood;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpCheckMood;
        private System.Windows.Forms.PictureBox pictureBoxMood;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblMood;
        private System.Windows.Forms.Button btnLogMood;
        private System.Windows.Forms.Button btnExit;

    }
}