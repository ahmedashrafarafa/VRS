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
    public partial class RequestAdmin : Form
    {
        static string connect = "Data Source=.\\SQLEXPRESS;Initial Catalog=FVRS;Integrated Security=True";
        SqlConnection conn = new SqlConnection(connect);
        public RequestAdmin()
        {
            InitializeComponent();
        }

        private void RequestAdmin_Load(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                SqlDataAdapter adp = new SqlDataAdapter("select * from reqPlace", conn);
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

        private void makeadmin_button_Click(object sender, EventArgs e)
        {
            try
            {
            int current_index = user_table.CurrentCell.RowIndex;
            string current_id = user_table.Rows[current_index].Cells[0].Value.ToString();
            int result = Int32.Parse(current_id);

            if (conn.State == ConnectionState.Closed) conn.Open();
            string delete = @"delete  from  reqPlace where rqid='" + result + "';";
            SqlCommand cmd = new SqlCommand(delete, conn);
                cmd.ExecuteNonQuery();
                user_table.Rows.RemoveAt(current_index);
                MessageBox.Show("delete successful");
                clear();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }

        private void user_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bunifuTextBox1.Text = user_table.CurrentRow.Cells[0].Value.ToString();
            bunifuTextBox2.Text = user_table.CurrentRow.Cells[4].Value.ToString();
            bunifuTextBox3.Text = user_table.CurrentRow.Cells[2].Value.ToString();
            bunifuTextBox4.Text = user_table.CurrentRow.Cells[3].Value.ToString();

            var bytes = (byte[])user_table.CurrentRow.Cells[1].Value;
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                pictureBox1.Image = Image.FromStream(ms);
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            try
            {
            int current_index = user_table.CurrentCell.RowIndex;
             string current_name = user_table.Rows[current_index].Cells[2].Value.ToString();
              string current_id = user_table.Rows[current_index].Cells[0].Value.ToString();
            int result = Int32.Parse(current_id);
            string accept = @"insert into place(pName,pLoc,pDesc,pImg)
                            select rqName,rqLoc,rqDesc,rqImg from reqPlace where rqid='" +result+ "'";
                string delete = @"delete  from  reqPlace where rqid='" + result + "';";
                if (conn.State == ConnectionState.Closed) conn.Open();
            SqlCommand cmd = new SqlCommand(accept, conn);
            SqlCommand cmd1 = new SqlCommand(delete, conn);
                cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
                clear();
                user_table.Rows.RemoveAt(current_index);
                MessageBox.Show("Added successfully");
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
        void clear()
        {
            bunifuTextBox1.Text = bunifuTextBox2.Text = bunifuTextBox3.Text = bunifuTextBox4.Text = "";
            pictureBox1.Image = new PictureBox().Image;
        }
    }
}
