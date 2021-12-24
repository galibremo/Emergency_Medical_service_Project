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

namespace MedicalService.UserForms
{
    public partial class UserAccount : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["EMS"].ConnectionString;
        public UserAccount()
        {
            InitializeComponent();
        }
        void BindData()
        {
            try
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE User_Name=@User_Name", con);
                cmd.Parameters.AddWithValue("@User_Name", (ServiceUser.Uname));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                UsrAccDataGrid.DataSource = dt;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }
        private void UserPasswordReset_click(object sender, EventArgs e)
        {

        }

        private void UserPasswordReset_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserPassReset up = new UserPassReset();
            up.Show();
        }

        private void UserAccount_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE User_Name=@User_Name", con);
                cmd.Parameters.AddWithValue("@User_Name", (ServiceUser.Uname));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                UsrAccDataGrid.DataSource = dt;
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            
        }

        private void btnUsrAccUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Users SET User_Name=@User_Name, User_Email=@User_Email, User_Address=@User_Address, User_Mobile=@User_Mobile, User_Date_of_Birth=@User_Date_of_Birth WHERE User_Name=@User_Name", con);
                cmd.Parameters.AddWithValue("@User_Name", (UsrAccNametxt.Text));
                cmd.Parameters.AddWithValue("@User_Email", (UsrAccEmailtxt.Text));
                cmd.Parameters.AddWithValue("@User_Address", (UsrAccAddresstxt.Text));
                cmd.Parameters.AddWithValue("@User_Mobile", (UsrAccMobiletxt.Text));
                cmd.ExecuteNonQuery();
                con.Close();
                UsrAccNametxt.Text = "";
                UsrAccEmailtxt.Text = "";
                UsrAccAddresstxt.Text = "";
                UsrAccMobiletxt.Text = "";
                BindData();
                MessageBox.Show("Updated");
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            
        }

        private void UserAccountDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    UsrAccNametxt.Text = UsrAccDataGrid.SelectedRows[0].Cells["User_Name"].Value.ToString();
                    UsrAccEmailtxt.Text = UsrAccDataGrid.SelectedRows[0].Cells["User_Email"].Value.ToString();
                    UsrAccAddresstxt.Text = UsrAccDataGrid.SelectedRows[0].Cells["User_Address"].Value.ToString();
                    UsrAccMobiletxt.Text = UsrAccDataGrid.SelectedRows[0].Cells["User_Mobile"].Value.ToString();                    
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
