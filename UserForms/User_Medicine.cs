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
    public partial class User_Medicine : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["EMS"].ConnectionString;
        public User_Medicine()
        {
            InitializeComponent();
        }
        void BindData()
        {
            try
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Medicines", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                UsrMdcDataGrid.DataSource = dt;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        private void UsrMedicineReq_Click(object sender, EventArgs e)
        {
            int stock = 0;
            int qty;
            qty = int.Parse(UserMedicineQuantityTxt.Text);
            try
            {
                if (UserMedicinePvrIDTxt.Text == "" || UserReqMedicineLabel.Text == "" || UserMedicineNameTxt.Text == "" || UserMedicineQuantityTxt.Text == "" || UserMedicinePriceTag.Text == "" || UserMedicineUserIdTxt.Text == "" || UserMedicineAddressTxt.Text == "" || UserMedicineMobileTxt.Text == "")
                {
                    MessageBox.Show("Please insert all the fields");
                }
                else
                {
                    SqlConnection con = new SqlConnection(cs);
                    con.Open();
                    string query = "SELECT User_Id, User_Name FROM Users WHERE User_Id= '" + UserMedicineUserIdTxt.Text.Trim() + "' and User_Name= '" + ServiceUser.Uname.Trim() + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                        SqlCommand cmd = new SqlCommand("SELECT * FROM  Medicines WHERE Medicine_Name=@Medicine_Name", con);
                        cmd.Parameters.AddWithValue("@Medicine_Name", (UserMedicineNameTxt.Text));
                        SqlDataAdapter sda1 = new SqlDataAdapter(cmd);
                        DataTable dt1 = new DataTable();
                        sda1.Fill(dt1);
                        cmd.ExecuteNonQuery();
                        foreach (DataRow dr1 in dt1.Rows)
                        {
                            stock = Convert.ToInt32(dr1["MAvailable_Quantity"].ToString());
                        }
                        if (qty > stock)
                        {
                            MessageBox.Show("Quantity Unavailable");
                        }
                        else
                        {
                            SqlCommand cmd1 = new SqlCommand("INSERT INTO Requests (Provider_Id, Service_Type, Service_Name, Quantity_Request, Cost, User_Id, User_Address, User_Mobile) VALUES(@Provider_Id, @Service_Type, @Service_Name, @Quantity_Request, @Cost, @User_Id, @User_Address, @User_Mobile)", con);
                            cmd1.Parameters.AddWithValue("@Provider_Id", int.Parse((UserMedicinePvrIDTxt.Text)));
                            cmd1.Parameters.AddWithValue("@Service_Type", (UserReqMedicineLabel.Text));
                            cmd1.Parameters.AddWithValue("@Service_Name", (UserMedicineNameTxt.Text));
                            cmd1.Parameters.AddWithValue("@Quantity_Request", int.Parse(UserMedicineQuantityTxt.Text));
                            cmd1.Parameters.AddWithValue("@Cost", (int.Parse(UserMedicinePriceTag.Text) * int.Parse(UserMedicineQuantityTxt.Text)));
                            cmd1.Parameters.AddWithValue("@User_Id", int.Parse(UserMedicineUserIdTxt.Text));
                            cmd1.Parameters.AddWithValue("@User_Address", (UserMedicineAddressTxt.Text));
                            cmd1.Parameters.AddWithValue("@User_Mobile", (UserMedicineMobileTxt.Text));
                            cmd1.ExecuteNonQuery();
                            SqlCommand cmd2 = new SqlCommand("UPDATE Medicines SET MAvailable_Quantity = MAvailable_Quantity-" + qty + "WHERE Medicine_Name=@Medicine_Name AND Provider_Id=@Provider_Id ", con);
                            cmd2.Parameters.AddWithValue("@Provider_Id", int.Parse((UserMedicinePvrIDTxt.Text)));
                            cmd2.Parameters.AddWithValue("@Medicine_Name", (UserMedicineNameTxt.Text));
                            cmd2.ExecuteNonQuery();
                            con.Close();
                            UserMedicinePvrIDTxt.Text = "";
                            UserReqMedicineLabel.Text = "";
                            UserMedicineNameTxt.Text = "";
                            UserMedicineQuantityTxt.Text = "";
                            UserMedicinePriceTag.Text = "";
                            UserMedicineUserIdTxt.Text = "";
                            UserMedicineAddressTxt.Text = "";
                            UserMedicineMobileTxt.Text = "";
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
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            
        }

        private void User_Medicine_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Medicines", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                UsrMdcDataGrid.DataSource = dt;
            }           
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void UserDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    UserMedicineNameTxt.Text = UsrMdcDataGrid.SelectedRows[0].Cells["Medicine_Name"].Value.ToString();
                    UserMedicinePriceTag.Text = UsrMdcDataGrid.SelectedRows[0].Cells["Medicine_Price"].Value.ToString();
                    UserMedicinePvrIDTxt.Text = UsrMdcDataGrid.SelectedRows[0].Cells["Provider_Id"].Value.ToString();
                }
            }           
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
