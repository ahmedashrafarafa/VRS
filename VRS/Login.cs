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
    public partial class Login : Form
    {
      //  static string conn = "Data Source=.\\SQLEXPRESS;Initial Catalog=FVRS;Integrated Security=True";
        static string conn = "Data Source=.\\SQLEXPRESS;Initial Catalog=FVRS;Integrated Security=True;MultipleActiveResultSets=true";
        static SqlConnection sqlcon = new SqlConnection(conn);
        public Login()
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
        private void login_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (Username_Box.Text == "" || password_Box.Text == "")
                {
                    MessageBox.Show("Please enter username and password", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    if (sqlcon.State == ConnectionState.Closed) sqlcon.Open();

                    DataTable dt = new DataTable();
                    string query = "select * from userData where username='" + Username_Box.Text.Trim() + "' and password='" + password_Box.Text.Trim() + "'";
                    SqlCommand cmd = new SqlCommand(query, sqlcon);
                    SqlDataAdapter adapt = new SqlDataAdapter();

                    adapt.SelectCommand = cmd;
                    adapt.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {

                        cmd = new SqlCommand("select userID, firstname  from userData where username='" + Username_Box.Text.Trim() + "'", sqlcon);
                        SqlDataReader read = cmd.ExecuteReader();
                        read.Read();
                       
                        int admin_ID;
                        Int32.TryParse(read[0].ToString(), out admin_ID);
                        SqlCommand cmd2 = new SqlCommand("select adminUseID  from admin where adminUseID='" + admin_ID + "'",sqlcon);

                        SqlDataReader read2 = cmd2.ExecuteReader();
                     
                        read2.Read();
                        if (read2.HasRows)
  
                        {
                            Admin_Page frm = new Admin_Page();
                            frm.Show();
                            this.Close();
                        }
                        else
                        {
                            cls.CurUserID = read[0].ToString();
                            cls.name = read[1].ToString();


                            Main_Page main = new Main_Page();
                            main.Show();
                            this.Close();
                        }

                    }
                    else
                    {
                        MessageBox.Show("invalid username or password", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Username_Box.Focus();
                        Username_Box.SelectAll();
                        password_Box.Text = "";
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

        private void forget_password_Click(object sender, EventArgs e)
        {
            Forget_Passwordpage forget = new Forget_Passwordpage();
            forget.Show();
            this.Close();
        }

        private void regist_page_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Close();
        }

        private void hidePassButton_Click(object sender, EventArgs e)
        {

            if (password_Box.UseSystemPasswordChar == true)
            {
                password_Box.UseSystemPasswordChar = false;
            }
            else
            {
                password_Box.UseSystemPasswordChar = true;
            }
        }

        private void password_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            password_Box.UseSystemPasswordChar = true;
        }
    }
    
}
