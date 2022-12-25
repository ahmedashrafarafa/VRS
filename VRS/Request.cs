using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
namespace VRS
{
    public partial class Request : Form
    {
        static string conn = "Data Source=.\\SQLEXPRESS;Initial Catalog=FVRS;Integrated Security=True";
        static SqlConnection sqlcon = new SqlConnection(conn);
        public Request()
        {
            InitializeComponent();
        }

        private void bunifuGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

            string imgLoc = "";
        private void select_button_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog opf = new OpenFileDialog();
                opf.Filter = "Images|*.jpg;*.png";
                opf.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                if (opf.ShowDialog() == DialogResult.OK)
                {

                    imgLoc = opf.FileName.ToString();
                    picBox.ImageLocation = imgLoc;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (placename_Box.Text == "" || placelocation_box.Text == "" || description_box.Text == "" || picBox.Image == new PictureBox().Image)
                {
                    MessageBox.Show("Please fill all fields", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (sqlcon.State == ConnectionState.Closed) sqlcon.Open();
                    byte[] img = null;
                    FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);/*to read image*/
                    BinaryReader br = new BinaryReader(fs);
                    img = br.ReadBytes((int)fs.Length);
                    int curUserId = Int32.Parse(cls.CurUserID);
                    string query = @"insert into reqPlace (rqName,rqDesc,rqLoc,rqImg,userID)" +
                                    " values('" + placename_Box.Text.Trim() + "','" + description_box.Text.Trim() + "'," +
                                    "'" + placelocation_box.Text.Trim() + "',@img," + curUserId + ")";

                    SqlCommand cmd = new SqlCommand(query, sqlcon);
                    cmd.Parameters.AddWithValue("@img", img);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successful Adding place ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    clear();
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
            placelocation_box.Text = placename_Box.Text = description_box.Text = "";
            picBox.Image = new PictureBox().Image;
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
