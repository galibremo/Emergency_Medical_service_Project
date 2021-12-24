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
    public partial class Provider_Medicine : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["EMS"].ConnectionString;
        public Provider_Medicine()
        {
            InitializeComponent();
        }
        void BindData()
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Medicines WHERE Provider_Id=@Provider_Id", con);
            cmd.Parameters.AddWithValue("@Provider_Id", (PvdIDMedicinetxt.Text));
            SqlDataAdapter dad = new SqlDataAdapter(cmd);
            DataTable dtt = new DataTable();
            dad.Fill(dtt);
            PvdMdcDataGrid.DataSource = dtt;
        }

        private void PvdMedicineUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                string query = "SELECT Provider_Id, Name FROM Providers WHERE Provider_Id= '" + PvdIDMedicinetxt.Text.Trim() + "' and Name= '" + Provider.labelName.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {

                    if (PvdIDMedicinetxt.Text == "" || ProviderMedicineNametxt.Text == "")
                    {
                        MessageBox.Show("Please insert all the fields");
                    }
                    else if (ProviderMedicineQuantitytxt.Text == "")
                    {
                        SqlCommand cmd = new SqlCommand("UPDATE Medicines SET Medicine_Name=@Medicine_Name, Medicine_Price=@Medicine_Price WHERE Medicine_Name=@Medicine_Name", con);
                        cmd.Parameters.AddWithValue("@Medicine_Name", (ProviderMedicineNametxt.Text));
                        cmd.Parameters.AddWithValue("@Medicine_Price", (PvdMdcPricetxt.Text));
                        cmd.ExecuteNonQuery();
                        con.Close();
                        ProviderMedicineNametxt.Text = "";
                        ProviderMedicineQuantitytxt.Text = "";
                        PvdMdcPricetxt.Text = "";
                        BindData();
                        MessageBox.Show("Updated");
                    }
                    else if (PvdMdcPricetxt.Text == "")
                    {
                        SqlCommand cmd = new SqlCommand("UPDATE Medicines SET Medicine_Name=@Medicine_Name, MAvailable_Quantity=@MAvailable_Quantity WHERE Medicine_Name=@Medicine_Name", con);
                        cmd.Parameters.AddWithValue("@Medicine_Name", (ProviderMedicineNametxt.Text));
                        cmd.Parameters.AddWithValue("@MAvailable_Quantity", (ProviderMedicineQuantitytxt.Text));
                        cmd.ExecuteNonQuery();
                        con.Close();
                        ProviderMedicineNametxt.Text = "";
                        ProviderMedicineQuantitytxt.Text = "";
                        PvdMdcPricetxt.Text = "";
                        BindData();
                        MessageBox.Show("Updated");
                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand("UPDATE Medicines SET Provider_Id=@Provider_Id, Medicine_Name=@Medicine_Name, MAvailable_Quantity=@MAvailable_Quantity, Medicine_Price=@Medicine_Price WHERE Medicine_Name=@Medicine_Name", con);
                        cmd.Parameters.AddWithValue("@Provider_Id", (PvdIDMedicinetxt.Text));
                        cmd.Parameters.AddWithValue("@Medicine_Name", (ProviderMedicineNametxt.Text));
                        cmd.Parameters.AddWithValue("@MAvailable_Quantity", (ProviderMedicineQuantitytxt.Text));
                        cmd.Parameters.AddWithValue("@Medicine_Price", (PvdMdcPricetxt.Text));
                        cmd.ExecuteNonQuery();
                        con.Close();
                        ProviderMedicineNametxt.Text = "";
                        ProviderMedicineQuantitytxt.Text = "";
                        PvdMdcPricetxt.Text = "";
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

        private void ProviderMedicineDelete_Click(object sender, EventArgs e)
        {
            //try
          //  {
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                string query = "SELECT Provider_Id, Name FROM Providers WHERE Provider_Id= '" + PvdIDMedicinetxt.Text.Trim() + "' and Name= '" + Provider.labelName.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    SqlCommand cmd = new SqlCommand("DELETE Medicines WHERE Medicine_Name=@Medicine_Name", con);
                    cmd.Parameters.AddWithValue("@Medicine_Name", (ProviderMedicineNametxt.Text));
                    cmd.ExecuteNonQuery();
                    con.Close();
                    ProviderMedicineNametxt.Text = "";
                    ProviderMedicineQuantitytxt.Text = "";
                    PvdMdcPricetxt.Text = "";
                    BindData();
                    MessageBox.Show("Deleted");
                }
                else
                {
                    MessageBox.Show("Inserted ID is not associated with your account");
                }

          //  }
          //  catch (Exception exc)
           // {
             //   MessageBox.Show(exc.Message);
            //}
        }

        private void PvdMdcInsert_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                string query = "SELECT Provider_Id, Name FROM Providers WHERE Provider_Id= '" + PvdIDMedicinetxt.Text.Trim() + "' and Name= '" + Provider.labelName.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {

                    if (PvdIDMedicinetxt.Text == "" || PvdMdcPricetxt.Text == "" || ProviderMedicineNametxt.Text == "" || ProviderMedicineQuantitytxt.Text == "")
                    {
                        MessageBox.Show("Please insert all the fields");
                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand("INSERT INTO Medicines (Provider_Id, Medicine_Name, MAvailable_Quantity, Medicine_Price) VALUES(@Provider_Id, @Medicine_Name, @MAvailable_Quantity, @Medicine_Price)", con);
                        cmd.Parameters.AddWithValue("@Provider_Id", (PvdIDMedicinetxt.Text));
                        cmd.Parameters.AddWithValue("@Medicine_Name", (ProviderMedicineNametxt.Text));
                        cmd.Parameters.AddWithValue("@MAvailable_Quantity", (ProviderMedicineQuantitytxt.Text));
                        cmd.Parameters.AddWithValue("@Medicine_Price", (PvdMdcPricetxt.Text));
                        cmd.ExecuteNonQuery();
                        con.Close();
                        ProviderMedicineNametxt.Text = "";
                        ProviderMedicineQuantitytxt.Text = "";
                        PvdMdcPricetxt.Text = "";
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

        private void Provider_Medicine_Load(object sender, EventArgs e)
        {
          /* SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Medicines WHERE @Name=Name", con);
            cmd.Parameters.AddWithValue("@Name", (Provider.labelName));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            PvdMdcDataGrid.DataSource = dt;*/
        }

        private void PvdMedicineCheck_Click(object sender, EventArgs e)
        {
            try
            {
                if (PvdIDMedicinetxt.Text != "")
                {
                    SqlConnection con = new SqlConnection(cs);
                    con.Open();
                    string query = "SELECT Provider_Id, Name FROM Providers WHERE Provider_Id= '" + PvdIDMedicinetxt.Text.Trim() + "' and Name= '" + Provider.labelName.Trim() + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {

                        SqlCommand cmd = new SqlCommand("SELECT * FROM Medicines WHERE @Provider_Id=Provider_Id", con);
                        cmd.Parameters.AddWithValue("@Provider_Id", (PvdIDMedicinetxt.Text));
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dts = new DataTable();
                        da.Fill(dts);
                        PvdMdcDataGrid.DataSource = dts;
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
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }

        private void ProviderMedicineSearch_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                string query = "SELECT Provider_Id, Name FROM Providers WHERE Provider_Id= '" + PvdIDMedicinetxt.Text.Trim() + "' and Name= '" + Provider.labelName.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Medicines WHERE Provider_Id=@Provider_Id AND Medicine_Name=@Medicine_Name", con);
                    cmd.Parameters.AddWithValue("@Provider_Id", (PvdIDMedicinetxt.Text));
                    cmd.Parameters.AddWithValue("@Medicine_Name", (PvdMdcSearchtxt.Text));
                    SqlDataAdapter dad = new SqlDataAdapter(cmd);
                    DataTable dtt = new DataTable();
                    dad.Fill(dtt);
                    PvdMdcDataGrid.DataSource = dtt;

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

        private void PvdMedDataCell_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                PvdIDMedicinetxt.Text = PvdMdcDataGrid.SelectedRows[0].Cells["Provider_Id"].Value.ToString();
                ProviderMedicineNametxt.Text = PvdMdcDataGrid.SelectedRows[0].Cells["Medicine_Name"].Value.ToString();
                ProviderMedicineQuantitytxt.Text = PvdMdcDataGrid.SelectedRows[0].Cells["MAvailable_Quantity"].Value.ToString();
                PvdMdcPricetxt.Text = PvdMdcDataGrid.SelectedRows[0].Cells["Medicine_Price"].Value.ToString();

            }
        }
    }
}
