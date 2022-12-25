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
using System.IO;
using System.Drawing.Imaging;
namespace VRS
{
    public partial class Users : Form
    {
        static string connect = "Data Source=.\\SQLEXPRESS;Initial Catalog=FVRS;Integrated Security=True";
        SqlConnection conn = new SqlConnection(connect);
        public Users()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {

        }

        private void user_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            try
            {
            int current_index = user_table.CurrentCell.RowIndex;
            string current_id = user_table.Rows[current_index].Cells[0].Value.ToString();
            int result = Int32.Parse(current_id);

            if (conn.State == ConnectionState.Closed) conn.Open();
            //string delete1=@"delete from reqPlace where userID='"+result+"';";
            string delete = @"delete  from userData where userID='" + result + "';";
            SqlCommand cmd = new SqlCommand(delete, conn);
               // SqlCommand cmd1 = new SqlCommand(delete1, conn);
                cmd.ExecuteNonQuery();
                //cmd1.ExecuteNonQuery();
                user_table.Rows.RemoveAt(current_index);
                MessageBox.Show("delete successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }

        private void makeadmin_button_Click(object sender, EventArgs e)
        {
            try
            {
                int current_index = user_table.CurrentCell.RowIndex;
                string current_id = user_table.Rows[current_index].Cells[0].Value.ToString();
                 int result = Int32.Parse(current_id);
                
                string insert = "insert into admin (adminUseID) values(" + result + ")";
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlCommand comm = new SqlCommand(insert, conn);
                comm.ExecuteNonQuery();
                MessageBox.Show("Great! :) He Is Admin Now xD");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Admin_Page frm = new Admin_Page();
            frm.Show();
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                string add = @" select userID,firstname,lastname,username,address,gender from userData";
                SqlDataAdapter adp = new SqlDataAdapter(add, conn);
                DataTable dp = new DataTable();
                adp.Fill(dp);
                user_table.DataSource = dp;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }
    }
}
