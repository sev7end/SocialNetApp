using AppPCL.Implementations.Services;
using MetroSet_UI.Forms;
using Registration.Implementations.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocialApp.LoginRegistrations
{
    public partial class RegisterPanel : MetroSetForm
    {
        private UserManagerService userManager;
        private LoginPanel loginPanel;
        private PictureManagerServices pictureManager;
        private string UserProfilePic;
        public RegisterPanel()
        {
            InitializeComponent();
            userManager = new UserManagerService();
            pictureManager = new PictureManagerServices();
            pictureBox1.ImageLocation = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcT9Tk6QGooYTtRLZe5081Ajm72fRk0ny7fYp4Moxu0qQkGxaWNM"; 
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            loginPanel = new LoginPanel();
            loginPanel.Show();
            this.Close();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(NameBox.Text) || !string.IsNullOrEmpty(LastNameBox.Text) || 
                !string.IsNullOrEmpty(PassBox.Text) || !string.IsNullOrEmpty(PassVBox.Text)
                || !string.IsNullOrEmpty(UserBox.Text)) 
            {
                if(PassBox.Text == PassVBox.Text)
                {
                    var checker = await userManager.CheckUserExistenceAsync(UserBox.Text);
                    if (!checker)
                    {
                        if (!string.IsNullOrWhiteSpace(FileLocation.Text))
                        {
                            UserProfilePic = pictureManager.UploadPicture(FileLocation.Text);
                        }
                        else
                            UserProfilePic = pictureBox1.ImageLocation;

                        await userManager.RegisterNewUserAsync(NameBox.Text, LastNameBox.Text, UserBox.Text, PassVBox.Text, UserProfilePic);
                        MetroSetMessageBox.Show(this, "Registration was successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        loginPanel = new LoginPanel();
                        loginPanel.Show();
                        this.Close();

                    }
                    else
                        MetroSetMessageBox.Show(this, "Username is already in use!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MetroSetMessageBox.Show(this, "Passwords didn't match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MetroSetMessageBox.Show(this, "Fill all the gaps!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void UploadButton_Click(object sender, EventArgs e)
        //{
        //    //if (!string.IsNullOrWhiteSpace(FileLocation.Text))
        //    //{
        //    //    UserProfilePic = pictureManager.UploadPicture(FileLocation.Text);
        //    //    pictureBox1.ImageLocation = UserProfilePic;
        //    //    pictureBox1.Refresh();
        //    //}
        //    //else
        //    //    MessageBox.Show("Error, please choose a file");
        //}

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = false;
            
            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                FileLocation.Text = fileDialog.FileName;
                pictureBox1.ImageLocation = fileDialog.FileName;
            }
            pictureBox1.Refresh();
        }

        private void FileLocation_TextChanged(object sender, EventArgs e)
        {

        }

        private void metroSetButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginPanel loginPanel = new LoginPanel();
            loginPanel.Show();
        }

        private void PassVBox_Click(object sender, EventArgs e)
        {

        }
    }
}
