using MetroSet_UI.Controls;

namespace SocialApp.LoginRegistrations
{
    partial class LoginPanel
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
            this.UserBox = new MetroSet_UI.Controls.MetroSetTextBox();
            this.PassBox = new MetroSet_UI.Controls.MetroSetTextBox();
            this.button1 = new MetroSet_UI.Controls.MetroSetButton();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.metroSetButton1 = new MetroSet_UI.Controls.MetroSetButton();
            this.SuspendLayout();
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
            this.UserBox.Location = new System.Drawing.Point(26, 96);
            this.UserBox.MaxLength = 32767;
            this.UserBox.Multiline = false;
            this.UserBox.Name = "UserBox";
            this.UserBox.ReadOnly = false;
            this.UserBox.Size = new System.Drawing.Size(383, 29);
            this.UserBox.Style = MetroSet_UI.Design.Style.Light;
            this.UserBox.StyleManager = null;
            this.UserBox.TabIndex = 0;
            this.UserBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.UserBox.ThemeAuthor = "Narwin";
            this.UserBox.ThemeName = "MetroLite";
            this.UserBox.UseSystemPasswordChar = false;
            this.UserBox.WatermarkText = "UserName";
            //this.UserBox.Click += new System.EventHandler(this.UserBox_Click);
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
            this.PassBox.Location = new System.Drawing.Point(26, 145);
            this.PassBox.MaxLength = 32767;
            this.PassBox.Multiline = false;
            this.PassBox.Name = "PassBox";
            this.PassBox.ReadOnly = false;
            this.PassBox.Size = new System.Drawing.Size(383, 29);
            this.PassBox.Style = MetroSet_UI.Design.Style.Light;
            this.PassBox.StyleManager = null;
            this.PassBox.TabIndex = 1;
            this.PassBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PassBox.ThemeAuthor = "Narwin";
            this.PassBox.ThemeName = "MetroLite";
            this.PassBox.UseSystemPasswordChar = true;
            this.PassBox.WatermarkText = "Password";
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
            this.button1.Location = new System.Drawing.Point(146, 193);
            this.button1.Name = "button1";
            this.button1.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.button1.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.button1.NormalTextColor = System.Drawing.Color.White;
            this.button1.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.button1.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.button1.PressTextColor = System.Drawing.Color.White;
            this.button1.Size = new System.Drawing.Size(124, 32);
            this.button1.Style = MetroSet_UI.Design.Style.Light;
            this.button1.StyleManager = null;
            this.button1.TabIndex = 2;
            this.button1.Text = "Login";
            this.button1.ThemeAuthor = "Narwin";
            this.button1.ThemeName = "MetroLite";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.linkLabel1.Location = new System.Drawing.Point(313, 203);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(96, 22);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "New user?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
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
            this.metroSetButton1.Location = new System.Drawing.Point(397, 48);
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
            this.metroSetButton1.TabIndex = 17;
            this.metroSetButton1.Text = "X";
            this.metroSetButton1.ThemeAuthor = "Narwin";
            this.metroSetButton1.ThemeName = "MetroLite";
            this.metroSetButton1.Click += new System.EventHandler(this.metroSetButton1_Click);
            // 
            // LoginPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 252);
            this.Controls.Add(this.metroSetButton1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.UserBox);
            this.MaximumSize = new System.Drawing.Size(442, 252);
            this.MinimumSize = new System.Drawing.Size(442, 252);
            this.Name = "LoginPanel";
            this.ShowIcon = false;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroSetTextBox UserBox;
        private MetroSetTextBox PassBox;
        private MetroSetButton button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private MetroSetButton metroSetButton1;
    }
}