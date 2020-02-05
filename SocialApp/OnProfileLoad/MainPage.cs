using AppPCL.Abstractions.Services;
using AppPCL.Implementations.Services;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using AppPCL.Abstractions.Models;
using AppPCL.Implementations.Models;
using MetroSet_UI;
using MetroSet_UI.Forms;
using MetroSet_UI.Controls;

namespace SocialApp.OnProfileLoad
{
    public partial class MainPage : MetroSetForm
    {
        private IWebServices WebServices;
        private IUserProfileManager ProfileManager;
        private List<IUserMiniProfileDTO> ProfileDTOS;
        private List<IUserMiniProfileDTO> UserFriends;
        public MainPage()
        {
            InitializeComponent();
            WebServices = new WebService();
            ProfileManager = new UserProfileManager();
            NameAndLastNameLabel.Text = $"{StaticHolders.Instance.CurrentUser.Name} {StaticHolders.Instance.CurrentUser.LastName}";
            CurrentProfilePictureBox.ImageLocation = StaticHolders.Instance.CurrentUser.UserImage;
            CurrentProfilePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            UserFriends = StaticHolders.Instance.CurrentUser.userFriends;
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
           
        }
        private void MainPage_Load(object sender, EventArgs e)
        {
            string SampleProfilePic = "https://cdn.pixabay.com/photo/2015/10/05/22/37/blank-profile-picture-973460_960_720.png";
            ProfileDTOS = WebServices.GetUserMiniProfileDTOs();

            Point LastPicturePoint = new Point(17, -120);
            Point LastNameLabelPoint = new Point(177, -100);
            Point LastBornPoint = new Point(177, -50);
            Point SendMessagePoint = new Point(782, -100);
            Point AddFriendPoint = new Point(782, -50);

            Size ButtonSizes = new Size(157, 47);
            Size PictureSize = new Size(144, 131);

            foreach (var user in ProfileDTOS)
            {

                PictureBox pictureBox = new PictureBox();
                MetroSetLabel NameAndLastName = new MetroSetLabel();
                MetroSetLabel DateOfBirthLabel = new MetroSetLabel();
                MetroSetButton SendMessageButton = new MetroSetButton();
                Button AddFriendButton = new Button();
                Font font = new Font("Arial", 10, FontStyle.Regular);

                pictureBox.Location = new Point(LastPicturePoint.X, LastPicturePoint.Y + 150);
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
                SendMessageButton.Click += (s, eventarg) => { MetroSetMessageBox.Show(this,"Message Sent!"); };
                SendMessageButton.Tag = user.ID;
                SendMessagePoint = SendMessageButton.Location;

                AddFriendButton.Text = "Add Friend";
                AddFriendButton.Location = new Point(AddFriendPoint.X, AddFriendPoint.Y + 150);
                AddFriendButton.Size = ButtonSizes;
                AddFriendButton.Click += (s, eventarg) => { MetroSetMessageBox.Show(this,"Friend Request Sent!"); };
                AddFriendButton.Tag = user.ID;
                AddFriendPoint = AddFriendButton.Location;

                ((System.ComponentModel.ISupportInitialize)(pictureBox)).EndInit();
                ProfilesPanel.Controls.Add(pictureBox);
                ProfilesPanel.Controls.Add(NameAndLastName);
                ProfilesPanel.Controls.Add(DateOfBirthLabel);
                ProfilesPanel.Controls.Add(SendMessageButton);
                ProfilesPanel.Controls.Add(AddFriendButton);
                ProfilesPanel.AutoScroll = true;
            }
        }
        private void ProfilesGroupBox_Enter(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void metroSetButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void metroSetTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SampleProfilePic = "https://cdn.pixabay.com/photo/2015/10/05/22/37/blank-profile-picture-973460_960_720.png";
            ProfileDTOS = WebServices.GetUserMiniProfileDTOs();

            Point LastPicturePoint = new Point(17, -120);
            Point LastNameLabelPoint = new Point(177, -100);
            Point LastBornPoint = new Point(177, -50);
            Point SendMessagePoint = new Point(782, -100);
            Point AddFriendPoint = new Point(782, -50);

            Size ButtonSizes = new Size(157, 47);
            Size PictureSize = new Size(144, 131);

            foreach (var user in ProfileDTOS)
            {

                PictureBox pictureBox = new PictureBox();
                MetroSetLabel NameAndLastName = new MetroSetLabel();
                MetroSetLabel DateOfBirthLabel = new MetroSetLabel();
                MetroSetButton SendMessageButton = new MetroSetButton();
                Button AddFriendButton = new Button();
                Font font = new Font("Arial", 10, FontStyle.Regular);

                pictureBox.Location = new Point(LastPicturePoint.X, LastPicturePoint.Y + 150);
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
                SendMessageButton.Click += (s, eventarg) => { MetroSetMessageBox.Show(this, "Message Sent!"); };
                SendMessageButton.Tag = user.ID;
                SendMessagePoint = SendMessageButton.Location;

                AddFriendButton.Text = "Add Friend";
                AddFriendButton.Location = new Point(AddFriendPoint.X, AddFriendPoint.Y + 150);
                AddFriendButton.Size = ButtonSizes;
                AddFriendButton.Click += (s, eventarg) => { MetroSetMessageBox.Show(this, "Friend Request Sent!"); };
                AddFriendButton.Tag = user.ID;
                AddFriendPoint = AddFriendButton.Location;

                ((System.ComponentModel.ISupportInitialize)(pictureBox)).EndInit();
                ProfilesPanel.Controls.Add(pictureBox);
                ProfilesPanel.Controls.Add(NameAndLastName);
                ProfilesPanel.Controls.Add(DateOfBirthLabel);
                ProfilesPanel.Controls.Add(SendMessageButton);
                ProfilesPanel.Controls.Add(AddFriendButton);
                ProfilesPanel.AutoScroll = true;
            }
        }
    }
}
