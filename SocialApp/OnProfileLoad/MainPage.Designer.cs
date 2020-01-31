namespace SocialApp.OnProfileLoad
{
    partial class MainPage
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
            this.NameAndLastNameLabel = new System.Windows.Forms.LinkLabel();
            this.CurrentProfilePictureBox = new System.Windows.Forms.PictureBox();
            this.MessagesButton = new System.Windows.Forms.Button();
            this.FriendsButton = new System.Windows.Forms.Button();
            this.RequestsButton = new System.Windows.Forms.Button();
            this.ProfilesGroupBox = new System.Windows.Forms.GroupBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentProfilePictureBox)).BeginInit();
            this.ProfilesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameAndLastNameLabel
            // 
            this.NameAndLastNameLabel.AutoSize = true;
            this.NameAndLastNameLabel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.NameAndLastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameAndLastNameLabel.LinkColor = System.Drawing.Color.White;
            this.NameAndLastNameLabel.Location = new System.Drawing.Point(33, 174);
            this.NameAndLastNameLabel.Name = "NameAndLastNameLabel";
            this.NameAndLastNameLabel.Size = new System.Drawing.Size(120, 18);
            this.NameAndLastNameLabel.TabIndex = 0;
            this.NameAndLastNameLabel.TabStop = true;
            this.NameAndLastNameLabel.Text = "Name LastName";
            this.NameAndLastNameLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.NameAndLastNameLabel_LinkClicked);
            // 
            // CurrentProfilePictureBox
            // 
            this.CurrentProfilePictureBox.Location = new System.Drawing.Point(12, 12);
            this.CurrentProfilePictureBox.Name = "CurrentProfilePictureBox";
            this.CurrentProfilePictureBox.Size = new System.Drawing.Size(160, 147);
            this.CurrentProfilePictureBox.TabIndex = 1;
            this.CurrentProfilePictureBox.TabStop = false;
            // 
            // MessagesButton
            // 
            this.MessagesButton.BackColor = System.Drawing.SystemColors.Control;
            this.MessagesButton.Location = new System.Drawing.Point(5, 233);
            this.MessagesButton.Name = "MessagesButton";
            this.MessagesButton.Size = new System.Drawing.Size(167, 29);
            this.MessagesButton.TabIndex = 3;
            this.MessagesButton.Text = "Messages";
            this.MessagesButton.UseVisualStyleBackColor = false;
            this.MessagesButton.Click += new System.EventHandler(this.MessagesButton_Click);
            // 
            // FriendsButton
            // 
            this.FriendsButton.BackColor = System.Drawing.SystemColors.Control;
            this.FriendsButton.Location = new System.Drawing.Point(5, 303);
            this.FriendsButton.Name = "FriendsButton";
            this.FriendsButton.Size = new System.Drawing.Size(167, 29);
            this.FriendsButton.TabIndex = 4;
            this.FriendsButton.Text = "Friends";
            this.FriendsButton.UseVisualStyleBackColor = false;
            // 
            // RequestsButton
            // 
            this.RequestsButton.BackColor = System.Drawing.SystemColors.Control;
            this.RequestsButton.Location = new System.Drawing.Point(5, 268);
            this.RequestsButton.Name = "RequestsButton";
            this.RequestsButton.Size = new System.Drawing.Size(167, 29);
            this.RequestsButton.TabIndex = 5;
            this.RequestsButton.Text = "Requests";
            this.RequestsButton.UseVisualStyleBackColor = false;
            // 
            // ProfilesGroupBox
            // 
            this.ProfilesGroupBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ProfilesGroupBox.Controls.Add(this.tableLayoutPanel1);
            this.ProfilesGroupBox.Controls.Add(this.button1);
            this.ProfilesGroupBox.Controls.Add(this.label1);
            this.ProfilesGroupBox.Controls.Add(this.textBox1);
            this.ProfilesGroupBox.Controls.Add(this.vScrollBar1);
            this.ProfilesGroupBox.Location = new System.Drawing.Point(178, -2);
            this.ProfilesGroupBox.Name = "ProfilesGroupBox";
            this.ProfilesGroupBox.Size = new System.Drawing.Size(1017, 680);
            this.ProfilesGroupBox.TabIndex = 2;
            this.ProfilesGroupBox.TabStop = false;
            this.ProfilesGroupBox.Text = "Profiles";
            this.ProfilesGroupBox.Enter += new System.EventHandler(this.ProfilesGroupBox_Enter);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(971, 10);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 604);
            this.vScrollBar1.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(270, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(434, 20);
            this.textBox1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Search:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(710, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 20);
            this.button1.TabIndex = 15;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.61637F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.38364F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 258F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 45);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.30201F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.69798F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(962, 596);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1175, 641);
            this.Controls.Add(this.RequestsButton);
            this.Controls.Add(this.FriendsButton);
            this.Controls.Add(this.MessagesButton);
            this.Controls.Add(this.ProfilesGroupBox);
            this.Controls.Add(this.CurrentProfilePictureBox);
            this.Controls.Add(this.NameAndLastNameLabel);
            this.Name = "MainPage";
            this.Text = "Social App";
            this.Load += new System.EventHandler(this.MainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CurrentProfilePictureBox)).EndInit();
            this.ProfilesGroupBox.ResumeLayout(false);
            this.ProfilesGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel NameAndLastNameLabel;
        private System.Windows.Forms.PictureBox CurrentProfilePictureBox;
        private System.Windows.Forms.Button MessagesButton;
        private System.Windows.Forms.Button FriendsButton;
        private System.Windows.Forms.Button RequestsButton;
        private System.Windows.Forms.GroupBox ProfilesGroupBox;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}