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
    public partial class Places : Form
    {
        static string connect = "Data Source=.\\SQLEXPRESS;Initial Catalog=FVRS;Integrated Security=True";
        SqlConnection conn = new SqlConnection(connect);
        public Places()
        {
            InitializeComponent();
        }

        private void Places_Load(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlDataAdapter adp = new SqlDataAdapter("select * from place", conn);
                DataTable dp = new DataTable();
                adp.Fill(dp);
                
                dataGridView1.DataSource = dp;

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                placeid_box.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                placename_box.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                description_box.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                location_box.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                bunifuTextBox2.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                var bytes = (byte[])dataGridView1.CurrentRow.Cells[1].Value;
                using (MemoryStream ms = new MemoryStream(bytes))
                {
                    pictureBox1.Image = Image.FromStream(ms);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            int current_index = dataGridView1.CurrentCell.RowIndex;
            string current_id = dataGridView1.Rows[current_index].Cells[0].Value.ToString();
            int result = Int32.Parse(current_id);
            string delete = @"delete  from place where pId=" + result + ";";
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlCommand cmd = new SqlCommand(delete, conn);
            try
            {
                cmd.ExecuteNonQuery();
                dataGridView1.Rows.RemoveAt(current_index);
                MessageBox.Show("deleted successfully");
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

        private void edit_button_Click(object sender, EventArgs e)
        {
            int current_index = dataGridView1.CurrentCell.RowIndex;
            string current_id = dataGridView1.Rows[current_index].Cells[0].Value.ToString();
            int result = Int32.Parse(current_id);
            string update = @"update place set pName='" + placename_box + "' ,pLoc='" + location_box + "' ,pDesc='" + description_box + "' where  pId='" + result + "'";
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlCommand cmd = new SqlCommand(update, conn);
            try
            {
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("changed successfully");
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

        private void back_button_Click(object sender, EventArgs e)
        {
            Admin_Page frm = new Admin_Page();
            frm.Show();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
