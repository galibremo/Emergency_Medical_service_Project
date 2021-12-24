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
    public partial class Provider_Tools : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["EMS"].ConnectionString;
        public Provider_Tools()
        {
            InitializeComponent();
        }
        void BindData()
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Tools WHERE Provider_Id=@Provider_Id", con);
            cmd.Parameters.AddWithValue("@Provider_Id", (PvdIDToolstxt.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            PvdToolsDataGrid.DataSource = dt;
        }
        private void PvdToolsUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                string query = "SELECT Provider_Id, Name FROM Providers WHERE Provider_Id= '" + PvdIDToolstxt.Text.Trim() + "' and Name= '" + Provider.labelName.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    if (PvdIDToolstxt.Text == "" || ProviderToolsNametxt.Text == "")
                    {
                        MessageBox.Show("Please insert all the fields");
                    }
                    else if (PvdToolPricetxt.Text == "")
                    {
                        SqlCommand cmd = new SqlCommand("UPDATE Tools SET Tool_Name=@Tool_Name, TAvailable_Quantity=@TAvailable_Quantity WHERE Tool_Name=@Tool_Name", con);
                        cmd.Parameters.AddWithValue("@Tool_Name", (ProviderToolsNametxt.Text));
                        cmd.Parameters.AddWithValue("@TAvailable_Quantity", (ProviderToolsQuantitytxt.Text));
                        cmd.ExecuteNonQuery();
                        con.Close();
                        ProviderToolsNametxt.Text = "";
                        ProviderToolsQuantitytxt.Text = "";
                        PvdToolPricetxt.Text = "";
                        BindData();
                        MessageBox.Show("Updated");
                    }
                    else if (ProviderToolsQuantitytxt.Text == "")
                    {
                        SqlCommand cmd = new SqlCommand("UPDATE Tools SET Tool_Name=@Tool_Name, Tool_Price=@Tool_Price WHERE Tool_Name=@Tool_Name", con);
                        cmd.Parameters.AddWithValue("@Tool_Name", (ProviderToolsNametxt.Text));
                        cmd.Parameters.AddWithValue("@Tool_Price", (PvdToolPricetxt.Text));
                        cmd.ExecuteNonQuery();
                        con.Close();
                        ProviderToolsNametxt.Text = "";
                        ProviderToolsQuantitytxt.Text = "";
                        PvdToolPricetxt.Text = "";
                        BindData();
                        MessageBox.Show("Updated");
                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand("UPDATE Tools SET Provider_Id=@Provider_Id, Tool_Name=@Tool_Name, TAvailable_Quantity=@TAvailable_Quantity, Tool_Price=@Tool_Price WHERE Tool_Name=@Tool_Name", con);
                        cmd.Parameters.AddWithValue("@Provider_Id", (PvdIDToolstxt.Text));
                        cmd.Parameters.AddWithValue("@Tool_Name", (ProviderToolsNametxt.Text));
                        cmd.Parameters.AddWithValue("@TAvailable_Quantity", (ProviderToolsQuantitytxt.Text));
                        cmd.Parameters.AddWithValue("@Tool_Price", (PvdToolPricetxt.Text));
                        cmd.ExecuteNonQuery();
                        con.Close();
                        ProviderToolsNametxt.Text = "";
                        ProviderToolsQuantitytxt.Text = "";
                        PvdToolPricetxt.Text = "";
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

        private void PvdToolsDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                string query = "SELECT Provider_Id, Name FROM Providers WHERE Provider_Id= '" + PvdIDToolstxt.Text.Trim() + "' and Name= '" + Provider.labelName.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    SqlCommand cmd = new SqlCommand("DELETE Tools WHERE Tool_Name=@Tool_Name", con);
                    cmd.Parameters.AddWithValue("@Tool_Name", (ProviderToolsNametxt.Text));
                    cmd.ExecuteNonQuery();
                    con.Close();
                    ProviderToolsNametxt.Text = "";
                    ProviderToolsQuantitytxt.Text = "";
                    PvdToolPricetxt.Text = "";
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

        private void ProviderToolstxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void PvdToolsInsert_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                string query = "SELECT Provider_Id, Name FROM Providers WHERE Provider_Id= '" + PvdIDToolstxt.Text.Trim() + "' and Name= '" + Provider.labelName.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    if (PvdIDToolstxt.Text == "" || PvdToolPricetxt.Text == "" || ProviderToolsNametxt.Text == "" || ProviderToolsQuantitytxt.Text == "")
                    {
                        MessageBox.Show("Please insert all the fields");
                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand("INSERT INTO Tools (Provider_Id, Tool_Name, TAvailable_Quantity, Tool_Price) VALUES(@Provider_Id, @Tool_Name, @TAvailable_Quantity, @Tool_Price)", con);
                        cmd.Parameters.AddWithValue("@Provider_Id", (PvdIDToolstxt.Text));
                        cmd.Parameters.AddWithValue("@Tool_Name", (ProviderToolsNametxt.Text));
                        cmd.Parameters.AddWithValue("@TAvailable_Quantity", (ProviderToolsQuantitytxt.Text));
                        cmd.Parameters.AddWithValue("@Tool_Price", (PvdToolPricetxt.Text));
                        cmd.ExecuteNonQuery();
                        con.Close();
                        ProviderToolsNametxt.Text = "";
                        ProviderToolsQuantitytxt.Text = "";
                        PvdToolPricetxt.Text = "";
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

        private void Provider_Tools_Load(object sender, EventArgs e)
        {
            /*SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Tools WHERE @Name=Name", con);
            cmd.Parameters.AddWithValue("@Name", (Provider.labelName));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            PvdToolsDataGrid.DataSource = dt;*/
        }

        private void PvdToolsCheck_Click(object sender, EventArgs e)
        {
            try
            {
                if (PvdIDToolstxt.Text != "")
                {
                    SqlConnection con = new SqlConnection(cs);
                    con.Open();
                    string query = "SELECT Provider_Id, Name FROM Providers WHERE Provider_Id= '" + PvdIDToolstxt.Text.Trim() + "' and Name= '" + Provider.labelName.Trim() + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {

                        SqlCommand cmd = new SqlCommand("SELECT * FROM Tools WHERE @Provider_Id=Provider_Id", con);
                        cmd.Parameters.AddWithValue("@Provider_Id", (PvdIDToolstxt.Text));
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dts = new DataTable();
                        da.Fill(dts);
                        PvdToolsDataGrid.DataSource = dts;
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

        private void PvdToolsSearch_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                string query = "SELECT Provider_Id, Name FROM Providers WHERE Provider_Id= '" + PvdIDToolstxt.Text.Trim() + "' and Name= '" + Provider.labelName.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Tools WHERE Provider_Id=@Provider_Id AND Tool_Name=@Tool_Name", con);
                    cmd.Parameters.AddWithValue("@Provider_Id", (PvdIDToolstxt.Text));
                    cmd.Parameters.AddWithValue("@Tool_Name", (PvdToolsSearchtxt.Text));
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dts = new DataTable();
                    da.Fill(dts);
                    PvdToolsDataGrid.DataSource = dts;
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

        private void PvdToolsDataCell_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                PvdIDToolstxt.Text = PvdToolsDataGrid.SelectedRows[0].Cells["Provider_Id"].Value.ToString();
                ProviderToolsNametxt.Text = PvdToolsDataGrid.SelectedRows[0].Cells["Tool_Name"].Value.ToString();
                ProviderToolsQuantitytxt.Text = PvdToolsDataGrid.SelectedRows[0].Cells["TAvailable_Quantity"].Value.ToString();
                PvdToolPricetxt.Text = PvdToolsDataGrid.SelectedRows[0].Cells["Tool_Price"].Value.ToString();

            }
        }
    }
}
