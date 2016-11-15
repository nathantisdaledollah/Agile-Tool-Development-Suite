﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgileDevelopmentToolsSuite
{
    public partial class GroupProfileForm : Form
    {
        public GroupProfileForm()
        {
            InitializeComponent();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Width = this.Width;
            mainMenuForm.Height = this.Height;

            mainMenuForm.StartPosition = FormStartPosition.Manual;
            mainMenuForm.Location = new Point(this.Location.X, this.Location.Y);

            this.Hide();
            mainMenuForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void skillLabel1_Click(object sender, EventArgs e)
        {

        }

    private void pictureBox1_Click(object sender, EventArgs e)
    {
      var request = WebRequest.Create("https://lh3.googleusercontent.com/-VnHUvY7m-CE/AAAAAAAAAAI/AAAAAAAAAAA/jrf-MIpUPAM/s96-k-no/photo.jpg");

      using (var response = request.GetResponse())
      using (var stream = response.GetResponseStream())
      {
        pictureBox1.Image = Bitmap.FromStream(stream);
      }
    }
  }
}
