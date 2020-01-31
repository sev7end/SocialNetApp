namespace SocialApp.OnProfileLoad
{
    partial class MyProfilePage
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NameLastNameLabel = new System.Windows.Forms.Label();
            this.DateOfBirthLabel = new System.Windows.Forms.Label();
            this.EditButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 124);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // NameLastNameLabel
            // 
            this.NameLastNameLabel.AutoSize = true;
            this.NameLastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.NameLastNameLabel.Location = new System.Drawing.Point(171, 22);
            this.NameLastNameLabel.Name = "NameLastNameLabel";
            this.NameLastNameLabel.Size = new System.Drawing.Size(133, 18);
            this.NameLastNameLabel.TabIndex = 1;
            this.NameLastNameLabel.Text = "Name + LastName";
            // 
            // DateOfBirthLabel
            // 
            this.DateOfBirthLabel.AutoSize = true;
            this.DateOfBirthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.DateOfBirthLabel.Location = new System.Drawing.Point(171, 60);
            this.DateOfBirthLabel.Name = "DateOfBirthLabel";
            this.DateOfBirthLabel.Size = new System.Drawing.Size(133, 18);
            this.DateOfBirthLabel.TabIndex = 2;
            this.DateOfBirthLabel.Text = "Name + LastName";
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(174, 104);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(130, 32);
            this.EditButton.TabIndex = 3;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // MyProfilePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 156);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.DateOfBirthLabel);
            this.Controls.Add(this.NameLastNameLabel);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(364, 195);
            this.MinimumSize = new System.Drawing.Size(364, 195);
            this.Name = "MyProfilePage";
            this.Text = "My Profile";
            this.Load += new System.EventHandler(this.MyProfilePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label NameLastNameLabel;
        private System.Windows.Forms.Label DateOfBirthLabel;
        private System.Windows.Forms.Button EditButton;
    }
}