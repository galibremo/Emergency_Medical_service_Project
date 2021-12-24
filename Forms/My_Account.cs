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
    public partial class My_Account : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["EMS"].ConnectionString;
        public My_Account()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AccountBack_Click(object sender, EventArgs e)
        {

        }

        private void ProviderPasswordReset_click(object sender, EventArgs e)
        {

        }

        private void ProviderReset_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProviderPassReset pr = new ProviderPassReset();
            pr.Show();
        }
        void BindData()
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Providers WHERE Name=@Name", con);
            cmd.Parameters.AddWithValue("@Name", (Provider.labelName));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            PvdAccDataGrid.DataSource = dt;
        }

        private void My_Account_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Providers WHERE Name=@Name", con);
            cmd.Parameters.AddWithValue("@Name", (Provider.labelName));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            PvdAccDataGrid.DataSource = dt;
            

          
        }

        private void PvdAccUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Providers SET Name=@Name, Email=@Email, Address=@Address, Mobile=@Mobile, Date_of_Birth=@Date_of_Birth WHERE Name=@Name", con);
                cmd.Parameters.AddWithValue("@Name", (PvdAccNametxt.Text));
                cmd.Parameters.AddWithValue("@Email", (PvdAccEmailtxt.Text));
                cmd.Parameters.AddWithValue("@Address", (PvdAccAddresstxt.Text));
                cmd.Parameters.AddWithValue("@Mobile", (PvdAccMobiletxt.Text));
                cmd.ExecuteNonQuery();
                con.Close();
                PvdAccNametxt.Text = "";
                PvdAccEmailtxt.Text = "";
                PvdAccAddresstxt.Text = "";
                PvdAccMobiletxt.Text = "";
                BindData();
                MessageBox.Show("Updated");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void PvdAccDataGridCell_Click(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                PvdAccNametxt.Text = PvdAccDataGrid.SelectedRows[0].Cells["Name"].Value.ToString();
                PvdAccEmailtxt.Text = PvdAccDataGrid.SelectedRows[0].Cells["Email"].Value.ToString();
                PvdAccAddresstxt.Text = PvdAccDataGrid.SelectedRows[0].Cells["Address"].Value.ToString();
                PvdAccMobiletxt.Text = PvdAccDataGrid.SelectedRows[0].Cells["Mobile"].Value.ToString();
            }
        }
    }
}
