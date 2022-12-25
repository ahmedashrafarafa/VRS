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
    public partial class Admin_Page : Form
    {
        static string connect = "Data Source=.\\SQLEXPRESS;Initial Catalog=FVRS;Integrated Security=True";
        SqlConnection conn = new SqlConnection(connect);
        public Admin_Page()
        {
            InitializeComponent();
        }

        private void Admin_Page_Load(object sender, EventArgs e)
        {

        }

        private void users_button_Click(object sender, EventArgs e)
        {
            Users user = new Users();
            user.Show();
        }

        private void requset_button_Click(object sender, EventArgs e)
        {
            RequestAdmin req = new RequestAdmin();
            req.Show();
            
        }

        private void places_button_Click(object sender, EventArgs e)
        {
            Places place = new Places();
            place.Show();
        }

        private void addplaces_button_Click(object sender, EventArgs e)
        {
            Add_Places addplace = new Add_Places();
            addplace.Show();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
