﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgileDevelopmentToolsSuite
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PositionForm registrationForm = new PositionForm();


            registrationForm.Width = this.Width;
            registrationForm.Height = this.Height;

            registrationForm.StartPosition = FormStartPosition.Manual;
            registrationForm.Location = new Point(this.Location.X, this.Location.Y);

            this.Hide();
            registrationForm.Show();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // MessageBox.Show("bye login");
            Application.Exit();

        }
    }
}
