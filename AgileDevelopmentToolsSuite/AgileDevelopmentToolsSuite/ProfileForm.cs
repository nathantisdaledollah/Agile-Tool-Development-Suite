﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgileDevelopmentToolsSuite
{
  public partial class ProfileForm : Form
  {
    String currentUser = "";
    public ProfileForm()
    {
      InitializeComponent();
    }

    public ProfileForm(String curUser)
    {
      InitializeComponent();
      currentUser = curUser;
      nameLabel.Text = curUser;
    }

    private void resetView()
    {
      SqlConnection db;
      String version = "MSSQLLocalDB";
      String fileName = "ADTSDInfo.mdf";
      String connectionString = String.Format(@"Data Source=(LocalDB)\{0};AttachDbFilename=|DataDirectory|\{1};Initial Catalog=ADSTDInfo;Integrated Security=True;MultipleActiveResultSets=True", version, fileName);

      db = new SqlConnection(connectionString);
      try
      {
        db.Open();
        //MessageBox.Show("Connection Successful! ");
        try
        {

          DataSet ds = new DataSet();

          
          SqlCommand getUserInfo = new SqlCommand("SELECT Nickname, ProfileLink, Workplace, [Phone Number], Email FROM [UserInformation] WHERE [Username] = @Username");


          getUserInfo.Connection = db;
          getUserInfo.Parameters.AddWithValue("@Username", currentUser);

          var reader = getUserInfo.ExecuteReader();

          List<object> userInfoList = new List<object>(); // Use list to generate a display for the listbox (to carry info)

          
          while (reader.Read()) //Iterate through all the values of listed values from query
          {
            if(nicknameLabel.Text != null)
            nicknameLabel.Text = reader.GetString(0);
            if (profileLinkLabel.Text != null)
              profileLinkLabel.Text = reader.GetString(1);
            if (workplaceLabel.Text != null)
              workplaceLabel.Text = reader.GetString(2);
            if (phoneLabel.Text != null)
              phoneLabel.Text = reader.GetString(3);
            if (emailLabel.Text != null)
              emailLabel.Text = reader.GetString(4);
            break;
          }
          

          reader.Close();
          db.Close();
        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.Message);
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }



    private void menuButton_Click(object sender, EventArgs e)
    {
      this.Hide();
      MainMenuForm mainMenuForm = new MainMenuForm(currentUser);
      mainMenuForm.Width = this.Width;
      mainMenuForm.Height = this.Height;

      mainMenuForm.StartPosition = FormStartPosition.Manual;
      mainMenuForm.Location = new Point(this.Location.X, this.Location.Y);

      mainMenuForm.Closed += (s, args) => this.Close();
      mainMenuForm.Show();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      EditProfileForm editProfileForm = new EditProfileForm();
      editProfileForm.Width = this.Width;
      editProfileForm.Height = this.Height;

      editProfileForm.StartPosition = FormStartPosition.Manual;
      editProfileForm.Location = new Point(this.Location.X, this.Location.Y);

      this.Hide();
      editProfileForm.Show();
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
        profilePictureBox.Image = Bitmap.FromStream(stream);
      }
    }

    private void ProfileForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      Application.Exit();
    }
    private void ProfileForm_FormClosed(object sender, FormClosingEventArgs e)
    {
      Application.Exit();
    }

    private void nameLabel_Click(object sender, EventArgs e)
    {

    }

    private void ProfileForm_Load(object sender, EventArgs e)
    {
      resetView();
    }
  }
}