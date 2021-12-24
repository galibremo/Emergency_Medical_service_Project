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
    public partial class UserRequests : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["EMS"].ConnectionString;
        public UserRequests()
        {
            InitializeComponent();
        }
        void BindData()
        {
            try
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT User_Id,Provider_Id,Service_Type,Service_Name,Quantity_Request,Cost FROM Requests WHERE User_Id=@User_Id", con);
                cmd.Parameters.AddWithValue("@User_Id", (ReqUserIdtxt.Text));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                UserRequestsDataGrid.DataSource = dt;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        private void UserRequestsUpdate_click(object sender, EventArgs e)
        {
          /*  try
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Requests SET Quantity_Request=@Quantity_Request WHERE User_Mobile=@User_Mobile", con);
                cmd.Parameters.AddWithValue("@User_Mobile", (ReqUserIdtxt.Text));
                cmd.Parameters.AddWithValue("@Quantity_Request", (UserReqQuantitytxt.Text));
                cmd.ExecuteNonQuery();
                con.Close();
                ReqUserIdtxt.Text = "";
                UserReqQuantitytxt.Text = "";
                BindData();
                MessageBox.Show("Updated");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }*/
        }

        private void UserRequestsEdit_Click(object sender, EventArgs e)
        {
            
        }

        private void UserRequestsDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (UserReqPvdIDtxt.Text == "" || UserSerNamTxt.Text == "" || UserReqTypetxt.Text == "" || UserReqQuantitytxt.Text == "" || ReqUserIdtxt.Text == "")
                {
                    MessageBox.Show("Please insert all the fields");
                }
                else
                {
                    SqlConnection con = new SqlConnection(cs);
                    con.Open();
                    string query = "SELECT User_Id, User_Name FROM Users WHERE User_Id= '" + ReqUserIdtxt.Text.Trim() + "' and User_Name= '" + ServiceUser.Uname.Trim() + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                        SqlCommand cmd = new SqlCommand("DELETE Requests WHERE User_Id=@User_Id AND Provider_Id=@Provider_Id AND Service_Name=@Service_Name", con);
                        cmd.Parameters.AddWithValue("@User_Id", (ReqUserIdtxt.Text));
                        cmd.Parameters.AddWithValue("@Provider_Id", (UserReqPvdIDtxt.Text));
                        cmd.Parameters.AddWithValue("@Service_Name", (UserSerNamTxt.Text));
                        cmd.ExecuteNonQuery();
                        con.Close();
                        UserReqPvdIDtxt.Text = "";
                        UserSerNamTxt.Text = "";
                        UserReqTypetxt.Text = "";
                        UserReqQuantitytxt.Text = "";
                        UserReqCosttxt.Text = "";
                        BindData();
                        ReqUserIdtxt.Text = "";
                        MessageBox.Show("Deleted");
                    }
                    else
                    {
                        MessageBox.Show("Inserted ID is not associated with your account");
                    }
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void UserRequests_Load(object sender, EventArgs e)
        {
           /* try
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Requests", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                UserRequestsDataGrid.DataSource = dt;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }*/
        }

        private void UserQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserMyReqCheck_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                string query = "SELECT User_Id, User_Name FROM Users WHERE User_Id= '" + ReqUserIdtxt.Text.Trim() + "' and User_Name= '" + ServiceUser.Uname.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    SqlCommand cmd = new SqlCommand("SELECT User_Id,Provider_Id,Service_Type,Service_Name,Quantity_Request,Cost FROM Requests WHERE User_Id=@User_Id", con);
                    cmd.Parameters.AddWithValue("@User_Id", (ReqUserIdtxt.Text));
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dts = new DataTable();
                    da.Fill(dts);
                    UserRequestsDataGrid.DataSource = dts;
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

        private void UserMyReqDataGrid_Click(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    ReqUserIdtxt.Text = UserRequestsDataGrid.SelectedRows[0].Cells["User_Id"].Value.ToString();
                    UserReqPvdIDtxt.Text = UserRequestsDataGrid.SelectedRows[0].Cells["Provider_Id"].Value.ToString();
                    UserSerNamTxt.Text = UserRequestsDataGrid.SelectedRows[0].Cells["Service_Name"].Value.ToString();
                    UserReqTypetxt.Text = UserRequestsDataGrid.SelectedRows[0].Cells["Service_Type"].Value.ToString();
                    UserReqQuantitytxt.Text = UserRequestsDataGrid.SelectedRows[0].Cells["Quantity_Request"].Value.ToString();
                    UserReqCosttxt.Text = UserRequestsDataGrid.SelectedRows[0].Cells["Cost"].Value.ToString();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
