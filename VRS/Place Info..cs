using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace VRS
{
    public partial class Form1 : Form
    {
        static string conn = "Data Source=.\\SQLEXPRESS;Initial Catalog=FVRS;Integrated Security=True";
        static SqlConnection sqlcon = new SqlConnection(conn);
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {

                if (sqlcon.State == ConnectionState.Closed) sqlcon.Open();
                int id = Int32.Parse(cls.CuridPlace);
                string query = "select pName , pDesc , pLoc , pRate ,pimg from place where pId=" + id.ToString() + "";
                SqlCommand cmd = new SqlCommand(query, sqlcon);
                SqlDataReader read = cmd.ExecuteReader();/* to show name in main window*/
                read.Read();
                lblName.Text = read[0].ToString();
                lbldesc.Text = read[1].ToString();
                lblLoc.Text = read[2].ToString();
                int i;
                 Int32.TryParse(read[3].ToString(), out i);
                rate.Value = i;

                var bytes = (byte[])read[4];
                using(MemoryStream ms = new MemoryStream(bytes))
                {
                    picBox.Image = Image.FromStream(ms);
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

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rate_button_Click(object sender, EventArgs e)
        {
            try
            {
                int oldRate , nofRate;

                if (sqlcon.State == ConnectionState.Closed) sqlcon.Open();
                int id = Int32.Parse(cls.CuridPlace);
                string query = "select  pRate ,nofRate from place where pId=" + id.ToString() + "";
                SqlCommand cmd = new SqlCommand(query, sqlcon);
                SqlDataReader read = cmd.ExecuteReader();/* to show name in main window*/
                read.Read();
                Int32.TryParse(read[0].ToString(), out oldRate);
                Int32.TryParse(read[1].ToString(), out nofRate);
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
                if (sqlcon.State == ConnectionState.Closed) sqlcon.Open();
                if (((oldRate * nofRate) + addRate.Value) % (nofRate + 1) != 0 && oldRate < 5)
                {
                    oldRate = ((oldRate * nofRate) + addRate.Value) / ++nofRate;
                    ++oldRate;
                }
                else
                {
                    oldRate = ((oldRate * nofRate) + addRate.Value) / ++nofRate;
                }
                cmd.CommandText = "update place set pRate  =" + oldRate + " , nofRate="+nofRate+"";
                cmd.ExecuteNonQuery();
                addRate.Value = oldRate;
                addRate.Enabled = false;
                rate_button.Enabled = false;



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

        private void picBox_Click(object sender, EventArgs e)
        {

        }
    }
}
