using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppPCL.Abstractions.Models;

namespace SocialApp.Models
{
    public partial class DTOPreview : UserControl
    {
        public DTOPreview(string name,string lastname, string imgurl, int ID,Gender gender)
        {
            InitializeComponent();
            NameLabel.Text = $"{name} {lastname}";
            pictureBox1.ImageLocation = imgurl;
            GenderLabel.Text = gender.ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
