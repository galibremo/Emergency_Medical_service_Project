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

namespace MedicalService.Adminforms
{
    public partial class AdminService : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["EMS"].ConnectionString;
        public AdminService()
        {
            InitializeComponent();
        }

        private void AdminReqDataGridCell_Click(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAdminReqSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if ((AdminReqPvdIdtxt.Text == "" || AdminReqSvcNametxt.Text == "") && AdminReqUserIdtxt.Text != "")
                {
                    SqlConnection con = new SqlConnection(cs);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Requests WHERE User_Id=@User_Id", con);
                    cmd.Parameters.AddWithValue("@User_Id", (AdminReqUserIdtxt.Text));
                    cmd.ExecuteNonQuery();
                    con.Close();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dts = new DataTable();
                    da.Fill(dts);
                    AdminReqDataGrid.DataSource = dts;
                   
                }
                else if ((AdminReqSvcNametxt.Text == "" || AdminReqUserIdtxt.Text == "") && AdminReqPvdIdtxt.Text != "")
                {
                    SqlConnection con = new SqlConnection(cs);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Requests WHERE Provider_Id=@Provider_Id", con);
                    cmd.Parameters.AddWithValue("@Provider_Id", (AdminReqPvdIdtxt.Text));
                    cmd.ExecuteNonQuery();
                    con.Close();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dts = new DataTable();
                    da.Fill(dts);
                    AdminReqDataGrid.DataSource = dts;
                  
                }
                else if ((AdminReqUserIdtxt.Text == "" || AdminReqPvdIdtxt.Text == "") && AdminReqSvcNametxt.Text != "")
                {
                    SqlConnection con = new SqlConnection(cs);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Requests WHERE Service_Name=@Service_Name", con);
                    cmd.Parameters.AddWithValue("@Service_Name", (AdminReqSvcNametxt.Text));
                    cmd.ExecuteNonQuery();
                    con.Close();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dts = new DataTable();
                    da.Fill(dts);
                    AdminReqDataGrid.DataSource = dts;
                   
                }
                else if (AdminReqPvdIdtxt.Text == "")
                {
                    SqlConnection con = new SqlConnection(cs);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Requests WHERE Service_Name=@Service_Name AND User_Id=@User_Id", con);
                    cmd.Parameters.AddWithValue("@User_Id", (AdminReqUserIdtxt.Text));
                    cmd.Parameters.AddWithValue("@Service_Name", (AdminReqSvcNametxt.Text));
                    cmd.ExecuteNonQuery();
                    con.Close();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dts = new DataTable();
                    da.Fill(dts);
                    AdminReqDataGrid.DataSource = dts;
                    
                }
                 else if (AdminReqUserIdtxt.Text == "")
                {
                    SqlConnection con = new SqlConnection(cs);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Requests WHERE Provider_Id=@Provider_Id AND Service_Name=@Service_Name", con);
                    cmd.Parameters.AddWithValue("@Provider_Id", (AdminReqPvdIdtxt.Text));
                    cmd.Parameters.AddWithValue("@Service_Name", (AdminReqSvcNametxt.Text));
                    cmd.ExecuteNonQuery();
                    con.Close();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dts = new DataTable();
                    da.Fill(dts);
                    AdminReqDataGrid.DataSource = dts;
                    
                }
                else if (AdminReqSvcNametxt.Text == "")
                {
                    SqlConnection con = new SqlConnection(cs);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Requests WHERE User_Id=@User_Id AND Provider_Id=@Provider_Id", con);
                    cmd.Parameters.AddWithValue("@User_Id", (AdminReqUserIdtxt.Text));
                    cmd.Parameters.AddWithValue("@Provider_Id", (AdminReqPvdIdtxt.Text));
                    cmd.ExecuteNonQuery();
                    con.Close();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dts = new DataTable();
                    da.Fill(dts);
                    AdminReqDataGrid.DataSource = dts;
                 
                }
                else
                {
                    SqlConnection con = new SqlConnection(cs);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Requests WHERE User_Id=@User_Id AND Provider_Id=@Provider_Id AND Service_Name=@Service_Name", con);
                    cmd.Parameters.AddWithValue("@User_Id", (AdminReqUserIdtxt.Text));
                    cmd.Parameters.AddWithValue("@Provider_Id", (AdminReqPvdIdtxt.Text));
                    cmd.Parameters.AddWithValue("@Service_Name", (AdminReqSvcNametxt.Text));
                    cmd.ExecuteNonQuery();
                    con.Close();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dts = new DataTable();
                    da.Fill(dts);
                    AdminReqDataGrid.DataSource = dts;
                 
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }

        private void AdminService_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Requests", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            AdminReqDataGrid.DataSource = dt;
        }
    }
}
