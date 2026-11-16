namespace Pet_Companion
{
    partial class ViewMoodHistory
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
            this.dgvMoodHistory = new System.Windows.Forms.DataGridView();
            this.btnBackToFormDashboard = new System.Windows.Forms.Button();
            this.btnDisplayPetInformation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMoodHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMoodHistory
            // 
            this.dgvMoodHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMoodHistory.Location = new System.Drawing.Point(12, 90);
            this.dgvMoodHistory.Name = "dgvMoodHistory";
            this.dgvMoodHistory.RowHeadersWidth = 82;
            this.dgvMoodHistory.RowTemplate.Height = 33;
            this.dgvMoodHistory.Size = new System.Drawing.Size(1765, 1215);
            this.dgvMoodHistory.TabIndex = 0;
            this.dgvMoodHistory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMoodHistory_CellContentClick);
            // 
            // btnBackToFormDashboard
            // 
            this.btnBackToFormDashboard.Location = new System.Drawing.Point(244, 1399);
            this.btnBackToFormDashboard.Name = "btnBackToFormDashboard";
            this.btnBackToFormDashboard.Size = new System.Drawing.Size(414, 282);
            this.btnBackToFormDashboard.TabIndex = 2;
            this.btnBackToFormDashboard.Text = "Back To Form Dashboard";
            this.btnBackToFormDashboard.UseVisualStyleBackColor = true;
            this.btnBackToFormDashboard.Click += new System.EventHandler(this.btnBackToFormDashboard_Click);
            // 
            // btnDisplayPetInformation
            // 
            this.btnDisplayPetInformation.Location = new System.Drawing.Point(801, 1408);
            this.btnDisplayPetInformation.Name = "btnDisplayPetInformation";
            this.btnDisplayPetInformation.Size = new System.Drawing.Size(415, 273);
            this.btnDisplayPetInformation.TabIndex = 3;
            this.btnDisplayPetInformation.Text = "Display Pet Information";
            this.btnDisplayPetInformation.UseVisualStyleBackColor = true;
            this.btnDisplayPetInformation.Click += new System.EventHandler(this.btnDisplayPetInformation_Click);
            // 
            // ViewMoodHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1900, 1759);
            this.Controls.Add(this.btnDisplayPetInformation);
            this.Controls.Add(this.btnBackToFormDashboard);
            this.Controls.Add(this.dgvMoodHistory);
            this.Name = "ViewMoodHistory";
            this.Text = "ViewMoodHistory";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMoodHistory)).EndInit();
            this.ResumeLayout(false);
            this.Load += Dashboard_Load;

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMoodHistory;
        private System.Windows.Forms.Button btnBackToFormDashboard;
        private System.Windows.Forms.Button btnDisplayPetInformation;
    }
}