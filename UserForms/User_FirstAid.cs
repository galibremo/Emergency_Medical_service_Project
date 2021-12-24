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
    public partial class User_FirstAid : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["EMS"].ConnectionString;
        public User_FirstAid()
        {
            InitializeComponent();
        }
        void BindData()
        {
            try
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM FirstAids", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                UsrFirstAidDataGrid.DataSource = dt;
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            
        }
        private void UsrAidReq_Click(object sender, EventArgs e)
        {
            int stock = 0;
            int qty;
            qty = int.Parse(UserAidQuantityTxt.Text);
            try
            {
                if (UserAidPvrIDTxt.Text == "" || UserReqAidLabel.Text == "" || UserAidNameTxt.Text == "" || UserAidQuantityTxt.Text == "" || UserAidQuantityTxt.Text == "" || UserAidIDTxt.Text == "" || UserAidAddressTxt.Text == "" || UserAidMobileTxt.Text == "")
                {
                    MessageBox.Show("Please insert all the fields");
                }
                else
                {
                    SqlConnection con = new SqlConnection(cs);
                    con.Open();
                    string query = "SELECT User_Id, User_Name FROM Users WHERE User_Id= '" + UserAidIDTxt.Text.Trim() + "' and User_Name= '" + ServiceUser.Uname.Trim() + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                        SqlCommand cmd = new SqlCommand("SELECT * FROM  FirstAids WHERE Aid_Type=@Aid_Type", con);
                        cmd.Parameters.AddWithValue("@Aid_Type", (UserAidNameTxt.Text));
                        SqlDataAdapter sda1 = new SqlDataAdapter(cmd);
                        DataTable dt1 = new DataTable();
                        sda1.Fill(dt1);
                        cmd.ExecuteNonQuery();
                        foreach (DataRow dr1 in dt1.Rows)
                        {
                            stock = Convert.ToInt32(dr1["AidAvailable_Quantity"].ToString());
                        }   
                        if(qty>stock)
                        {
                            MessageBox.Show("Quantity Unavailable");    
                        }
                        else
                        {
                            SqlCommand cmd1 = new SqlCommand("INSERT INTO Requests (Provider_Id, Service_Type, Service_Name, Quantity_Request, Cost, User_Id, User_Address, User_Mobile) VALUES(@Provider_Id, @Service_Type, @Service_Name, @Quantity_Request, @Cost, @User_Id, @User_Address, @User_Mobile)", con);
                            cmd1.Parameters.AddWithValue("@Provider_Id", int.Parse((UserAidPvrIDTxt.Text)));
                            cmd1.Parameters.AddWithValue("@Service_Type", (UserReqAidLabel.Text));
                            cmd1.Parameters.AddWithValue("@Service_Name", (UserAidNameTxt.Text));
                            cmd1.Parameters.AddWithValue("@Quantity_Request", int.Parse(UserAidQuantityTxt.Text));
                            cmd1.Parameters.AddWithValue("@Cost", (int.Parse(UserAidPriceTag.Text) * int.Parse(UserAidQuantityTxt.Text)));
                            cmd1.Parameters.AddWithValue("@User_Id", int.Parse(UserAidIDTxt.Text));
                            cmd1.Parameters.AddWithValue("@User_Address", (UserAidAddressTxt.Text));
                            cmd1.Parameters.AddWithValue("@User_Mobile", (UserAidMobileTxt.Text));
                            cmd1.ExecuteNonQuery(); 

                            SqlCommand cmd2 = new SqlCommand("UPDATE FirstAids SET AidAvailable_Quantity = AidAvailable_Quantity-" + qty + "WHERE Aid_Type=@Aid_Type AND Provider_Id=@Provider_Id ", con);
                            cmd2.Parameters.AddWithValue("@Provider_Id", int.Parse((UserAidPvrIDTxt.Text)));
                            cmd2.Parameters.AddWithValue("@Aid_Type", (UserAidNameTxt.Text));
                            cmd2.ExecuteNonQuery();
                            con.Close();
                            UserAidPvrIDTxt.Text = "";
                            UserReqAidLabel.Text = "";
                            UserAidNameTxt.Text = "";
                            UserAidQuantityTxt.Text = "";
                            UserAidQuantityTxt.Text = "";
                            UserAidIDTxt.Text = "";
                            UserAidAddressTxt.Text = "";
                            UserAidMobileTxt.Text = "";
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

        private void User_FirstAid_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM FirstAids", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                UsrFirstAidDataGrid.DataSource = dt;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void UserAidGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    UserAidNameTxt.Text = UsrFirstAidDataGrid.SelectedRows[0].Cells["Aid_Type"].Value.ToString();
                    UserAidPriceTag.Text = UsrFirstAidDataGrid.SelectedRows[0].Cells["Aid_Price"].Value.ToString();
                    UserAidPvrIDTxt.Text = UsrFirstAidDataGrid.SelectedRows[0].Cells["Provider_Id"].Value.ToString();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
