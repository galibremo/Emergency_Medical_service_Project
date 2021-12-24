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
    public partial class Provider_FirstAid : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["EMS"].ConnectionString;
        public Provider_FirstAid()
        {
            InitializeComponent();
        }
        void BindData()
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM FirstAids WHERE Provider_Id=@Provider_Id", con);
            cmd.Parameters.AddWithValue("@Provider_Id", (PvdIDAidtxt.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            PvdFirstAidDataGrid.DataSource = dt;
        }

        private void PvdAidUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                string query = "SELECT Provider_Id, Name FROM Providers WHERE Provider_Id= '" + PvdIDAidtxt.Text.Trim() + "' and Name= '" + Provider.labelName.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    if (PvdIDAidtxt.Text == "" || PvdAidTypetxt.Text == "")
                    {
                        MessageBox.Show("Please insert all the fields");
                    }
                    else if (PvdAidQuantitytxt.Text == "")
                    {
                        SqlCommand cmd = new SqlCommand("UPDATE FirstAids SET Aid_Type=@Aid_Type, Aid_Price=@Aid_Price WHERE Aid_Type=@Aid_Type", con);
                        cmd.Parameters.AddWithValue("@Aid_Type", (PvdAidTypetxt.Text));
                        cmd.Parameters.AddWithValue("@Aid_Price", (PvdAidPrice.Text));
                        cmd.ExecuteNonQuery();
                        con.Close();
                        PvdAidTypetxt.Text = "";
                        PvdAidQuantitytxt.Text = "";
                        PvdAidPrice.Text = "";
                        BindData();
                        MessageBox.Show("Updated");
                    }
                    else if (PvdAidPrice.Text == "")
                    {
                        SqlCommand cmd = new SqlCommand("UPDATE FirstAids SET Aid_Type=@Aid_Type, AidAvailable_Quantity=@AidAvailable_Quantity WHERE Aid_Type=@Aid_Type", con);
                        cmd.Parameters.AddWithValue("@Aid_Type", (PvdAidTypetxt.Text));
                        cmd.Parameters.AddWithValue("@AidAvailable_Quantity", (PvdAidQuantitytxt.Text));
                        cmd.ExecuteNonQuery();
                        con.Close();
                        PvdAidTypetxt.Text = "";
                        PvdAidQuantitytxt.Text = "";
                        PvdAidPrice.Text = "";
                        BindData();
                        MessageBox.Show("Updated");
                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand("UPDATE FirstAids SET Provider_Id=@Provider_Id, Aid_Type=@Aid_Type, AidAvailable_Quantity=@AidAvailable_Quantity, Aid_Price=@Aid_Price WHERE Aid_Type=@Aid_Type", con);
                        cmd.Parameters.AddWithValue("@Provider_Id", (PvdIDAidtxt.Text));
                        cmd.Parameters.AddWithValue("@Aid_Type", (PvdAidTypetxt.Text));
                        cmd.Parameters.AddWithValue("@AidAvailable_Quantity", (PvdAidQuantitytxt.Text));
                        cmd.Parameters.AddWithValue("@Aid_Price", (PvdAidPrice.Text));
                        cmd.ExecuteNonQuery();
                        con.Close();
                        PvdAidTypetxt.Text = "";
                        PvdAidQuantitytxt.Text = "";
                        PvdAidPrice.Text = "";
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

        private void PvdAidDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                string query = "SELECT Provider_Id, Name FROM Providers WHERE Provider_Id= '" + PvdIDAidtxt.Text.Trim() + "' and Name= '" + Provider.labelName.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    SqlCommand cmd = new SqlCommand("DELETE FirstAids WHERE Aid_Type=@Aid_Type", con);
                    cmd.Parameters.AddWithValue("@Aid_Type", (PvdAidTypetxt.Text));
                    cmd.ExecuteNonQuery();
                    con.Close();
                    PvdAidTypetxt.Text = "";
                    PvdAidQuantitytxt.Text = "";
                    PvdAidPrice.Text = "";
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

        private void PvdAidInsert_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                string query = "SELECT Provider_Id, Name FROM Providers WHERE Provider_Id= '" + PvdIDAidtxt.Text.Trim() + "' and Name= '" + Provider.labelName.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    if (PvdIDAidtxt.Text == "" || PvdAidPrice.Text == "" || PvdAidTypetxt.Text == "" || PvdAidQuantitytxt.Text == "")
                    {
                        MessageBox.Show("Please insert all the fields");
                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand("INSERT INTO FirstAids (Provider_Id, Aid_Type, AidAvailable_Quantity, Aid_Price) VALUES(@Provider_Id, @Aid_Type, @AidAvailable_Quantity, @Aid_Price)", con);
                        cmd.Parameters.AddWithValue("@Provider_Id", (PvdIDAidtxt.Text));
                        cmd.Parameters.AddWithValue("@Aid_Type", (PvdAidTypetxt.Text));
                        cmd.Parameters.AddWithValue("@AidAvailable_Quantity", (PvdAidQuantitytxt.Text));
                        cmd.Parameters.AddWithValue("@Aid_Price", (PvdAidPrice.Text));
                        cmd.ExecuteNonQuery();
                        con.Close();
                        PvdAidTypetxt.Text = "";
                        PvdAidQuantitytxt.Text = "";
                        PvdAidPrice.Text = "";
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

        private void Provider_FirstAid_Load(object sender, EventArgs e)
        {
           /* SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Tools WHERE @Name=Name", con);
            cmd.Parameters.AddWithValue("@Name", (Provider.labelName));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            PvdFirstAidDataGrid.DataSource = dt;*/
        }

        private void PvdAidCheck_Click(object sender, EventArgs e)
        {
            try
            {
                if (PvdIDAidtxt.Text != "")
                {
                    SqlConnection con = new SqlConnection(cs);
                    con.Open();
                    string query = "SELECT Provider_Id, Name FROM Providers WHERE Provider_Id= '" + PvdIDAidtxt.Text.Trim() + "' and Name= '" + Provider.labelName.Trim() + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {

                        SqlCommand cmd = new SqlCommand("SELECT * FROM FirstAids WHERE @Provider_Id=Provider_Id", con);
                        cmd.Parameters.AddWithValue("@Provider_Id", (PvdIDAidtxt.Text));
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dts = new DataTable();
                        da.Fill(dts);
                        PvdFirstAidDataGrid.DataSource = dts;
                    }
                    else
                    {
                        MessageBox.Show("Inserted ID is not associated with your account");
                    }
                }
                else
                {
                    MessageBox.Show("Please insert your id");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }

        private void PvdAidSearch_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                string query = "SELECT Provider_Id, Name FROM Providers WHERE Provider_Id= '" + PvdIDAidtxt.Text.Trim() + "' and Name= '" + Provider.labelName.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM FirstAids WHERE Provider_Id=@Provider_Id AND Aid_Type=@Aid_Type", con);
                    cmd.Parameters.AddWithValue("@Provider_Id", (PvdIDAidtxt.Text));
                    cmd.Parameters.AddWithValue("@Aid_Type", (PvdAidSeachtxt.Text));
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dts = new DataTable();
                    da.Fill(dts);
                    PvdFirstAidDataGrid.DataSource = dts;
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

        private void PvdAidDataCell_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                PvdIDAidtxt.Text = PvdFirstAidDataGrid.SelectedRows[0].Cells["Provider_Id"].Value.ToString();
                PvdAidTypetxt.Text = PvdFirstAidDataGrid.SelectedRows[0].Cells["Aid_Type"].Value.ToString();
                PvdAidQuantitytxt.Text = PvdFirstAidDataGrid.SelectedRows[0].Cells["AidAvailable_Quantity"].Value.ToString();
                PvdAidPrice.Text = PvdFirstAidDataGrid.SelectedRows[0].Cells["Aid_Price"].Value.ToString();

            }
        }
    }
}
