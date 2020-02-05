using AppPCL.Implementations.Services;
using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocialApp.OnProfileLoad
{
    public partial class MyProfilePage : MetroSetForm
    {
        public MyProfilePage()
        { 
            InitializeComponent();
            NameLastNameLabel.Text = $"{StaticHolders.Instance.CurrentUser.Name} {StaticHolders.Instance.CurrentUser.LastName}";
            pictureBox1.ImageLocation = StaticHolders.Instance.CurrentUser.UserImage;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            DateOfBirthLabel.Text = $"Born: {StaticHolders.Instance.CurrentUser.DateOfBirth.ToString()}";

        }

        private void MyProfilePage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void metroSetButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
