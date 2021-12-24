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
    public partial class AdminMediators : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["EMS"].ConnectionString;
        public AdminMediators()
        {
            InitializeComponent();
        }

        private void AdminMedDataCell_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                AdminMedIdtxt.Text = AdminMedDataGrid.SelectedRows[0].Cells["Mediator_Id"].Value.ToString();
            }
        }
        void BindData()
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Mediators", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            AdminMedDataGrid.DataSource = dt;
        }
        private void AdminMediators_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Mediators", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            AdminMedDataGrid.DataSource = dt;
        }

        private void btnAdminMedSearch_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Mediators WHERE Mediator_Id=@Mediator_Id", con);
                cmd.Parameters.AddWithValue("@Mediator_Id", (AdminMedSrchtxt.Text));
                AdminMedIdtxt.Text = AdminMedSrchtxt.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                AdminMedDataGrid.DataSource = dt;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnAdminMedDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE Mediators WHERE Mediator_Id=@Mediator_Id", con);
                cmd.Parameters.AddWithValue("@Mediator_Id", (AdminMedIdtxt.Text));
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
