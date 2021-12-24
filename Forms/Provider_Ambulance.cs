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

namespace MedicalService.Forms
{
    public partial class Provider_Ambulance : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["EMS"].ConnectionString;
        public Provider_Ambulance()
        {
            InitializeComponent();
        }
        void BindData()
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Ambulances WHERE Provider_Id=@Provider_Id", con);
            cmd.Parameters.AddWithValue("@Provider_Id", (PvdIDAmbtxt.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            PvdAmbDataGrid.DataSource = dt;
        }
        private void PvdAmbUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                string query = "SELECT Provider_Id, Name FROM Providers WHERE Provider_Id= '" + PvdIDAmbtxt.Text.Trim() + "' and Name= '" + Provider.labelName.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    if (PvdIDAmbtxt.Text == "" || PvdAmbCatagorytxt.Text == "")
                    {
                        MessageBox.Show("Please insert all the fields");
                    }
                    else if (PvdAmbQuantitytxt.Text == "")
                    {
                        SqlCommand cmd = new SqlCommand("UPDATE Ambulances SET Catagory=@Catagory, Cost=@Cost WHERE Catagory=@Catagory", con);
                        cmd.Parameters.AddWithValue("@Catagory", (PvdAmbCatagorytxt.Text));
                        cmd.Parameters.AddWithValue("@Cost", (PvdAmbCost.Text));
                        cmd.ExecuteNonQuery();
                        con.Close();
                        PvdAmbCatagorytxt.Text = "";
                        PvdAmbQuantitytxt.Text = "";
                        PvdAmbCost.Text = "";
                        BindData();
                        MessageBox.Show("Updated");
                    }
                    else if (PvdAmbCost.Text == "")
                    {
                        SqlCommand cmd = new SqlCommand("UPDATE Ambulances SET Catagory=@Catagory, AAvailable_Quantity=@AAvailable_Quantity WHERE Catagory=@Catagory", con);
                        cmd.Parameters.AddWithValue("@Catagory", (PvdAmbCatagorytxt.Text));
                        cmd.Parameters.AddWithValue("@AAvailable_Quantity", (PvdAmbQuantitytxt.Text));
                        cmd.ExecuteNonQuery();
                        con.Close();
                        PvdAmbCatagorytxt.Text = "";
                        PvdAmbQuantitytxt.Text = "";
                        PvdAmbCost.Text = "";
                        BindData();
                        MessageBox.Show("Updated");
                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand("UPDATE Ambulances SET Provider_Id=@Provider_Id, Catagory=@Catagory, AAvailable_Quantity=@AAvailable_Quantity, Cost=@Cost WHERE Catagory=@Catagory", con);
                        cmd.Parameters.AddWithValue("@Provider_Id", (PvdIDAmbtxt.Text));
                        cmd.Parameters.AddWithValue("@Catagory", (PvdAmbCatagorytxt.Text));
                        cmd.Parameters.AddWithValue("@AAvailable_Quantity", (PvdAmbQuantitytxt.Text));
                        cmd.Parameters.AddWithValue("@Cost", (PvdAmbCost.Text));
                        cmd.ExecuteNonQuery();
                        PvdAmbCatagorytxt.Text = "";
                        PvdAmbQuantitytxt.Text = "";
                        PvdAmbCost.Text = "";
                        BindData();
                        MessageBox.Show("Updated");
                    }
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

        private void PvdAmbDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                string query = "SELECT Provider_Id, Name FROM Providers WHERE Provider_Id= '" + PvdIDAmbtxt.Text.Trim() + "' and Name= '" + Provider.labelName.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    SqlCommand cmd = new SqlCommand("DELETE Ambulances WHERE Catagory=@Catagory", con);
                    cmd.Parameters.AddWithValue("@Catagory", (PvdAmbCatagorytxt.Text));
                    cmd.ExecuteNonQuery();
                    con.Close();
                    PvdAmbCatagorytxt.Text = "";
                    PvdAmbQuantitytxt.Text = "";
                    PvdAmbCost.Text = "";
                    BindData();
                    MessageBox.Show("Deleted");
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

        private void PvdAmbInsert_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                string query = "SELECT Provider_Id, Name FROM Providers WHERE Provider_Id= '" + PvdIDAmbtxt.Text.Trim() + "' and Name= '" + Provider.labelName.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    if (PvdIDAmbtxt.Text == "" || PvdAmbCost.Text == "" || PvdAmbCatagorytxt.Text == "" || PvdAmbQuantitytxt.Text == "")
                    {
                        MessageBox.Show("Please insert all the fields");
                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand("INSERT INTO Ambulances (Provider_Id, Catagory, AAvailable_Quantity, Cost) VALUES(@Provider_Id, @Catagory, @AAvailable_Quantity, @Cost)", con);
                        cmd.Parameters.AddWithValue("@Provider_Id", (PvdIDAmbtxt.Text));
                        cmd.Parameters.AddWithValue("@Catagory", (PvdAmbCatagorytxt.Text));
                        cmd.Parameters.AddWithValue("@AAvailable_Quantity", (PvdAmbQuantitytxt.Text));
                        cmd.Parameters.AddWithValue("@Cost", (PvdAmbCost.Text));
                        cmd.ExecuteNonQuery();
                        con.Close();
                        PvdAmbCatagorytxt.Text = "";
                        PvdAmbQuantitytxt.Text = "";
                        PvdAmbCost.Text = "";
                        BindData();
                        MessageBox.Show("Inserted");
                    }
                }
                else
                {
                    MessageBox.Show("Inserted ID is not associated with your account");
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void PvdAmbCatagorytxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Provider_Ambulance_Load(object sender, EventArgs e)
        {
            /*SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Ambulances WHERE @Name=Name", con);
            cmd.Parameters.AddWithValue("@Name", (Provider.labelName));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            PvdAmbDataGrid.DataSource = dt;*/
        }

        private void PvdAmbCheck_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                string query = "SELECT Provider_Id, Name FROM Providers WHERE Provider_Id= '" + PvdIDAmbtxt.Text.Trim() + "' and Name= '" + Provider.labelName.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Ambulances WHERE @Provider_Id=Provider_Id", con);
                    cmd.Parameters.AddWithValue("@Provider_Id", (PvdIDAmbtxt.Text));
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dts = new DataTable();
                    da.Fill(dts);
                    PvdAmbDataGrid.DataSource = dts;
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

        private void PvdAmbSearch_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                String query = "SELECT Provider_Id, Name FROM Providers WHERE Provider_Id= '" + PvdIDAmbtxt.Text.Trim() + "' and Name= '" + Provider.labelName.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Ambulances WHERE Provider_Id=@Provider_Id And Catagory=@Catagory", con);
                    cmd.Parameters.AddWithValue("@Provider_Id", (PvdIDAmbtxt.Text));
                    cmd.Parameters.AddWithValue("@Catagory", (PvdAmbSearchtxt.Text));
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dts = new DataTable();
                    da.Fill(dts);
                    PvdAmbDataGrid.DataSource = dts;
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

        private void PvdAmdDataCell_Click(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                PvdIDAmbtxt.Text = PvdAmbDataGrid.SelectedRows[0].Cells["Provider_Id"].Value.ToString();
                PvdAmbCatagorytxt.Text = PvdAmbDataGrid.SelectedRows[0].Cells["Catagory"].Value.ToString();
                PvdAmbQuantitytxt.Text = PvdAmbDataGrid.SelectedRows[0].Cells["AAvailable_Quantity"].Value.ToString();
                PvdAmbCost.Text = PvdAmbDataGrid.SelectedRows[0].Cells["Cost"].Value.ToString();
               
            }
        }
    }
}
