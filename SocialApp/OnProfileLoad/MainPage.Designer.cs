using MetroSet_UI.Controls;
using System.Windows.Forms;
using static MetroSet_UI.Controls.MetroSetTextBox;

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
            this.CurrentProfilePictureBox = new System.Windows.Forms.PictureBox();
            this.MessagesButton = new MetroSet_UI.Controls.MetroSetButton();
            this.FriendsButton = new MetroSet_UI.Controls.MetroSetButton();
            this.RequestsButton = new MetroSet_UI.Controls.MetroSetButton();
            this.ProfilesPanel = new MetroSet_UI.Controls.MetroSetPanel();
            this.textBox1 = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetButton1 = new MetroSet_UI.Controls.MetroSetButton();
            this.metroSetTabControl1 = new MetroSet_UI.Controls.MetroSetTabControl();
            this.metroSetTabPage1 = new MetroSet_UI.Child.MetroSetTabPage();
            this.metroSetTabPage2 = new MetroSet_UI.Child.MetroSetTabPage();
            this.FriendsPanel = new MetroSet_UI.Controls.MetroSetPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.metroSetButton2 = new MetroSet_UI.Controls.MetroSetButton();
            this.metroSetSwitch1 = new MetroSet_UI.Controls.MetroSetSwitch();
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.ProfileLink = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentProfilePictureBox)).BeginInit();
            this.metroSetTabControl1.SuspendLayout();
            this.metroSetTabPage1.SuspendLayout();
            this.metroSetTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CurrentProfilePictureBox
            // 
            this.CurrentProfilePictureBox.Location = new System.Drawing.Point(5, 63);
            this.CurrentProfilePictureBox.Name = "CurrentProfilePictureBox";
            this.CurrentProfilePictureBox.Size = new System.Drawing.Size(179, 153);
            this.CurrentProfilePictureBox.TabIndex = 1;
            this.CurrentProfilePictureBox.TabStop = false;
            // 
            // MessagesButton
            // 
            this.MessagesButton.BackColor = System.Drawing.Color.Transparent;
            this.MessagesButton.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.MessagesButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.MessagesButton.DisabledForeColor = System.Drawing.Color.Gray;
            this.MessagesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.MessagesButton.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.MessagesButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.MessagesButton.HoverTextColor = System.Drawing.Color.White;
            this.MessagesButton.Location = new System.Drawing.Point(5, 287);
            this.MessagesButton.Name = "MessagesButton";
            this.MessagesButton.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.MessagesButton.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.MessagesButton.NormalTextColor = System.Drawing.Color.White;
            this.MessagesButton.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.MessagesButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.MessagesButton.PressTextColor = System.Drawing.Color.White;
            this.MessagesButton.Size = new System.Drawing.Size(179, 29);
            this.MessagesButton.Style = MetroSet_UI.Design.Style.Light;
            this.MessagesButton.StyleManager = null;
            this.MessagesButton.TabIndex = 3;
            this.MessagesButton.Text = "Messages";
            this.MessagesButton.ThemeAuthor = "Narwin";
            this.MessagesButton.ThemeName = "MetroLite";
            this.MessagesButton.Click += new System.EventHandler(this.MessagesButton_Click);
            // 
            // FriendsButton
            // 
            this.FriendsButton.BackColor = System.Drawing.Color.Transparent;
            this.FriendsButton.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.FriendsButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.FriendsButton.DisabledForeColor = System.Drawing.Color.Gray;
            this.FriendsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FriendsButton.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.FriendsButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.FriendsButton.HoverTextColor = System.Drawing.Color.White;
            this.FriendsButton.Location = new System.Drawing.Point(5, 357);
            this.FriendsButton.Name = "FriendsButton";
            this.FriendsButton.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.FriendsButton.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.FriendsButton.NormalTextColor = System.Drawing.Color.White;
            this.FriendsButton.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.FriendsButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.FriendsButton.PressTextColor = System.Drawing.Color.White;
            this.FriendsButton.Size = new System.Drawing.Size(179, 29);
            this.FriendsButton.Style = MetroSet_UI.Design.Style.Light;
            this.FriendsButton.StyleManager = null;
            this.FriendsButton.TabIndex = 4;
            this.FriendsButton.Text = "Friends";
            this.FriendsButton.ThemeAuthor = "Narwin";
            this.FriendsButton.ThemeName = "MetroLite";
            // 
            // RequestsButton
            // 
            this.RequestsButton.BackColor = System.Drawing.Color.Transparent;
            this.RequestsButton.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.RequestsButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.RequestsButton.DisabledForeColor = System.Drawing.Color.Gray;
            this.RequestsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.RequestsButton.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.RequestsButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.RequestsButton.HoverTextColor = System.Drawing.Color.White;
            this.RequestsButton.Location = new System.Drawing.Point(5, 322);
            this.RequestsButton.Name = "RequestsButton";
            this.RequestsButton.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.RequestsButton.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.RequestsButton.NormalTextColor = System.Drawing.Color.White;
            this.RequestsButton.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.RequestsButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.RequestsButton.PressTextColor = System.Drawing.Color.White;
            this.RequestsButton.Size = new System.Drawing.Size(179, 29);
            this.RequestsButton.Style = MetroSet_UI.Design.Style.Light;
            this.RequestsButton.StyleManager = null;
            this.RequestsButton.TabIndex = 5;
            this.RequestsButton.Text = "Requests";
            this.RequestsButton.ThemeAuthor = "Narwin";
            this.RequestsButton.ThemeName = "MetroLite";
            // 
            // ProfilesPanel
            // 
            this.ProfilesPanel.BackgroundColor = System.Drawing.Color.White;
            this.ProfilesPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.ProfilesPanel.BorderThickness = 1;
            this.ProfilesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProfilesPanel.Location = new System.Drawing.Point(0, 0);
            this.ProfilesPanel.Name = "ProfilesPanel";
            this.ProfilesPanel.Size = new System.Drawing.Size(1009, 680);
            this.ProfilesPanel.Style = MetroSet_UI.Design.Style.Light;
            this.ProfilesPanel.StyleManager = null;
            this.ProfilesPanel.TabIndex = 16;
            this.ProfilesPanel.ThemeAuthor = "Narwin";
            this.ProfilesPanel.ThemeName = "MetroLite";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.AutoCompleteCustomSource = null;
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.textBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.textBox1.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.textBox1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.textBox1.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.textBox1.Image = null;
            this.textBox1.Lines = null;
            this.textBox1.Location = new System.Drawing.Point(421, 51);
            this.textBox1.MaxLength = 32767;
            this.textBox1.Multiline = false;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = false;
            this.textBox1.Size = new System.Drawing.Size(434, 27);
            this.textBox1.Style = MetroSet_UI.Design.Style.Light;
            this.textBox1.StyleManager = null;
            this.textBox1.TabIndex = 13;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBox1.ThemeAuthor = "Narwin";
            this.textBox1.ThemeName = "MetroLite";
            this.textBox1.UseSystemPasswordChar = false;
            this.textBox1.WatermarkText = "Search";
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
            this.metroSetButton1.Location = new System.Drawing.Point(1185, 3);
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
            this.metroSetButton1.TabIndex = 15;
            this.metroSetButton1.Text = "X";
            this.metroSetButton1.ThemeAuthor = "Narwin";
            this.metroSetButton1.ThemeName = "MetroLite";
            this.metroSetButton1.Click += new System.EventHandler(this.metroSetButton1_Click);
            // 
            // metroSetTabControl1
            // 
            this.metroSetTabControl1.AnimateEasingType = MetroSet_UI.Enums.EasingType.CubeOut;
            this.metroSetTabControl1.AnimateTime = 200;
            this.metroSetTabControl1.Controls.Add(this.metroSetTabPage1);
            this.metroSetTabControl1.Controls.Add(this.metroSetTabPage2);
            this.metroSetTabControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroSetTabControl1.ItemSize = new System.Drawing.Size(100, 38);
            this.metroSetTabControl1.Location = new System.Drawing.Point(192, 84);
            this.metroSetTabControl1.Name = "metroSetTabControl1";
            this.metroSetTabControl1.SelectedIndex = 0;
            this.metroSetTabControl1.Size = new System.Drawing.Size(1017, 726);
            this.metroSetTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.metroSetTabControl1.Speed = 20;
            this.metroSetTabControl1.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetTabControl1.StyleManager = null;
            this.metroSetTabControl1.TabIndex = 16;
            this.metroSetTabControl1.TabStyle = MetroSet_UI.Enums.TabStyle.Style1;
            this.metroSetTabControl1.ThemeAuthor = "Narwin";
            this.metroSetTabControl1.ThemeName = "MetroLite";
            this.metroSetTabControl1.UseAnimation = true;
            this.metroSetTabControl1.SelectedIndexChanged += new System.EventHandler(this.metroSetTabControl1_SelectedIndexChanged);
            // 
            // metroSetTabPage1
            // 
            this.metroSetTabPage1.BaseColor = System.Drawing.Color.White;
            this.metroSetTabPage1.Controls.Add(this.ProfilesPanel);
            this.metroSetTabPage1.ImageIndex = 0;
            this.metroSetTabPage1.ImageKey = null;
            this.metroSetTabPage1.Location = new System.Drawing.Point(4, 42);
            this.metroSetTabPage1.Name = "metroSetTabPage1";
            this.metroSetTabPage1.Size = new System.Drawing.Size(1009, 680);
            this.metroSetTabPage1.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetTabPage1.StyleManager = null;
            this.metroSetTabPage1.TabIndex = 0;
            this.metroSetTabPage1.Text = "Profiles";
            this.metroSetTabPage1.ThemeAuthor = "Narwin";
            this.metroSetTabPage1.ThemeName = "MetroLite";
            this.metroSetTabPage1.ToolTipText = null;
            // 
            // metroSetTabPage2
            // 
            this.metroSetTabPage2.BaseColor = System.Drawing.Color.White;
            this.metroSetTabPage2.Controls.Add(this.FriendsPanel);
            this.metroSetTabPage2.ImageIndex = 0;
            this.metroSetTabPage2.ImageKey = null;
            this.metroSetTabPage2.Location = new System.Drawing.Point(4, 42);
            this.metroSetTabPage2.Name = "metroSetTabPage2";
            this.metroSetTabPage2.Size = new System.Drawing.Size(1009, 680);
            this.metroSetTabPage2.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetTabPage2.StyleManager = null;
            this.metroSetTabPage2.TabIndex = 1;
            this.metroSetTabPage2.Text = "Friends";
            this.metroSetTabPage2.ThemeAuthor = "Narwin";
            this.metroSetTabPage2.ThemeName = "MetroLite";
            this.metroSetTabPage2.ToolTipText = null;
            // 
            // FriendsPanel
            // 
            this.FriendsPanel.BackgroundColor = System.Drawing.Color.White;
            this.FriendsPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.FriendsPanel.BorderThickness = 1;
            this.FriendsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FriendsPanel.Location = new System.Drawing.Point(0, 0);
            this.FriendsPanel.Name = "FriendsPanel";
            this.FriendsPanel.Size = new System.Drawing.Size(1009, 680);
            this.FriendsPanel.Style = MetroSet_UI.Design.Style.Light;
            this.FriendsPanel.StyleManager = null;
            this.FriendsPanel.TabIndex = 0;
            this.FriendsPanel.ThemeAuthor = "Narwin";
            this.FriendsPanel.ThemeName = "MetroLite";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.button1.BackgroundImage = global::SocialApp.Properties.Resources.the_loop_png_2;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(825, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 27);
            this.button1.TabIndex = 17;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // metroSetButton2
            // 
            this.metroSetButton2.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton2.DisabledForeColor = System.Drawing.Color.Gray;
            this.metroSetButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetButton2.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton2.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton2.HoverTextColor = System.Drawing.Color.White;
            this.metroSetButton2.Location = new System.Drawing.Point(1137, 50);
            this.metroSetButton2.Name = "metroSetButton2";
            this.metroSetButton2.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton2.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton2.NormalTextColor = System.Drawing.Color.White;
            this.metroSetButton2.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton2.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton2.PressTextColor = System.Drawing.Color.White;
            this.metroSetButton2.Size = new System.Drawing.Size(72, 23);
            this.metroSetButton2.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetButton2.StyleManager = null;
            this.metroSetButton2.TabIndex = 18;
            this.metroSetButton2.Text = "Sign out";
            this.metroSetButton2.ThemeAuthor = "Narwin";
            this.metroSetButton2.ThemeName = "MetroLite";
            this.metroSetButton2.Click += new System.EventHandler(this.metroSetButton2_Click);
            // 
            // metroSetSwitch1
            // 
            this.metroSetSwitch1.BackColor = System.Drawing.Color.Transparent;
            this.metroSetSwitch1.BackgroundColor = System.Drawing.Color.Empty;
            this.metroSetSwitch1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
            this.metroSetSwitch1.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetSwitch1.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.metroSetSwitch1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroSetSwitch1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.metroSetSwitch1.DisabledCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetSwitch1.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.metroSetSwitch1.Location = new System.Drawing.Point(211, 55);
            this.metroSetSwitch1.Name = "metroSetSwitch1";
            this.metroSetSwitch1.Size = new System.Drawing.Size(58, 22);
            this.metroSetSwitch1.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetSwitch1.StyleManager = null;
            this.metroSetSwitch1.Switched = false;
            this.metroSetSwitch1.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetSwitch1.TabIndex = 19;
            this.metroSetSwitch1.Text = "StyleMode";
            this.metroSetSwitch1.ThemeAuthor = "Narwin";
            this.metroSetSwitch1.ThemeName = "MetroLite";
            this.metroSetSwitch1.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroSetSwitch1.SwitchedChanged += new MetroSet_UI.Controls.MetroSetSwitch.SwitchedChangedEventHandler(this.metroSetSwitch1_SwitchedChanged);
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel1.Location = new System.Drawing.Point(275, 58);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(84, 23);
            this.metroSetLabel1.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel1.StyleManager = null;
            this.metroSetLabel1.TabIndex = 20;
            this.metroSetLabel1.Text = "Dark Mode";
            this.metroSetLabel1.ThemeAuthor = "Narwin";
            this.metroSetLabel1.ThemeName = "MetroLite";
            this.metroSetLabel1.Click += new System.EventHandler(this.metroSetLabel1_Click);
            // 
            // ProfileLink
            // 
            this.ProfileLink.ActiveLinkColor = System.Drawing.Color.Black;
            this.ProfileLink.AutoSize = true;
            this.ProfileLink.BackColor = System.Drawing.Color.Transparent;
            this.ProfileLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProfileLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.ProfileLink.LinkColor = System.Drawing.Color.Black;
            this.ProfileLink.Location = new System.Drawing.Point(44, 237);
            this.ProfileLink.Name = "ProfileLink";
            this.ProfileLink.Size = new System.Drawing.Size(91, 22);
            this.ProfileLink.TabIndex = 21;
            this.ProfileLink.TabStop = true;
            this.ProfileLink.Text = "linkLabel1";
            this.ProfileLink.VisitedLinkColor = System.Drawing.Color.Black;
            this.ProfileLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ProfileLink_LinkClicked_1);
            // 
            // MainPage
            // 
            this.AllowResize = false;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1220, 789);
            this.Controls.Add(this.ProfileLink);
            this.Controls.Add(this.metroSetLabel1);
            this.Controls.Add(this.metroSetSwitch1);
            this.Controls.Add(this.metroSetButton2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.metroSetTabControl1);
            this.Controls.Add(this.metroSetButton1);
            this.Controls.Add(this.RequestsButton);
            this.Controls.Add(this.FriendsButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.MessagesButton);
            this.Controls.Add(this.CurrentProfilePictureBox);
            this.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.MaximumSize = new System.Drawing.Size(1220, 789);
            this.MinimumSize = new System.Drawing.Size(1220, 789);
            this.Name = "MainPage";
            this.Padding = new System.Windows.Forms.Padding(2, 60, 2, 2);
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowHeader = true;
            this.ShowLeftRect = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Social App";
            this.TextColor = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.MainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CurrentProfilePictureBox)).EndInit();
            this.metroSetTabControl1.ResumeLayout(false);
            this.metroSetTabPage1.ResumeLayout(false);
            this.metroSetTabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox CurrentProfilePictureBox;
        private MetroSetButton MessagesButton;
        private MetroSetButton FriendsButton;
        private MetroSetButton RequestsButton;
        private MetroSetTextBox textBox1;
        private MetroSetPanel ProfilesPanel;
        private MetroSetButton metroSetButton1;
        private MetroSetTabControl metroSetTabControl1;
        private MetroSet_UI.Child.MetroSetTabPage metroSetTabPage1;
        private MetroSet_UI.Child.MetroSetTabPage metroSetTabPage2;
        private MetroSetPanel FriendsPanel;
        private Button button1;
        private MetroSetButton metroSetButton2;
        private MetroSetSwitch metroSetSwitch1;
        private MetroSetLabel metroSetLabel1;
        private LinkLabel ProfileLink;
    }
}