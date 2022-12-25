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
    public partial class Main_Page : Form
    {
        static string conn = "Data Source=.\\SQLEXPRESS;Initial Catalog=FVRS;Integrated Security=True";
        static SqlConnection sqlcon = new SqlConnection(conn);
        public Main_Page()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        bool menuIsOpen = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (menuIsOpen)
            {
                menu.Width -= 10;/*to open and close menu*/
                if (menu.Width == 50)
                {
                    timer1.Stop();
                    menuIsOpen = false;
                }
            }
            else
            {
                menu.Width += 10;
                if (menu.Width == 200)
                {
                    timer1.Stop();
                    menuIsOpen = true;
                }
            }
        }

        private void menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Main_Page_Load(object sender, EventArgs e)
        {
            try
            {
                name_label.Text = cls.name;
                string query = "select pImg ,pId from place order by pRate";
               
                SqlDataAdapter adapt = new SqlDataAdapter(query, sqlcon);
                DataTable dt = new DataTable();
                sqlcon.Open();
                adapt.Fill(dt);
                sqlcon.Close();
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            Application.Exit();  
        }

        private void request_button_Click(object sender, EventArgs e)
        {
            Request frm = new Request();
            frm.Show();
            
        }

        private void edit_profilebtn_Click(object sender, EventArgs e)
        {
            Edit_Profile frm = new Edit_Profile();
            frm.Show();

        }

        private void dgv_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = dgv.CurrentCell.RowIndex;
            string current_id = dgv.Rows[index].Cells[1].Value.ToString();
            cls.CuridPlace = current_id;
            Form1 frm = new Form1();
            frm.Show();
            /* Form1 ===>>> place info*/
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
