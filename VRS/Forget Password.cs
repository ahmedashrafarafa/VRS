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
    public partial class Forget_Passwordpage : Form
    {
        static string conn = "Data Source=.\\SQLEXPRESS;Initial Catalog=FVRS;Integrated Security=True";
        static SqlConnection sqlcon = new SqlConnection(conn);
        public Forget_Passwordpage()
        {
            InitializeComponent();
        }

        private void bunifuGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms[0].Show();
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (username_box.Text == "" || password_box.Text == "" || repassword_box.Text == "" || answer_box.Text == "")
                {
                    MessageBox.Show("Please fill all fields", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    username_box.Select();
                }
                else if (password_box.Text.Length < 8)
                {
                    MessageBox.Show("Password should be 8 digits or more", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    password_box.Focus();
                    password_box.SelectAll();
                }
                else if (password_box.Text != repassword_box.Text)
                {
                    MessageBox.Show("Password dont match", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    password_box.Focus();
                    password_box.SelectAll();
                }

                else
                {
                    if (sqlcon.State == ConnectionState.Closed) sqlcon.Open();


                    DataTable dt = new DataTable();
                    SqlDataAdapter adapt = new SqlDataAdapter();

                    SqlCommand cmd = new SqlCommand("ForgetPass", sqlcon);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@username", username_box.Text);
                    cmd.Parameters.AddWithValue("@answer", answer_box.Text);
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
                    adapt.SelectCommand = cmd;
                    adapt.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {

                        DataTable dt2 = new DataTable();
                        SqlDataAdapter adapt2 = new SqlDataAdapter();
                        string query2 = "UPDATE userData SET password = '" + password_box.Text.Trim() + "' WHERE username = '" + username_box.Text.Trim() + "'";
                        SqlCommand cmd2 = new SqlCommand(query2, sqlcon);


                        if (cmd2.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Successful change password", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Login frm = new Login();
                            frm.Show();
                            this.Close();
                            clear();
                        }
                        else
                        {
                            MessageBox.Show("Error in chanage password", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            username_box.SelectAll();
                            username_box.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Your data is incorrect");
                        username_box.SelectAll();
                        username_box.Focus();
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
            //this.Close();
            //Application.OpenForms[0].Show();
        }
        void clear()
        {
          username_box.Text = password_box.Text = repassword_box.Text  = answer_box.Text = "";
           

        }

        private void Forget_Passwordpage_Load(object sender, EventArgs e)
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
    }
}
