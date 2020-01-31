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
            Point LastBornPoint = new Point(177, 0);
            Point SendMessagePoint = new Point(782, -100);
            Point AddFriendPoint = new Point(782, -30);

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

                DateOfBirthLabel.Text = user.DateOfBirth.ToString();
                DateOfBirthLabel.AutoSize = true;
                DateOfBirthLabel.Font = font;
                DateOfBirthLabel.Location = new Point(LastBornPoint.X, LastBornPoint.Y + 150);

                SendMessageButton.Text = "Send Message";
                SendMessageButton.Location = new Point(SendMessagePoint.X, SendMessagePoint.Y + 150);
                SendMessageButton.Size = ButtonSizes;
               

                AddFriendButton.Text = "Add Friend";
                AddFriendButton.Location = new Point(AddFriendPoint.X, AddFriendPoint.Y + 150);
                AddFriendButton.Size = ButtonSizes;

               
                ((System.ComponentModel.ISupportInitialize)(pictureBox)).EndInit();
                this.ProfilesGroupBox.Controls.Add(pictureBox);
                this.ProfilesGroupBox.Controls.Add(NameAndLastName);
                this.ProfilesGroupBox.Controls.Add(DateOfBirthLabel);
                this.ProfilesGroupBox.Controls.Add(SendMessageButton);
                this.ProfilesGroupBox.Controls.Add(AddFriendButton);
                this.ProfilesGroupBox.Controls.Add(vScrollBar1);
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

        private void MainPage_Load(object sender, EventArgs e)
        {

        }

        private void ProfilesGroupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
