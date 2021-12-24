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
    public partial class User_Tools : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["EMS"].ConnectionString;
        public User_Tools()
        {
            InitializeComponent();
        }
        void BindData()
        {
            try
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Tools", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                UsrToolsDataGrid.DataSource = dt;
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            
        }
        private void UsrToolsReq_Click(object sender, EventArgs e)
        {
            int stock = 0;
            int qty;
            qty = int.Parse(UserToolsQuantityTxt.Text);
            try
            {
                if (UserToolsPvrIDTxt.Text == "" || UserReqToolsLabel.Text == "" || UserToolsNameTxt.Text == "" || UserToolsQuantityTxt.Text == "" || UserToolsPriceTag.Text == "" || UserToolsUserIdTxt.Text == "" || UserToolsAddressTxt.Text == "" || UserToolsMobileTxt.Text == "")
                {
                    MessageBox.Show("Please insert all the fields");
                }
                else
                {
                    SqlConnection con = new SqlConnection(cs);
                    con.Open();
                    string query = "SELECT User_Id, User_Name FROM Users WHERE User_Id= '" + UserToolsUserIdTxt.Text.Trim() + "' and User_Name= '" + ServiceUser.Uname.Trim() + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                        SqlCommand cmd = new SqlCommand("SELECT * FROM Tools WHERE Tool_Name=@Tool_Name", con);
                        cmd.Parameters.AddWithValue("@Tool_Name", (UserToolsNameTxt.Text));
                        SqlDataAdapter sda1 = new SqlDataAdapter(cmd);
                        DataTable dt1 = new DataTable();
                        sda1.Fill(dt1);
                        cmd.ExecuteNonQuery();
                        foreach (DataRow dr1 in dt1.Rows)
                        {
                            stock = Convert.ToInt32(dr1["TAvailable_Quantity"].ToString());
                        }
                        if (qty > stock)
                        {
                            MessageBox.Show("Quantity Unavailable");
                        }
                        else
                        {
                            SqlCommand cmd1 = new SqlCommand("INSERT INTO Requests (Provider_Id, Service_Type, Service_Name, Quantity_Request, Cost, User_Id, User_Address, User_Mobile) VALUES(@Provider_Id, @Service_Type, @Service_Name, @Quantity_Request, @Cost, @User_Id, @User_Address, @User_Mobile)", con);
                            cmd1.Parameters.AddWithValue("@Provider_Id", int.Parse((UserToolsPvrIDTxt.Text)));
                            cmd1.Parameters.AddWithValue("@Service_Type", (UserReqToolsLabel.Text));
                            cmd1.Parameters.AddWithValue("@Service_Name", (UserToolsNameTxt.Text));
                            cmd1.Parameters.AddWithValue("@Quantity_Request", int.Parse(UserToolsQuantityTxt.Text));
                            cmd1.Parameters.AddWithValue("@Cost", (int.Parse(UserToolsPriceTag.Text) * int.Parse(UserToolsQuantityTxt.Text)));
                            cmd1.Parameters.AddWithValue("@User_Id", int.Parse(UserToolsUserIdTxt.Text));
                            cmd1.Parameters.AddWithValue("@User_Address", (UserToolsAddressTxt.Text));
                            cmd1.Parameters.AddWithValue("@User_Mobile", (UserToolsMobileTxt.Text));
                            cmd1.ExecuteNonQuery();
                            SqlCommand cmd2 = new SqlCommand("UPDATE Tools SET TAvailable_Quantity = TAvailable_Quantity-" + qty + "WHERE Tool_Name=@Tool_Name AND Provider_Id=@Provider_Id ", con);
                            cmd2.Parameters.AddWithValue("@Provider_Id", int.Parse((UserToolsPvrIDTxt.Text)));
                            cmd2.Parameters.AddWithValue("@Tool_Name", (UserToolsNameTxt.Text));
                            cmd2.ExecuteNonQuery();
                            con.Close();
                            UserToolsPvrIDTxt.Text = "";
                            UserReqToolsLabel.Text = "";
                            UserToolsNameTxt.Text = "";
                            UserToolsQuantityTxt.Text = "";
                            UserToolsPriceTag.Text = "";
                            UserToolsUserIdTxt.Text = "";
                            UserToolsAddressTxt.Text = "";
                            UserToolsMobileTxt.Text = "";
                            BindData();
                            MessageBox.Show("Requested");
                        }
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

        private void User_Tools_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Tools", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                UsrToolsDataGrid.DataSource = dt;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void UserToolsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    UserToolsNameTxt.Text = UsrToolsDataGrid.SelectedRows[0].Cells["Tool_Name"].Value.ToString();
                    UserToolsPriceTag.Text = UsrToolsDataGrid.SelectedRows[0].Cells["Tool_Price"].Value.ToString();
                    UserToolsPvrIDTxt.Text = UsrToolsDataGrid.SelectedRows[0].Cells["Provider_Id"].Value.ToString();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
