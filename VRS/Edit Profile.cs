using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace VRS
{
    public partial class Edit_Profile : Form
    {

        static string conn = "Data Source=.\\SQLEXPRESS;Initial Catalog=FVRS;Integrated Security=True";
        static SqlConnection sqlcon = new SqlConnection(conn);
        public Edit_Profile()
        {
            InitializeComponent();
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void update_button_Click(object sender, EventArgs e)
        {

            try
            {

                if (fnameBox.Text == "" || lname_box.Text == "" || username_box.Text == "" || password_box.Text == "" || repassword_box.Text == "" || address_box.Text == "" || answer_box.Text == "" || (male_radio.Checked == false && female_radio.Checked == false))
                {
                    MessageBox.Show("Please fill all fields", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    fnameBox.Select();
                }
                else if (password_box.Text.Length < 8)
                {
                    MessageBox.Show("Password should be 8 digits or more", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    password_box.Focus();
                    password_box.SelectAll();
                }
                else if (password_box.Text != repassword_box.Text)
                {
                    MessageBox.Show("Password dont match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    password_box.Focus();
                    password_box.SelectAll();
                }

                else
                {
                    if (sqlcon.State == ConnectionState.Closed) sqlcon.Open();
                    if (!usernameexist())
                    {
                        MessageBox.Show("Your username is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        username_box.Focus();
                        username_box.SelectAll();
                    }
                    else
                    {

                        SqlCommand cmd = new SqlCommand("UpdateData", sqlcon);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@firstname", fnameBox.Text.Trim());
                        cmd.Parameters.AddWithValue("@lastname", lname_box.Text.Trim());
                        cmd.Parameters.AddWithValue("@username", username_box.Text.Trim());
                        cmd.Parameters.AddWithValue("@password", password_box.Text.Trim());
                        cmd.Parameters.AddWithValue("@adress", address_box.Text.Trim());
                        cmd.Parameters.AddWithValue("@answer", answer_box.Text.Trim());
                        
                        if (comboQues.SelectedIndex == 0)
                        {
                            cmd.Parameters.AddWithValue("@question", 1);
                        }
                        else if (comboQues.SelectedIndex == 1)
                        {

                            cmd.Parameters.AddWithValue("@question", 2);
                        }
                        else
                        {

                            cmd.Parameters.AddWithValue("@question", 3);
                        }


                        if (male_radio.Checked)
                        {
                            cmd.Parameters.AddWithValue("@gender", "male");
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@gender", "female");
                        }
                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Successful ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clear();
                            this.Close();

                        }
                        else
                        {
                            MessageBox.Show("Error in Editing your profile", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            fnameBox.Select();
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();

            }
        }
        void clear()
        {
            fnameBox.Text = lname_box.Text = username_box.Text = password_box.Text = repassword_box.Text = address_box.Text = answer_box.Text = "";
            male_radio.Checked = false;
            female_radio.Checked = false;

        }
        bool usernameexist()
        {
            if (sqlcon.State == ConnectionState.Closed) sqlcon.Open();


            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter();
            string query = "select * from userData where username='" + username_box.Text + "'";
            SqlCommand cmd = new SqlCommand(query, sqlcon);

            adapt.SelectCommand = cmd;
            adapt.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void update_button_Load(object sender, EventArgs e)
        {
            
        }

        private void Edit_Profile_Load(object sender, EventArgs e)
        {
            comboQues.SelectedIndex = 0;
            password_box.UseSystemPasswordChar = true;
            repassword_box.UseSystemPasswordChar = true;
        }

        private void hidePassButton_Click(object sender, EventArgs e)
        {
            if (password_box.UseSystemPasswordChar == true)
            {
                password_box.UseSystemPasswordChar = false;
                repassword_box.UseSystemPasswordChar = false;
            }
            else
            {
                password_box.UseSystemPasswordChar = true;
                repassword_box.UseSystemPasswordChar = true;
            }
        }

        private void repassword_box_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
