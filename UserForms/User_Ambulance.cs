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
    public partial class User_Ambulance : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["EMS"].ConnectionString;
        public User_Ambulance()
        {
            InitializeComponent();
        }
        void BindData()
        {
            try
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Ambulances", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                UsrAmbDataGrid.DataSource = dt;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            
        }
        private void UsrAmbulanceReq_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (UserAmbPvrIDTxt.Text == "" || UserReqAmbLabel.Text == "" || UserAmbCatagoryTxt.Text == "" || UserAmbQuantityTxt.Text == "" || UserAmbPriceTag.Text == "" || UserAmbUserIdTxt.Text == "" || UserAmbAddressTxt.Text == "" || UserAmbMobileTxt.Text == "")
                {
                    MessageBox.Show("Please insert all the fields");
                }
                else
                {
                    SqlConnection con = new SqlConnection(cs);
                    con.Open();
                    string query = "SELECT User_Id, User_Name FROM Users WHERE User_Id= '" + UserAmbUserIdTxt.Text.Trim() + "' and User_Name= '" + ServiceUser.Uname.Trim() + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                        SqlCommand cmd = new SqlCommand("INSERT INTO Requests (Provider_Id, Service_Type, Service_Name, Quantity_Request, Cost, User_Id, User_Address, User_Mobile) VALUES(@Provider_Id, @Service_Type, @Service_Name, @Quantity_Request, @Cost, @User_Id, @User_Address, @User_Mobile)", con);
                        cmd.Parameters.AddWithValue("@Provider_Id", int.Parse((UserAmbPvrIDTxt.Text)));
                        cmd.Parameters.AddWithValue("@Service_Type", (UserReqAmbLabel.Text));
                        cmd.Parameters.AddWithValue("@Service_Name", (UserAmbCatagoryTxt.Text));
                        cmd.Parameters.AddWithValue("@Quantity_Request", int.Parse(UserAmbQuantityTxt.Text));
                        cmd.Parameters.AddWithValue("@Cost", (int.Parse(UserAmbPriceTag.Text) * int.Parse(UserAmbQuantityTxt.Text)));
                        cmd.Parameters.AddWithValue("@User_Id", int.Parse(UserAmbUserIdTxt.Text));
                        cmd.Parameters.AddWithValue("@User_Address", (UserAmbAddressTxt.Text));
                        cmd.Parameters.AddWithValue("@User_Mobile", (UserAmbMobileTxt.Text));
                        cmd.ExecuteNonQuery();
                        con.Close();
                        UserAmbPvrIDTxt.Text = "";
                        UserReqAmbLabel.Text = "";
                        UserAmbCatagoryTxt.Text = "";
                        UserAmbQuantityTxt.Text = "";
                        UserAmbPriceTag.Text = "";
                        UserAmbUserIdTxt.Text = "";
                        UserAmbAddressTxt.Text = "";
                        UserAmbMobileTxt.Text = "";
                        BindData();
                        MessageBox.Show("Requested");
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
        private void PvdIDAmbtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void PvdAmbCatagorytxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void User_Ambulance_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Ambulances", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                UsrAmbDataGrid.DataSource = dt;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }

        private void UserAmbGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    UserAmbCatagoryTxt.Text = UsrAmbDataGrid.SelectedRows[0].Cells["Catagory"].Value.ToString();
                    UserAmbPriceTag.Text = UsrAmbDataGrid.SelectedRows[0].Cells["Cost"].Value.ToString();
                    UserAmbPvrIDTxt.Text = UsrAmbDataGrid.SelectedRows[0].Cells["Provider_Id"].Value.ToString();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
