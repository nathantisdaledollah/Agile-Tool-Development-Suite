﻿using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace AgileDevelopmentToolsSuite
{
    public partial class SkillSetForm : Form
    {
        public SkillSetForm()
        {
            InitializeComponent();
        }

        private void radioButton29_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection db;

            String version = "MSSQLLocalDB";
            String fileName = "ADTSDLoginInfo.mdf";
            String connectionString = String.Format(@"Data Source=(LocalDB)\{0};AttachDbFilename=|DataDirectory|\{1};Initial Catalog=ADSTDLoginInfo;Integrated Security=True;MultipleActiveResultSets=True", version, fileName);

            db = new SqlConnection(connectionString);

            SqlCommand insertSkills = new SqlCommand("INSERT INTO Users ([Skill1], [Skill2], [Skill3], [Skill4], [Skill5], [Skill6], [Skill7], [Skill8], [Skill9], [Skill10]) VALUES (@s1, @s2, @s3, @s4, @s5, @s6, @s7, @s8, @s9, @s10)");
            SqlCommand insertProficiencies = new SqlCommand("INSERT INTO Users ([SkillProficiency1], [SkillProficiency2], [SkillProficiency3], [SkillProficiency4], [SkillProficiency5], [SkillProficiency6], [SkillProficiency7], [SkillProficiency8], [SkillProficiency9], [SkillProficiency10]) VALUES (@sp1, @sp2, @sp3, @sp4, @sp5, @sp6, @sp7, @sp8, @sp9, @sp10)");

            insertSkills.Connection = db;
            insertProficiencies.Connection = db;

            try
            {

                db.Open();

                try
                {
                    //insert skills from each text box
                    insertSkills.Parameters.AddWithValue("@s1", skill1.Text);
                    insertSkills.Parameters.AddWithValue("@s2", skill2.Text);
                    insertSkills.Parameters.AddWithValue("@s3", skill3.Text);
                    insertSkills.Parameters.AddWithValue("@s4", skill4.Text);
                    insertSkills.Parameters.AddWithValue("@s5", skill5.Text);
                    insertSkills.Parameters.AddWithValue("@s6", skill6.Text);
                    insertSkills.Parameters.AddWithValue("@s7", skill7.Text);
                    insertSkills.Parameters.AddWithValue("@s8", skill8.Text);
                    insertSkills.Parameters.AddWithValue("@s9", skill9.Text);
                    insertSkills.Parameters.AddWithValue("@s10", skill10.Text);

                    insertSkills.ExecuteNonQuery();

                    //check skill 1 proficiency
                    if (radioButton1.Checked == true)
                        insertProficiencies.Parameters.AddWithValue("@sp1", "Master");
                    else if (radioButton2.Checked == true)
                        insertProficiencies.Parameters.AddWithValue("@sp1", "Proficient");
                    else if (radioButton3.Checked == true)
                        insertProficiencies.Parameters.AddWithValue("@sp1", "Beginner");
                    else
                        insertProficiencies.Parameters.AddWithValue("@sp1", "N/A");

                    //check skill 2 proficiency
                    if (radioButton5.Checked == true)
                        insertProficiencies.Parameters.AddWithValue("@sp2", "Master");
                    else if (radioButton6.Checked == true)
                        insertProficiencies.Parameters.AddWithValue("@sp2", "Proficient");
                    else if (radioButton7.Checked == true)
                        insertProficiencies.Parameters.AddWithValue("@sp2", "Beginner");
                    else
                        insertProficiencies.Parameters.AddWithValue("@sp2", "N/A");

                    //check skill 3 proficiency
                    if (radioButton9.Checked == true)
                        insertProficiencies.Parameters.AddWithValue("@sp3", "Master");
                    else if (radioButton10.Checked == true)
                        insertProficiencies.Parameters.AddWithValue("@sp3", "Proficient");
                    else if (radioButton11.Checked == true)
                        insertProficiencies.Parameters.AddWithValue("@sp3", "Beginner");
                    else
                        insertProficiencies.Parameters.AddWithValue("@sp3", "N/A");

                    //check skill 4 proficiency
                    if (radioButton13.Checked == true)
                        insertProficiencies.Parameters.AddWithValue("@sp4", "Master");
                    else if (radioButton14.Checked == true)
                        insertProficiencies.Parameters.AddWithValue("@sp4", "Proficient");
                    else if (radioButton15.Checked == true)
                        insertProficiencies.Parameters.AddWithValue("@sp4", "Beginner");
                    else
                        insertProficiencies.Parameters.AddWithValue("@sp4", "N/A");

                    //check skill 5 proficiency
                    if (radioButton17.Checked == true)
                        insertProficiencies.Parameters.AddWithValue("@sp5", "Master");
                    else if (radioButton18.Checked == true)
                        insertProficiencies.Parameters.AddWithValue("@sp5", "Proficient");
                    else if (radioButton19.Checked == true)
                        insertProficiencies.Parameters.AddWithValue("@sp5", "Beginner");
                    else
                        insertProficiencies.Parameters.AddWithValue("@sp5", "N/A");

                    //check skill 6 proficiency
                    if (radioButton21.Checked == true)
                        insertProficiencies.Parameters.AddWithValue("@sp6", "Master");
                    else if (radioButton22.Checked == true)
                        insertProficiencies.Parameters.AddWithValue("@sp6", "Proficient");
                    else if (radioButton23.Checked == true)
                        insertProficiencies.Parameters.AddWithValue("@sp6", "Beginner");
                    else
                        insertProficiencies.Parameters.AddWithValue("@sp6", "N/A");

                    //check skill 7 proficiency
                    if (radioButton25.Checked == true)
                        insertProficiencies.Parameters.AddWithValue("@sp7", "Master");
                    else if (radioButton26.Checked == true)
                        insertProficiencies.Parameters.AddWithValue("@sp7", "Proficient");
                    else if (radioButton27.Checked == true)
                        insertProficiencies.Parameters.AddWithValue("@sp7", "Beginner");
                    else
                        insertProficiencies.Parameters.AddWithValue("@sp7", "N/A");

                    //check skill 8 proficiency
                    if (radioButton29.Checked == true)
                        insertProficiencies.Parameters.AddWithValue("@sp8", "Master");
                    else if (radioButton30.Checked == true)
                        insertProficiencies.Parameters.AddWithValue("@sp8", "Proficient");
                    else if (radioButton31.Checked == true)
                        insertProficiencies.Parameters.AddWithValue("@sp8", "Beginner");
                    else
                        insertProficiencies.Parameters.AddWithValue("@sp8", "N/A");

                    //check skill 9 proficiency
                    if (radioButton33.Checked == true)
                        insertProficiencies.Parameters.AddWithValue("@sp9", "Master");
                    else if (radioButton34.Checked == true)
                        insertProficiencies.Parameters.AddWithValue("@sp9", "Proficient");
                    else if (radioButton35.Checked == true)
                        insertProficiencies.Parameters.AddWithValue("@sp9", "Beginner");
                    else
                        insertProficiencies.Parameters.AddWithValue("@sp9", "N/A");

                    //check skill 10 proficiency
                    if (radioButton37.Checked == true)
                        insertProficiencies.Parameters.AddWithValue("@sp10", "Master");
                    else if (radioButton38.Checked == true)
                        insertProficiencies.Parameters.AddWithValue("@sp10", "Proficient");
                    else if (radioButton39.Checked == true)
                        insertProficiencies.Parameters.AddWithValue("@sp10", "Beginner");
                    else
                        insertProficiencies.Parameters.AddWithValue("@sp10", "N/A");

                    insertProficiencies.ExecuteNonQuery();

                    MainMenuForm mainMenuForm = new MainMenuForm();
                    mainMenuForm.Width = this.Width;
                    mainMenuForm.Height = this.Height;

                    mainMenuForm.StartPosition = FormStartPosition.Manual;
                    mainMenuForm.Location = new Point(this.Location.X, this.Location.Y);

                    this.Hide();
                    mainMenuForm.Show();

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Connection unsuccessful, please try again. ");
            }
        }
    }
}
