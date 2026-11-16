namespace Pet_Companion
{
    partial class WelcomeScreen
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
            this.grpPetSelection = new System.Windows.Forms.GroupBox();
            this.pictureBoxChoice = new System.Windows.Forms.PictureBox();
            this.rdoHedgehog = new System.Windows.Forms.RadioButton();
            this.rdoPig = new System.Windows.Forms.RadioButton();
            this.rdoCat = new System.Windows.Forms.RadioButton();
            this.rdoDog = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpCustomizeDog = new System.Windows.Forms.GroupBox();
            this.pictureBoxDogToy = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbFavoriteDogToy = new System.Windows.Forms.ComboBox();
            this.txtDogName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.grpCustomizeCat = new System.Windows.Forms.GroupBox();
            this.pictureBoxCatToy = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbFavoriteCatToy = new System.Windows.Forms.ComboBox();
            this.txtCatName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grpCustomizePig = new System.Windows.Forms.GroupBox();
            this.pictureBoxPigToy = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbFavoritePigToy = new System.Windows.Forms.ComboBox();
            this.txtPigName = new System.Windows.Forms.TextBox();
            this.grpCustomizeHedgehog = new System.Windows.Forms.GroupBox();
            this.pictureBoxHedgehogToy = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbFavoriteHedgehogToy = new System.Windows.Forms.ComboBox();
            this.txtHedgehogName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.grpSubmit = new System.Windows.Forms.GroupBox();
            this.grpPetSelection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChoice)).BeginInit();
            this.grpCustomizeDog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDogToy)).BeginInit();
            this.grpCustomizeCat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCatToy)).BeginInit();
            this.grpCustomizePig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPigToy)).BeginInit();
            this.grpCustomizeHedgehog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHedgehogToy)).BeginInit();
            this.grpSubmit.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPetSelection
            // 
            this.grpPetSelection.BackColor = System.Drawing.SystemColors.Info;
            this.grpPetSelection.Controls.Add(this.pictureBoxChoice);
            this.grpPetSelection.Controls.Add(this.rdoHedgehog);
            this.grpPetSelection.Controls.Add(this.rdoPig);
            this.grpPetSelection.Controls.Add(this.rdoCat);
            this.grpPetSelection.Controls.Add(this.rdoDog);
            this.grpPetSelection.Controls.Add(this.label2);
            this.grpPetSelection.Controls.Add(this.label1);
            this.grpPetSelection.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grpPetSelection.Location = new System.Drawing.Point(1012, 12);
            this.grpPetSelection.Name = "grpPetSelection";
            this.grpPetSelection.Size = new System.Drawing.Size(780, 755);
            this.grpPetSelection.TabIndex = 0;
            this.grpPetSelection.TabStop = false;
            this.grpPetSelection.Text = " Pet Selection";
            // 
            // pictureBoxChoice
            // 
            this.pictureBoxChoice.Location = new System.Drawing.Point(175, 126);
            this.pictureBoxChoice.Name = "pictureBoxChoice";
            this.pictureBoxChoice.Size = new System.Drawing.Size(599, 583);
            this.pictureBoxChoice.TabIndex = 11;
            this.pictureBoxChoice.TabStop = false;
            // 
            // rdoHedgehog
            // 
            this.rdoHedgehog.AutoSize = true;
            this.rdoHedgehog.Location = new System.Drawing.Point(27, 337);
            this.rdoHedgehog.Name = "rdoHedgehog";
            this.rdoHedgehog.Size = new System.Drawing.Size(142, 29);
            this.rdoHedgehog.TabIndex = 10;
            this.rdoHedgehog.TabStop = true;
            this.rdoHedgehog.Text = "Hedgehog";
            this.rdoHedgehog.UseVisualStyleBackColor = true;
            this.rdoHedgehog.CheckedChanged += new System.EventHandler(this.rdoHedgehog_CheckedChanged);
            // 
            // rdoPig
            // 
            this.rdoPig.AutoSize = true;
            this.rdoPig.Location = new System.Drawing.Point(27, 276);
            this.rdoPig.Name = "rdoPig";
            this.rdoPig.Size = new System.Drawing.Size(74, 29);
            this.rdoPig.TabIndex = 9;
            this.rdoPig.TabStop = true;
            this.rdoPig.Text = "Pig";
            this.rdoPig.UseVisualStyleBackColor = true;
            this.rdoPig.CheckedChanged += new System.EventHandler(this.rdoPig_CheckedChanged);
            // 
            // rdoCat
            // 
            this.rdoCat.AutoSize = true;
            this.rdoCat.Location = new System.Drawing.Point(27, 217);
            this.rdoCat.Name = "rdoCat";
            this.rdoCat.Size = new System.Drawing.Size(76, 29);
            this.rdoCat.TabIndex = 8;
            this.rdoCat.TabStop = true;
            this.rdoCat.Text = "Cat";
            this.rdoCat.UseVisualStyleBackColor = true;
            this.rdoCat.CheckedChanged += new System.EventHandler(this.rdoCat_CheckedChanged);
            // 
            // rdoDog
            // 
            this.rdoDog.AutoSize = true;
            this.rdoDog.Location = new System.Drawing.Point(21, 164);
            this.rdoDog.Name = "rdoDog";
            this.rdoDog.Size = new System.Drawing.Size(82, 29);
            this.rdoDog.TabIndex = 7;
            this.rdoDog.TabStop = true;
            this.rdoDog.Text = "Dog";
            this.rdoDog.UseVisualStyleBackColor = true;
            this.rdoDog.CheckedChanged += new System.EventHandler(this.rdoDog_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(391, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Click on the pet that you want to create!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(28, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(541, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = " Welcome to Happy Tails - Your Digital Pet Companion!";
            // 
            // grpCustomizeDog
            // 
            this.grpCustomizeDog.BackColor = System.Drawing.SystemColors.Menu;
            this.grpCustomizeDog.Controls.Add(this.pictureBoxDogToy);
            this.grpCustomizeDog.Controls.Add(this.label4);
            this.grpCustomizeDog.Controls.Add(this.cmbFavoriteDogToy);
            this.grpCustomizeDog.Controls.Add(this.txtDogName);
            this.grpCustomizeDog.Controls.Add(this.label3);
            this.grpCustomizeDog.Location = new System.Drawing.Point(17, 93);
            this.grpCustomizeDog.Name = "grpCustomizeDog";
            this.grpCustomizeDog.Size = new System.Drawing.Size(924, 498);
            this.grpCustomizeDog.TabIndex = 1;
            this.grpCustomizeDog.TabStop = false;
            this.grpCustomizeDog.Text = "Customize Dog";
            // 
            // pictureBoxDogToy
            // 
            this.pictureBoxDogToy.Location = new System.Drawing.Point(456, 30);
            this.pictureBoxDogToy.Name = "pictureBoxDogToy";
            this.pictureBoxDogToy.Size = new System.Drawing.Size(400, 412);
            this.pictureBoxDogToy.TabIndex = 4;
            this.pictureBoxDogToy.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pick Your Favorite Toy:";
            // 
            // cmbFavoriteDogToy
            // 
            this.cmbFavoriteDogToy.FormattingEnabled = true;
            this.cmbFavoriteDogToy.Items.AddRange(new object[] {
            "Bone",
            "Ball",
            "Dog Rope"});
            this.cmbFavoriteDogToy.Location = new System.Drawing.Point(288, 162);
            this.cmbFavoriteDogToy.Name = "cmbFavoriteDogToy";
            this.cmbFavoriteDogToy.Size = new System.Drawing.Size(121, 33);
            this.cmbFavoriteDogToy.TabIndex = 2;
            this.cmbFavoriteDogToy.SelectedIndexChanged += new System.EventHandler(this.cmbFavoriteDogToy_SelectedIndexChanged);
            // 
            // txtDogName
            // 
            this.txtDogName.Location = new System.Drawing.Point(288, 96);
            this.txtDogName.Name = "txtDogName";
            this.txtDogName.Size = new System.Drawing.Size(121, 31);
            this.txtDogName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name Your Dog:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSubmit.Location = new System.Drawing.Point(83, 66);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(298, 125);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // grpCustomizeCat
            // 
            this.grpCustomizeCat.BackColor = System.Drawing.SystemColors.Menu;
            this.grpCustomizeCat.Controls.Add(this.pictureBoxCatToy);
            this.grpCustomizeCat.Controls.Add(this.label5);
            this.grpCustomizeCat.Controls.Add(this.cmbFavoriteCatToy);
            this.grpCustomizeCat.Controls.Add(this.txtCatName);
            this.grpCustomizeCat.Controls.Add(this.label6);
            this.grpCustomizeCat.Location = new System.Drawing.Point(17, 1044);
            this.grpCustomizeCat.Name = "grpCustomizeCat";
            this.grpCustomizeCat.Size = new System.Drawing.Size(1122, 660);
            this.grpCustomizeCat.TabIndex = 5;
            this.grpCustomizeCat.TabStop = false;
            this.grpCustomizeCat.Text = "Customize Cat";
            // 
            // pictureBoxCatToy
            // 
            this.pictureBoxCatToy.Location = new System.Drawing.Point(479, 30);
            this.pictureBoxCatToy.Name = "pictureBoxCatToy";
            this.pictureBoxCatToy.Size = new System.Drawing.Size(575, 565);
            this.pictureBoxCatToy.TabIndex = 5;
            this.pictureBoxCatToy.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(237, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Pick Your Favorite Toy:";
            // 
            // cmbFavoriteCatToy
            // 
            this.cmbFavoriteCatToy.FormattingEnabled = true;
            this.cmbFavoriteCatToy.Items.AddRange(new object[] {
            "Feather",
            "Yarn",
            "Laser Pointer"});
            this.cmbFavoriteCatToy.Location = new System.Drawing.Point(288, 162);
            this.cmbFavoriteCatToy.Name = "cmbFavoriteCatToy";
            this.cmbFavoriteCatToy.Size = new System.Drawing.Size(121, 33);
            this.cmbFavoriteCatToy.TabIndex = 2;
            this.cmbFavoriteCatToy.SelectedIndexChanged += new System.EventHandler(this.cmbFavoriteCatToy_SelectedIndexChanged_1);
            // 
            // txtCatName
            // 
            this.txtCatName.Location = new System.Drawing.Point(288, 96);
            this.txtCatName.Name = "txtCatName";
            this.txtCatName.Size = new System.Drawing.Size(121, 31);
            this.txtCatName.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Name Your Cat:";
            // 
            // grpCustomizePig
            // 
            this.grpCustomizePig.BackColor = System.Drawing.SystemColors.Menu;
            this.grpCustomizePig.Controls.Add(this.pictureBoxPigToy);
            this.grpCustomizePig.Controls.Add(this.label8);
            this.grpCustomizePig.Controls.Add(this.label7);
            this.grpCustomizePig.Controls.Add(this.cmbFavoritePigToy);
            this.grpCustomizePig.Controls.Add(this.txtPigName);
            this.grpCustomizePig.Location = new System.Drawing.Point(1807, 37);
            this.grpCustomizePig.Name = "grpCustomizePig";
            this.grpCustomizePig.Size = new System.Drawing.Size(1050, 591);
            this.grpCustomizePig.TabIndex = 5;
            this.grpCustomizePig.TabStop = false;
            this.grpCustomizePig.Text = "Customize Pig";
            // 
            // pictureBoxPigToy
            // 
            this.pictureBoxPigToy.Location = new System.Drawing.Point(493, 30);
            this.pictureBoxPigToy.Name = "pictureBoxPigToy";
            this.pictureBoxPigToy.Size = new System.Drawing.Size(520, 524);
            this.pictureBoxPigToy.TabIndex = 6;
            this.pictureBoxPigToy.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(80, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 25);
            this.label8.TabIndex = 5;
            this.label8.Text = "Name Your Pig:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(237, 25);
            this.label7.TabIndex = 3;
            this.label7.Text = "Pick Your Favorite Toy:";
            // 
            // cmbFavoritePigToy
            // 
            this.cmbFavoritePigToy.FormattingEnabled = true;
            this.cmbFavoritePigToy.Items.AddRange(new object[] {
            "Pig Rope",
            "Bell",
            "Stuffed Carrot"});
            this.cmbFavoritePigToy.Location = new System.Drawing.Point(288, 162);
            this.cmbFavoritePigToy.Name = "cmbFavoritePigToy";
            this.cmbFavoritePigToy.Size = new System.Drawing.Size(121, 33);
            this.cmbFavoritePigToy.TabIndex = 2;
            this.cmbFavoritePigToy.SelectedIndexChanged += new System.EventHandler(this.cmbFavoritePigToy_SelectedIndexChanged);
            // 
            // txtPigName
            // 
            this.txtPigName.Location = new System.Drawing.Point(288, 96);
            this.txtPigName.Name = "txtPigName";
            this.txtPigName.Size = new System.Drawing.Size(121, 31);
            this.txtPigName.TabIndex = 1;
            // 
            // grpCustomizeHedgehog
            // 
            this.grpCustomizeHedgehog.BackColor = System.Drawing.SystemColors.Menu;
            this.grpCustomizeHedgehog.Controls.Add(this.pictureBoxHedgehogToy);
            this.grpCustomizeHedgehog.Controls.Add(this.label9);
            this.grpCustomizeHedgehog.Controls.Add(this.cmbFavoriteHedgehogToy);
            this.grpCustomizeHedgehog.Controls.Add(this.txtHedgehogName);
            this.grpCustomizeHedgehog.Controls.Add(this.label10);
            this.grpCustomizeHedgehog.Location = new System.Drawing.Point(1727, 1044);
            this.grpCustomizeHedgehog.Name = "grpCustomizeHedgehog";
            this.grpCustomizeHedgehog.Size = new System.Drawing.Size(1107, 668);
            this.grpCustomizeHedgehog.TabIndex = 5;
            this.grpCustomizeHedgehog.TabStop = false;
            this.grpCustomizeHedgehog.Text = "Customize Hedgehog";
            // 
            // pictureBoxHedgehogToy
            // 
            this.pictureBoxHedgehogToy.Location = new System.Drawing.Point(454, 30);
            this.pictureBoxHedgehogToy.Name = "pictureBoxHedgehogToy";
            this.pictureBoxHedgehogToy.Size = new System.Drawing.Size(584, 578);
            this.pictureBoxHedgehogToy.TabIndex = 4;
            this.pictureBoxHedgehogToy.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(237, 25);
            this.label9.TabIndex = 3;
            this.label9.Text = "Pick Your Favorite Toy:";
            // 
            // cmbFavoriteHedgehogToy
            // 
            this.cmbFavoriteHedgehogToy.FormattingEnabled = true;
            this.cmbFavoriteHedgehogToy.Items.AddRange(new object[] {
            "Insect Toy",
            "Mini Ball",
            "Plush Worm"});
            this.cmbFavoriteHedgehogToy.Location = new System.Drawing.Point(288, 162);
            this.cmbFavoriteHedgehogToy.Name = "cmbFavoriteHedgehogToy";
            this.cmbFavoriteHedgehogToy.Size = new System.Drawing.Size(121, 33);
            this.cmbFavoriteHedgehogToy.TabIndex = 2;
            this.cmbFavoriteHedgehogToy.SelectedIndexChanged += new System.EventHandler(this.cmbFavoriteHedgehogToy_SelectedIndexChanged);
            // 
            // txtHedgehogName
            // 
            this.txtHedgehogName.Location = new System.Drawing.Point(288, 96);
            this.txtHedgehogName.Name = "txtHedgehogName";
            this.txtHedgehogName.Size = new System.Drawing.Size(121, 31);
            this.txtHedgehogName.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(231, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "Name Your Hedgehog:";
            // 
            // grpSubmit
            // 
            this.grpSubmit.BackColor = System.Drawing.SystemColors.Control;
            this.grpSubmit.Controls.Add(this.btnSubmit);
            this.grpSubmit.Location = new System.Drawing.Point(1172, 821);
            this.grpSubmit.Name = "grpSubmit";
            this.grpSubmit.Size = new System.Drawing.Size(482, 248);
            this.grpSubmit.TabIndex = 6;
            this.grpSubmit.TabStop = false;
            // 
            // WelcomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(2884, 1759);
            this.Controls.Add(this.grpSubmit);
            this.Controls.Add(this.grpCustomizeHedgehog);
            this.Controls.Add(this.grpCustomizePig);
            this.Controls.Add(this.grpCustomizeCat);
            this.Controls.Add(this.grpCustomizeDog);
            this.Controls.Add(this.grpPetSelection);
            this.Name = "WelcomeScreen";
            this.Text = "Form1";
            this.grpPetSelection.ResumeLayout(false);
            this.grpPetSelection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChoice)).EndInit();
            this.grpCustomizeDog.ResumeLayout(false);
            this.grpCustomizeDog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDogToy)).EndInit();
            this.grpCustomizeCat.ResumeLayout(false);
            this.grpCustomizeCat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCatToy)).EndInit();
            this.grpCustomizePig.ResumeLayout(false);
            this.grpCustomizePig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPigToy)).EndInit();
            this.grpCustomizeHedgehog.ResumeLayout(false);
            this.grpCustomizeHedgehog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHedgehogToy)).EndInit();
            this.grpSubmit.ResumeLayout(false);
            this.ResumeLayout(false);
            this.Load += Dashboard_Load;

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPetSelection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpCustomizeDog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbFavoriteDogToy;
        private System.Windows.Forms.TextBox txtDogName;
        private System.Windows.Forms.GroupBox grpCustomizeCat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbFavoriteCatToy;
        private System.Windows.Forms.TextBox txtCatName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grpCustomizePig;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbFavoritePigToy;
        private System.Windows.Forms.TextBox txtPigName;
        private System.Windows.Forms.GroupBox grpCustomizeHedgehog;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbFavoriteHedgehogToy;
        private System.Windows.Forms.TextBox txtHedgehogName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rdoDog;
        private System.Windows.Forms.RadioButton rdoHedgehog;
        private System.Windows.Forms.RadioButton rdoPig;
        private System.Windows.Forms.RadioButton rdoCat;
        private System.Windows.Forms.GroupBox grpSubmit;
        private System.Windows.Forms.PictureBox pictureBoxDogToy;
        private System.Windows.Forms.PictureBox pictureBoxCatToy;
        private System.Windows.Forms.PictureBox pictureBoxPigToy;
        private System.Windows.Forms.PictureBox pictureBoxHedgehogToy;
        private System.Windows.Forms.PictureBox pictureBoxChoice;
    }
}

