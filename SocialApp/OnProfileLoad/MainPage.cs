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
using SocialApp.Models;
using System.Threading.Tasks;

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
            ProfileLink.Text = $"{StaticHolders.Instance.CurrentUser.Name} {StaticHolders.Instance.CurrentUser.LastName}";
            CurrentProfilePictureBox.ImageLocation = StaticHolders.Instance.CurrentUser.UserImage;
            CurrentProfilePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            UserFriends = StaticHolders.Instance.CurrentUser.userFriends;
        }

        private void MessagesButton_Click(object sender, EventArgs e)
        {

        }
        private void LoadProfiles(List<IUserMiniProfileDTO> userProfiles,MetroSetPanel panel)
        {

            foreach (var user in userProfiles)
            {
                DTOPreview UserVisual = default;
                UserVisual = new DTOPreview(user.Name, user.LastName, user.UserImage, user.ID, user.UserGender);
                UserVisual.Anchor = ((AnchorStyles)((AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left)));
                panel.Controls.Add(UserVisual);
                UserVisual.Dock = DockStyle.Top;
                UserVisual.ForeColor = Color.Black;

                panel.AutoScroll = true;
            }
        }
        private async void MainPage_Load(object sender, EventArgs e)
        {
            ProfileDTOS = await WebServices.GetUserMiniProfileDTOsAsync();
            LoadProfiles(ProfileDTOS,ProfilesPanel);
        }

        private void metroSetButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void metroSetTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProfileDTOS = await WebServices.GetUserMiniProfileDTOsAsync();
            LoadProfiles(ProfileDTOS,FriendsPanel);
        }

        private void metroSetButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            StaticHolders.Instance.SignOut();
            LoginRegistrations.LoginPanel loginPanel = new LoginRegistrations.LoginPanel();
            loginPanel.Show();
        }
        private void ProfileLink_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MyProfilePage page = new MyProfilePage();
            page.Show();
        }

        private void metroSetSwitch1_SwitchedChanged(object sender)
        {
            if (metroSetSwitch1.Switched)
            {
                this.Style = MetroSet_UI.Design.Style.Dark;
                ProfileLink.LinkColor = Color.White;
                
            }
            else
            {
                this.Style = MetroSet_UI.Design.Style.Light;
                ProfileLink.LinkColor = Color.Black;
                ProfilesPanel.Style = MetroSet_UI.Design.Style.Light;
            }
        }
    }
}
