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
    public partial class AdminUsers : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["EMS"].ConnectionString;
        public AdminUsers()
        {
            InitializeComponent();
        }

        private void AdminUsrDataCell_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                AdminUserIdtxt.Text = AdminUserDataGrid.SelectedRows[0].Cells["User_Id"].Value.ToString();
            }
        }
        void BindData()
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Users", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            AdminUserDataGrid.DataSource = dt;
        }
        private void AdminUsers_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Users", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            AdminUserDataGrid.DataSource = dt;
        }

        private void btnAdminUserSearch_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE User_Id=@User_Id", con);
                cmd.Parameters.AddWithValue("@User_Id", (AdminUserSrchtxt.Text));
                AdminUserIdtxt.Text = AdminUserSrchtxt.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                AdminUserDataGrid.DataSource = dt;
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnAdminUserDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE Users WHERE User_Id=@User_Id", con);
                cmd.Parameters.AddWithValue("@User_Id", (AdminUserIdtxt.Text));
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
