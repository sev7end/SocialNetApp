using Registration.Abstractions.Models;
using Registration.Implementations.Models;
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
    public partial class LoginPanel : Form
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

        private void button1_Click(object sender, EventArgs e)
        {
            bool Login = false;
            if (!string.IsNullOrEmpty(UserBox.Text) || !string.IsNullOrEmpty(PassBox.Text))
                Login = UserService.LoginUser(UserBox.Text, PassBox.Text);
            else
                MessageBox.Show("Fill all the boxes");
            
            if (Login)
                MessageBox.Show("Login Successful!");
            else
                MessageBox.Show("Incorrect Info");

        }
    }
}
