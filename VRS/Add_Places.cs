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
    public partial class Add_Places : Form
    {
        static string connect = "Data Source=.\\SQLEXPRESS;Initial Catalog=FVRS;Integrated Security=True";
        SqlConnection conn = new SqlConnection(connect);
        public Add_Places()
        {
            InitializeComponent();
        }

        private void Add_Places_Load(object sender, EventArgs e)
        {

        }
        string image_location = "";
        private void addimage_button_Click(object sender, EventArgs e)
        {

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|all files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                image_location = dialog.FileName.ToString();
                pictureBox1.ImageLocation = image_location;
            }
        }

        private void addplace_button_Click(object sender, EventArgs e)
        {
            int admin_id = 1;
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                byte[] img = null;
                FileStream str = new FileStream(image_location, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(str);
                img = br.ReadBytes((int)str.Length);

                string add_place = "insert into place(pImg,pName,pLoc,pDesc,pRate,nofRate)" +
                    "VALUES(@img,'" + placename_box.Text.Trim() + "','" + location_box.Text.Trim() + "','" + description_box.Text.Trim() + "',0,0)";
                SqlCommand cmd = new SqlCommand(add_place, conn);
                cmd.Parameters.AddWithValue("@img", img);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("added  successfully");
                clear();

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
        void clear()
        {
            location_box.Text = placename_box.Text = description_box.Text = "";
            pictureBox1.Image = new PictureBox().Image;
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
    }
}
