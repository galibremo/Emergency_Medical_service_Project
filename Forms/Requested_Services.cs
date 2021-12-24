using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalService.Forms
{
    public partial class Requested_Services : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["EMS"].ConnectionString;
        public Requested_Services()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        void BindData()
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Requests WHERE Provider_Id=@Provider_Id", con);
            cmd.Parameters.AddWithValue("@Provider_Id", (PvdIdReqChecktxt.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            RequestedDataGrid.DataSource = dt;
        }

        private void PvdReqCheck_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                string query = "SELECT Provider_Id, Name FROM Providers WHERE Provider_Id= '" + PvdIdReqChecktxt.Text.Trim() + "' and Name= '" + Provider.labelName.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Requests WHERE Provider_Id=@Provider_Id", con);
                    cmd.Parameters.AddWithValue("@Provider_Id", (PvdIdReqChecktxt.Text));
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dts = new DataTable();
                    da.Fill(dts);
                    RequestedDataGrid.DataSource = dts;
                    string queryy = "SELECT Provider_Id FROM Requests WHERE Provider_Id = '" + PvdIdReqChecktxt.Text.Trim() + "'";
                    SqlDataAdapter sdaa = new SqlDataAdapter(queryy, con);
                    DataTable dt2 = new DataTable();
                    sdaa.Fill(dt2);
                    PvdPendingReqtxt.Text = Convert.ToString(dt2.Rows.Count);

                }
               else
              {
                   MessageBox.Show("Inserted ID is not associated with your account");
               }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void PvdReqSuccess_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE Requests WHERE Provider_Id=@Provider_Id AND User_Id=@User_Id AND Service_Name=@Service_Name", con);
                cmd.Parameters.AddWithValue("@Provider_Id", (PvdIdReqChecktxt.Text));
                cmd.ExecuteNonQuery();
                con.Close();
                BindData();
                MessageBox.Show("Request successfull");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void ReqDataGrid_Click(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void UsrIDToolsLbl_Click(object sender, EventArgs e)
        {

        }

        private void ReqMedNametxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
