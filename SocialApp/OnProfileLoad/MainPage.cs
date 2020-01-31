using AppPCL.Abstractions.Services;
using AppPCL.Implementations.Services;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SocialApp.OnProfileLoad
{
    public partial class MainPage : Form
    {
        private IWebServices WebServices; 
        public MainPage()
        {
            InitializeComponent();
            WebServices = new WebService();
            NameAndLastNameLabel.Text = $"{StaticHolders.Instance.CurrentUser.Name} {StaticHolders.Instance.CurrentUser.LastName}";
            CurrentProfilePictureBox.ImageLocation = StaticHolders.Instance.CurrentUser.UserImage;
            CurrentProfilePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            var ProfileDTOS = WebServices.GetUserMiniProfileDTOs();
            string SampleProfilePic = "https://cdn.pixabay.com/photo/2015/10/05/22/37/blank-profile-picture-973460_960_720.png";
            Point LastPicturePoint = new Point(17,-120);
            Point LastNameLabelPoint = new Point(177, -100);
            Point LastBornPoint = new Point(177, -50);
            Point SendMessagePoint = new Point(782, -100);
            Point AddFriendPoint = new Point(782, -50);

            Size ButtonSizes = new Size(157, 47);
            Size PictureSize = new Size(144, 131);

            foreach (var user in ProfileDTOS)
            {
                PictureBox pictureBox = new PictureBox();
                Label NameAndLastName = new Label();
                Label DateOfBirthLabel = new Label();
                Button SendMessageButton = new Button();
                Button AddFriendButton = new Button();
                Font font = new Font("Arial", 10, FontStyle.Regular);

                pictureBox.Location = new Point(LastPicturePoint.X , LastPicturePoint.Y + 150);
                pictureBox.Name = "pictureBox1";
                if (user.UserImage == "")
                    pictureBox.ImageLocation = SampleProfilePic;
                else
                    pictureBox.ImageLocation = user.UserImage;
                pictureBox.Size = PictureSize;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                LastPicturePoint = pictureBox.Location;

                NameAndLastName.Text = $"{user.Name} {user.LastName}";
                NameAndLastName.AutoSize = true;
                NameAndLastName.Font = font;
                NameAndLastName.Location = new Point(LastNameLabelPoint.X, LastNameLabelPoint.Y + 150);
                LastNameLabelPoint = NameAndLastName.Location;

                DateOfBirthLabel.Text = user.DateOfBirth.ToString();
                DateOfBirthLabel.AutoSize = true;
                DateOfBirthLabel.Font = font;
                DateOfBirthLabel.Location = new Point(LastBornPoint.X, LastBornPoint.Y + 150);
                LastBornPoint = DateOfBirthLabel.Location;

                SendMessageButton.Text = "Send Message";
                SendMessageButton.Location = new Point(SendMessagePoint.X, SendMessagePoint.Y + 150);
                SendMessageButton.Size = ButtonSizes;
                SendMessageButton.Click += new EventHandler(this.SendMessageButton_Click);
                SendMessageButton.Tag = user.ID;
                SendMessagePoint = SendMessageButton.Location;

                AddFriendButton.Text = "Add Friend";
                AddFriendButton.Location = new Point(AddFriendPoint.X, AddFriendPoint.Y + 150);
                AddFriendButton.Size = ButtonSizes;
                AddFriendButton.Click += new EventHandler(this.AddFriendButton_Click);
                AddFriendButton.Tag = user.ID;
                AddFriendPoint = AddFriendButton.Location;
               
                ((System.ComponentModel.ISupportInitialize)(pictureBox)).EndInit();
                this.ProfilesPanel.Controls.Add(pictureBox);
                this.ProfilesPanel.Controls.Add(NameAndLastName);
                this.ProfilesPanel.Controls.Add(DateOfBirthLabel);
                this.ProfilesPanel.Controls.Add(SendMessageButton);
                this.ProfilesPanel.Controls.Add(AddFriendButton);
                ProfilesPanel.AutoScroll = true;
                textBox1.KeyPress+= (s, o) =>
                {
                    var text = (s as TextBox).Text;
                    
                }
                //vScrollBar1.AutoScrollOffset = ProfilesGroupBox.AutoScrollOffset;
            }
        }
       
        private void NameAndLastNameLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MyProfilePage page = new MyProfilePage();
            page.Show();
        }
        private void MessagesButton_Click(object sender, EventArgs e)
        {

        }
        private void AddFriendButton_Click(object sender, EventArgs e)
        {
            
        }
        private void SendMessageButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("sent message");
        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }

        private void ProfilesGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
