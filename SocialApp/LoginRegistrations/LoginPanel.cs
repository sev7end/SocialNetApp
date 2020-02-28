using MetroSet_UI.Forms;
using Registration.Abstractions.Models;
using Registration.Implementations.Models;
using Registration.Implementations.Services;
using SocialApp.OnProfileLoad;
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
    public partial class LoginPanel : MetroSetForm
    {
        private RegisterPanel registerPanel;
        private UserManagerService UserService;
        public LoginPanel()
        {
            UserService = new UserManagerService();
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            registerPanel = new RegisterPanel();
            registerPanel.Show();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            bool Login = false;
            if (!string.IsNullOrEmpty(UserBox.Text) || !string.IsNullOrEmpty(PassBox.Text))
                Login = await UserService.LoginUserAsync(UserBox.Text, PassBox.Text);
            else
                MessageBox.Show("Fill all the boxes");

            if (Login)
            {
                MessageBox.Show("Login Successful!");
                this.Hide();
                MainPage mainPage = new MainPage();
                mainPage.Show();
            }
            else
                MessageBox.Show("Incorrect Info");

        }
        private void metroSetButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
