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
    public partial class UserSearch : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["EMS"].ConnectionString;
        public UserSearch()
        {
            InitializeComponent();
        }

        private void UserSearch_Load(object sender, EventArgs e)
        {
            Search11("");
        }

        public void Search11(String valSearch)
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string query = "SELECT * FROM Medicines, Tools, FirstAids, Ambulances WHERE CONCAT(Medicine_Name, Tool_Name, Aid_Type, Catagory) like '%"+valSearch +"%'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            UserSearchDataGrid.DataSource = dt;

        }
        private void UserSrch_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                string query1 = "SELECT Medicine_Name FROM Medicines WHERE Medicine_Name= '" + UserHomeSrchtxt.Text.Trim() + "'";
                string query2 = "SELECT Tool_Name FROM Tools WHERE Tool_Name= '" + UserHomeSrchtxt.Text.Trim() + "'";
                string query3 = "SELECT Aid_Type FROM FirstAids WHERE Aid_Type= '" + UserHomeSrchtxt.Text.Trim() + "'";
                string query4 = "SELECT Catagory FROM Ambulances WHERE Catagory= '" + UserHomeSrchtxt.Text.Trim() + "'";
                SqlDataAdapter sda1 = new SqlDataAdapter(query1, con);
                SqlDataAdapter sda2 = new SqlDataAdapter(query2, con);
                SqlDataAdapter sda3 = new SqlDataAdapter(query3, con);
                SqlDataAdapter sda4 = new SqlDataAdapter(query4, con);
                DataTable dt1 = new DataTable();
                DataTable dt2 = new DataTable();
                DataTable dt3 = new DataTable();
                DataTable dt4 = new DataTable();
                sda1.Fill(dt1);
                sda2.Fill(dt2);
                sda3.Fill(dt3);
                sda4.Fill(dt4);
                if (dt1.Rows.Count > 0)
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Medicines WHERE Medicine_Name=@Medicine_Name", con);
                    cmd.Parameters.AddWithValue("@Medicine_Name", (UserHomeSrchtxt.Text));
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dts = new DataTable();
                    da.Fill(dts);
                    UserSearchDataGrid.DataSource = dts;
                 
                }
                else if (dt2.Rows.Count > 0)
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Tools WHERE Tool_Name=@Tool_Name", con);
                    cmd.Parameters.AddWithValue("@Tool_Name", (UserHomeSrchtxt.Text));
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dts = new DataTable();
                    da.Fill(dts);
                    UserSearchDataGrid.DataSource = dts;
                  
                }
                else if (dt3.Rows.Count > 0)
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM FirstAids WHERE Aid_Type=@Aid_Type", con);
                    cmd.Parameters.AddWithValue("@Aid_Type", (UserHomeSrchtxt.Text));
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dts = new DataTable();
                    da.Fill(dts);
                    UserSearchDataGrid.DataSource = dts;
                 
                }
                else if (dt4.Rows.Count > 0)
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Ambulances WHERE Catagory=@Catagory", con);
                    cmd.Parameters.AddWithValue("@Catagory", (UserHomeSrchtxt.Text));
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dts = new DataTable();
                    da.Fill(dts);
                    UserSearchDataGrid.DataSource = dts;
                  
                }
                else
                {
                    MessageBox.Show("No results");
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void UserSrchtxt_Click(object sender, EventArgs e)
        {
            if (UserHomeSrchtxt.Text == "Search in your services")
            {
                UserHomeSrchtxt.Clear();
            }
        }

        private void UserSearchReq_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                string query = "SELECT User_Id, User_Name FROM Users WHERE User_Id= '" + UserSearchUserIdTxt.Text.Trim() + "' and User_Name= '" + ServiceUser.Uname.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Requests (Provider_Id, Service_Type, Service_Name, Quantity_Request, Cost, User_Id, User_Address, User_Mobile) VALUES(@Provider_Id,'Unknown', @Service_Name, @Quantity_Request, @Cost, @User_Id, @User_Address, @User_Mobile)", con);
                    cmd.Parameters.AddWithValue("@Provider_Id", (UserSearchPvdIDTxt.Text));
                    cmd.Parameters.AddWithValue("@Service_Name", (UserSearchNameTxt.Text));
                    cmd.Parameters.AddWithValue("@Quantity_Request", (UserSearchQuantityTxt.Text));
                    cmd.Parameters.AddWithValue("@Cost", int.Parse(UserSearchPriceTag.Text) * int.Parse(UserSearchQuantityTxt.Text));
                    cmd.Parameters.AddWithValue("@User_Id", (UserSearchUserIdTxt.Text));
                    cmd.Parameters.AddWithValue("@User_Address", (UserSearchAddressTxt.Text));
                    cmd.Parameters.AddWithValue("@User_Mobile", (UserSearchMobileTxt.Text));
                    cmd.ExecuteNonQuery();
                    con.Close();
                    UserSearchPvdIDTxt.Text = "";
                    UserSearchNameTxt.Text = "";
                    UserSearchQuantityTxt.Text = "";
                    UserSearchUserIdTxt.Text = "";
                    UserSearchAddressTxt.Text = "";
                    UserSearchMobileTxt.Text = "";
                    UserSearchPriceTag.Text = "";
                    MessageBox.Show("Requested");
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

        private void UserSearchDataCell_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                UserSearchPvdIDTxt.Text = UserSearchDataGrid.SelectedRows[0].Cells[0].Value.ToString();
                UserSearchNameTxt.Text = UserSearchDataGrid.SelectedRows[0].Cells[1].Value.ToString();
                UserSearchPriceTag.Text = UserSearchDataGrid.SelectedRows[0].Cells[3].Value.ToString();
            }
        }
    }
}
