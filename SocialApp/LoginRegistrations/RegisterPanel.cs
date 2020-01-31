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
    public partial class RegisterPanel : Form
    {
        private UserManagerService userManager;
        private LoginPanel loginPanel;
        public RegisterPanel()
        {
            userManager = new UserManagerService();
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            loginPanel = new LoginPanel();
            loginPanel.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(NameBox.Text) || !string.IsNullOrEmpty(LastNameBox.Text) || 
                !string.IsNullOrEmpty(PassBox.Text) || !string.IsNullOrEmpty(PassVBox.Text)
                || !string.IsNullOrEmpty(UserBox.Text)) 
            {
                if(PassBox.Text == PassVBox.Text)
                {
                    if (!userManager.CheckUserExistence(UserBox.Text))
                    {
                        userManager.RegisterNewUser(NameBox.Text, LastNameBox.Text, UserBox.Text, PassVBox.Text,"");
                        MessageBox.Show("Registration was successful!");
                        this.Hide();
                        loginPanel = new LoginPanel();
                        loginPanel.Show();
                        this.Close();
                    }
                    else
                        MessageBox.Show("Username is already in use.");
                }
                else
                {
                    MessageBox.Show("Passwords Didn't Match.");
                }

            }
            else
            {
                MessageBox.Show("Fill all the gaps.");
            }
        }

        private void UploadButton_Click(object sender, EventArgs e)
        {

        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = false;
            
            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                FileLocation.Text = fileDialog.FileName;
            }
        }

        private void FileLocation_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
