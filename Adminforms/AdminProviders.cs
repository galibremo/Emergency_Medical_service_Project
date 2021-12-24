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
    public partial class AdminProviders : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["EMS"].ConnectionString;
        public AdminProviders()
        {
            InitializeComponent();
        }

        private void AdminPvdDataCell_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                AdminPvdIdtxt.Text = AdminPvdDataGrid.SelectedRows[0].Cells["Provider_Id"].Value.ToString();
            }
        }
        void BindData()
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Providers", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            AdminPvdDataGrid.DataSource = dt;
        }
        private void AdminProviders_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Providers", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            AdminPvdDataGrid.DataSource = dt;

        }

        private void btnAdminPvdSearch_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Providers WHERE Provider_Id=@Provider_Id", con);
                cmd.Parameters.AddWithValue("@Provider_Id", (AdminPvdSrchtxt.Text));
                AdminPvdIdtxt.Text = AdminPvdSrchtxt.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                AdminPvdDataGrid.DataSource = dt;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnAdminPvdDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE Providers WHERE Provider_Id=@Provider_Id", con);
                cmd.Parameters.AddWithValue("@Provider_Id", (AdminPvdIdtxt.Text));
                cmd.ExecuteNonQuery();
                con.Close();
                BindData();
                MessageBox.Show("Deleted");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
