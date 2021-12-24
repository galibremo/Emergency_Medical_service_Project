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
    public partial class UserBilling : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["EMS"].ConnectionString;
        public UserBilling()
        {
            InitializeComponent();
        }

        private void UserTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        void BindData()
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT Provider_Id,User_Id,Service_Name,Quantity_Request,Cost,Payment FROM Requests WHERE User_Id=@User_Id", con);
            cmd.Parameters.AddWithValue("@User_Id", (UserBillUserIdTxt.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            UserBillingDataGrid.DataSource = dt;
        }

        private void UserPay_Click(object sender, EventArgs e)
        {
            try
            {
                if (UserBillUserIdTxt.Text == "" || UserBillPvdId.Text == "" || UserBillServiceName.Text == "" || UserAccNumTxt.Text == "")
                {
                    MessageBox.Show("Please insert all the fields");
                }
                else
                {
                    SqlConnection con = new SqlConnection(cs);
                    con.Open();
                    string query = "SELECT User_Id, User_Name FROM Users WHERE User_Id= '" + UserBillUserIdTxt.Text.Trim() + "' and User_Name= '" + ServiceUser.Uname.Trim() + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                        SqlCommand cmd = new SqlCommand("UPDATE Requests SET Payment='Done' WHERE User_Id=@User_Id AND Provider_Id=@Provider_Id AND Service_Name=@Service_Name", con);
                        cmd.Parameters.AddWithValue("@User_Id", (UserBillUserIdTxt.Text));
                        cmd.Parameters.AddWithValue("@Provider_Id", (UserBillPvdId.Text));
                        cmd.Parameters.AddWithValue("@Service_Name", (UserBillServiceName.Text));
                        cmd.ExecuteNonQuery();
                        con.Close();
                        UserBillPvdId.Text = "";
                        UserBillServiceName.Text = "";
                        UserAccNumTxt.Text = "";
                        BindData();
                        MessageBox.Show("Payment Completed");
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

        private void UserBilling_Load(object sender, EventArgs e)
        {
            
        }

        private void UserBillSearch_Click(object sender, EventArgs e)
        {

            try
            {
                if (UserBillUserIdTxt.Text == "")
                {
                    MessageBox.Show("Please insert your id");
                }
                else {
                    SqlConnection con = new SqlConnection(cs);
                    con.Open();
                    string query = "SELECT User_Id, User_Name FROM Users WHERE User_Id= '" + UserBillUserIdTxt.Text.Trim() + "' and User_Name= '" + ServiceUser.Uname.Trim() + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                        SqlCommand cmd = new SqlCommand("SELECT Provider_Id,User_Id,Service_Name,Quantity_Request,Cost,Payment FROM Requests WHERE User_Id=@User_Id", con);
                        cmd.Parameters.AddWithValue("@User_Id", (UserBillUserIdTxt.Text));
                        cmd.Parameters.AddWithValue("@Provider_Id", (UserBillPvdId.Text));
                        cmd.Parameters.AddWithValue("@Service_Name", (UserBillServiceName.Text));
                        cmd.ExecuteNonQuery();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dts = new DataTable();
                        da.Fill(dts);
                        UserBillingDataGrid.DataSource = dts;
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

        private void UserBillingDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    UserBillUserIdTxt.Text = UserBillingDataGrid.SelectedRows[0].Cells["User_Id"].Value.ToString();
                    UserBillPvdId.Text = UserBillingDataGrid.SelectedRows[0].Cells["Provider_Id"].Value.ToString();
                    UserBillServiceName.Text = UserBillingDataGrid.SelectedRows[0].Cells["Service_Name"].Value.ToString();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }
    }
}
