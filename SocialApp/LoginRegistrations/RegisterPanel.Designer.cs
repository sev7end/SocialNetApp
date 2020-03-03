using MetroSet_UI.Controls;
using System.Windows.Forms;

namespace SocialApp.LoginRegistrations
{
    partial class RegisterPanel
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
            this.button1 = new MetroSet_UI.Controls.MetroSetButton();
            this.LastNameBox = new MetroSet_UI.Controls.MetroSetTextBox();
            this.NameBox = new MetroSet_UI.Controls.MetroSetTextBox();
            this.PassBox = new MetroSet_UI.Controls.MetroSetTextBox();
            this.UserBox = new MetroSet_UI.Controls.MetroSetTextBox();
            this.PassVBox = new MetroSet_UI.Controls.MetroSetTextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FileLocation = new MetroSet_UI.Controls.MetroSetTextBox();
            this.BrowseButton = new MetroSet_UI.Controls.MetroSetButton();
            this.metroSetButton1 = new MetroSet_UI.Controls.MetroSetButton();
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.GenderCombo = new MetroSet_UI.Controls.MetroSetComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.button1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.button1.DisabledForeColor = System.Drawing.Color.Gray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.button1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.button1.HoverTextColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(157, 500);
            this.button1.Name = "button1";
            this.button1.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.button1.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.button1.NormalTextColor = System.Drawing.Color.White;
            this.button1.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.button1.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.button1.PressTextColor = System.Drawing.Color.White;
            this.button1.Size = new System.Drawing.Size(124, 42);
            this.button1.Style = MetroSet_UI.Design.Style.Light;
            this.button1.StyleManager = null;
            this.button1.TabIndex = 7;
            this.button1.Text = "Register";
            this.button1.ThemeAuthor = "Narwin";
            this.button1.ThemeName = "MetroLite";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LastNameBox
            // 
            this.LastNameBox.AutoCompleteCustomSource = null;
            this.LastNameBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.LastNameBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.LastNameBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.LastNameBox.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.LastNameBox.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.LastNameBox.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.LastNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameBox.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.LastNameBox.Image = null;
            this.LastNameBox.Lines = null;
            this.LastNameBox.Location = new System.Drawing.Point(24, 238);
            this.LastNameBox.MaxLength = 32767;
            this.LastNameBox.Multiline = false;
            this.LastNameBox.Name = "LastNameBox";
            this.LastNameBox.ReadOnly = false;
            this.LastNameBox.Size = new System.Drawing.Size(406, 29);
            this.LastNameBox.Style = MetroSet_UI.Design.Style.Light;
            this.LastNameBox.StyleManager = null;
            this.LastNameBox.TabIndex = 6;
            this.LastNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.LastNameBox.ThemeAuthor = "Narwin";
            this.LastNameBox.ThemeName = "MetroLite";
            this.LastNameBox.UseSystemPasswordChar = false;
            this.LastNameBox.WatermarkText = "Surname";
            // 
            // NameBox
            // 
            this.NameBox.AutoCompleteCustomSource = null;
            this.NameBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.NameBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.NameBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.NameBox.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.NameBox.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.NameBox.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.NameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameBox.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.NameBox.Image = null;
            this.NameBox.Lines = null;
            this.NameBox.Location = new System.Drawing.Point(24, 191);
            this.NameBox.MaxLength = 32767;
            this.NameBox.Multiline = false;
            this.NameBox.Name = "NameBox";
            this.NameBox.ReadOnly = false;
            this.NameBox.Size = new System.Drawing.Size(406, 29);
            this.NameBox.Style = MetroSet_UI.Design.Style.Light;
            this.NameBox.StyleManager = null;
            this.NameBox.TabIndex = 5;
            this.NameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.NameBox.ThemeAuthor = "Narwin";
            this.NameBox.ThemeName = "MetroLite";
            this.NameBox.UseSystemPasswordChar = false;
            this.NameBox.WatermarkText = "Name";
            // 
            // PassBox
            // 
            this.PassBox.AutoCompleteCustomSource = null;
            this.PassBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.PassBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.PassBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.PassBox.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.PassBox.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.PassBox.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.PassBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassBox.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.PassBox.Image = null;
            this.PassBox.Lines = null;
            this.PassBox.Location = new System.Drawing.Point(24, 404);
            this.PassBox.MaxLength = 32767;
            this.PassBox.Multiline = false;
            this.PassBox.Name = "PassBox";
            this.PassBox.ReadOnly = false;
            this.PassBox.Size = new System.Drawing.Size(406, 29);
            this.PassBox.Style = MetroSet_UI.Design.Style.Light;
            this.PassBox.StyleManager = null;
            this.PassBox.TabIndex = 11;
            this.PassBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PassBox.ThemeAuthor = "Narwin";
            this.PassBox.ThemeName = "MetroLite";
            this.PassBox.UseSystemPasswordChar = true;
            this.PassBox.WatermarkText = "Password";
            // 
            // UserBox
            // 
            this.UserBox.AutoCompleteCustomSource = null;
            this.UserBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.UserBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.UserBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.UserBox.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.UserBox.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.UserBox.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.UserBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserBox.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.UserBox.Image = null;
            this.UserBox.Lines = null;
            this.UserBox.Location = new System.Drawing.Point(24, 283);
            this.UserBox.MaxLength = 32767;
            this.UserBox.Multiline = false;
            this.UserBox.Name = "UserBox";
            this.UserBox.ReadOnly = false;
            this.UserBox.Size = new System.Drawing.Size(406, 29);
            this.UserBox.Style = MetroSet_UI.Design.Style.Light;
            this.UserBox.StyleManager = null;
            this.UserBox.TabIndex = 10;
            this.UserBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.UserBox.ThemeAuthor = "Narwin";
            this.UserBox.ThemeName = "MetroLite";
            this.UserBox.UseSystemPasswordChar = false;
            this.UserBox.WatermarkText = "Username";
            // 
            // PassVBox
            // 
            this.PassVBox.AutoCompleteCustomSource = null;
            this.PassVBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.PassVBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.PassVBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.PassVBox.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.PassVBox.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.PassVBox.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.PassVBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassVBox.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.PassVBox.Image = null;
            this.PassVBox.Lines = null;
            this.PassVBox.Location = new System.Drawing.Point(24, 449);
            this.PassVBox.MaxLength = 32767;
            this.PassVBox.Multiline = false;
            this.PassVBox.Name = "PassVBox";
            this.PassVBox.ReadOnly = false;
            this.PassVBox.Size = new System.Drawing.Size(406, 29);
            this.PassVBox.Style = MetroSet_UI.Design.Style.Light;
            this.PassVBox.StyleManager = null;
            this.PassVBox.TabIndex = 14;
            this.PassVBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PassVBox.ThemeAuthor = "Narwin";
            this.PassVBox.ThemeName = "MetroLite";
            this.PassVBox.UseSystemPasswordChar = true;
            this.PassVBox.WatermarkText = "Repeat Password";
            this.PassVBox.Click += new System.EventHandler(this.PassVBox_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Location = new System.Drawing.Point(114, 556);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(218, 22);
            this.linkLabel1.TabIndex = 16;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Already have an account?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(24, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 78);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // FileLocation
            // 
            this.FileLocation.AutoCompleteCustomSource = null;
            this.FileLocation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.FileLocation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.FileLocation.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.FileLocation.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.FileLocation.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.FileLocation.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.FileLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FileLocation.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.FileLocation.Image = null;
            this.FileLocation.Lines = null;
            this.FileLocation.Location = new System.Drawing.Point(121, 97);
            this.FileLocation.MaxLength = 32767;
            this.FileLocation.Multiline = false;
            this.FileLocation.Name = "FileLocation";
            this.FileLocation.ReadOnly = false;
            this.FileLocation.Size = new System.Drawing.Size(309, 25);
            this.FileLocation.Style = MetroSet_UI.Design.Style.Light;
            this.FileLocation.StyleManager = null;
            this.FileLocation.TabIndex = 19;
            this.FileLocation.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.FileLocation.ThemeAuthor = "Narwin";
            this.FileLocation.ThemeName = "MetroLite";
            this.FileLocation.UseSystemPasswordChar = false;
            this.FileLocation.WatermarkText = "Choose the pic...";
            // 
            // BrowseButton
            // 
            this.BrowseButton.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BrowseButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BrowseButton.DisabledForeColor = System.Drawing.Color.Gray;
            this.BrowseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BrowseButton.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.BrowseButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.BrowseButton.HoverTextColor = System.Drawing.Color.White;
            this.BrowseButton.Location = new System.Drawing.Point(321, 128);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BrowseButton.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BrowseButton.NormalTextColor = System.Drawing.Color.White;
            this.BrowseButton.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.BrowseButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.BrowseButton.PressTextColor = System.Drawing.Color.White;
            this.BrowseButton.Size = new System.Drawing.Size(107, 27);
            this.BrowseButton.Style = MetroSet_UI.Design.Style.Light;
            this.BrowseButton.StyleManager = null;
            this.BrowseButton.TabIndex = 20;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.ThemeAuthor = "Narwin";
            this.BrowseButton.ThemeName = "MetroLite";
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // metroSetButton1
            // 
            this.metroSetButton1.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton1.DisabledForeColor = System.Drawing.Color.Gray;
            this.metroSetButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetButton1.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton1.HoverTextColor = System.Drawing.Color.White;
            this.metroSetButton1.Location = new System.Drawing.Point(400, 48);
            this.metroSetButton1.Name = "metroSetButton1";
            this.metroSetButton1.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton1.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton1.NormalTextColor = System.Drawing.Color.White;
            this.metroSetButton1.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton1.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton1.PressTextColor = System.Drawing.Color.White;
            this.metroSetButton1.Size = new System.Drawing.Size(30, 23);
            this.metroSetButton1.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetButton1.StyleManager = null;
            this.metroSetButton1.TabIndex = 21;
            this.metroSetButton1.Text = "X";
            this.metroSetButton1.ThemeAuthor = "Narwin";
            this.metroSetButton1.ThemeName = "MetroLite";
            this.metroSetButton1.Click += new System.EventHandler(this.metroSetButton1_Click);
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.metroSetLabel1.Location = new System.Drawing.Point(24, 325);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(198, 23);
            this.metroSetLabel1.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel1.StyleManager = null;
            this.metroSetLabel1.TabIndex = 22;
            this.metroSetLabel1.Text = "Select your gender:";
            this.metroSetLabel1.ThemeAuthor = "Narwin";
            this.metroSetLabel1.ThemeName = "MetroLite";
            // 
            // GenderCombo
            // 
            this.GenderCombo.AllowDrop = true;
            this.GenderCombo.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.GenderCombo.BackColor = System.Drawing.Color.Transparent;
            this.GenderCombo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.GenderCombo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.GenderCombo.CausesValidation = false;
            this.GenderCombo.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.GenderCombo.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.GenderCombo.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.GenderCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.GenderCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenderCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.GenderCombo.FormattingEnabled = true;
            this.GenderCombo.ItemHeight = 20;
            this.GenderCombo.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.GenderCombo.Location = new System.Drawing.Point(24, 351);
            this.GenderCombo.Name = "GenderCombo";
            this.GenderCombo.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.GenderCombo.SelectedItemForeColor = System.Drawing.Color.White;
            this.GenderCombo.Size = new System.Drawing.Size(406, 26);
            this.GenderCombo.Style = MetroSet_UI.Design.Style.Light;
            this.GenderCombo.StyleManager = null;
            this.GenderCombo.TabIndex = 23;
            this.GenderCombo.ThemeAuthor = "Narwin";
            this.GenderCombo.ThemeName = "MetroLite";
            // 
            // RegisterPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 606);
            this.Controls.Add(this.GenderCombo);
            this.Controls.Add(this.metroSetLabel1);
            this.Controls.Add(this.metroSetButton1);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.FileLocation);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.PassVBox);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.UserBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LastNameBox);
            this.Controls.Add(this.NameBox);
            this.Name = "RegisterPanel";
            this.Text = "Register";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroSetButton button1;
        private MetroSetTextBox LastNameBox;
        private MetroSetTextBox NameBox;
        private MetroSetTextBox PassBox;
        private MetroSetTextBox UserBox;
        private MetroSetTextBox PassVBox;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
        private MetroSetTextBox FileLocation;
        private MetroSetButton BrowseButton;
        private MetroSetButton metroSetButton1;
        private MetroSetLabel metroSetLabel1;
        private MetroSetComboBox GenderCombo;
    }
}