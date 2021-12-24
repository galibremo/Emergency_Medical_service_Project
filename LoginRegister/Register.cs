using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Configuration;

namespace MedicalService.LoginRegister
{
    public partial class Register : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["EMS"].ConnectionString;

        public Register()
        {
            InitializeComponent();
        }

        private void RegLoginLink_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login l1 = new Login();
            l1.Show();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (RegName.Text != "" && RegMobile.Text != "" && RegAddress.Text != "" && RegPass.Text != "" && RegConfirmPass.Text != "" && RegEmail.Text != "" && RegID.Text != "" && RegProviderRdoButt.Checked)
            {
                if (RegID.Text.Length == 5)
                {
                    SqlConnection con = new SqlConnection(cs);
                    con.Open();
                    string query = "SELECT Provider_Id FROM Providers WHERE Provider_Id= '" + RegID.Text.Trim() + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                        MessageBox.Show("This ID is unavailable");
                    }
                    else
                    {
                        try
                        {
                            if (RegConfirmPass.Text == RegPass.Text)
                            {
                                SqlCommand cmd = new SqlCommand("INSERT INTO Providers (Name, Provider_Id, Address, Mobile, Email, Password) VALUES(@Name, @Provider_Id, @Address, @Mobile, @Email, @Password)", con);

                                cmd.Parameters.AddWithValue("@Name", (RegName.Text));
                                cmd.Parameters.AddWithValue("@Provider_Id", int.Parse(RegID.Text));
                                cmd.Parameters.AddWithValue("@Address", (RegAddress.Text));
                                cmd.Parameters.AddWithValue("@Mobile", (RegMobile.Text));
                                cmd.Parameters.AddWithValue("@Email", (RegEmail.Text));
                                cmd.Parameters.AddWithValue("@Password", (RegPass.Text));
                                cmd.ExecuteNonQuery();
                                con.Close();
                                MessageBox.Show("Registered");
                                RegName.Text = "";
                                RegID.Text = "";
                                RegAddress.Text = "";
                                RegEmail.Text = "";
                                RegMobile.Text = "";
                                RegPass.Text = "";
                                RegConfirmPass.Text = "";
                                this.Hide();
                                Login l1 = new Login();
                                l1.Show();
                            }
                            else
                            {
                                MessageBox.Show("Password did not match");
                            }
                        }
                        catch (Exception exc)
                        {
                            MessageBox.Show(exc.Message);
                        }
                    }
                }
                else
                {
                      MessageBox.Show("Your ID must be of 5 digits");
                }

                
            }
            else if (RegName.Text != "" && RegMobile.Text != "" && RegAddress.Text != "" && RegPass.Text != "" && RegConfirmPass.Text != "" && RegEmail.Text != "" && RegID.Text != "" && RegPatientRdoButt.Checked)
            {
                if (RegID.Text.Length == 5)
                {
                    SqlConnection con = new SqlConnection(cs);
                    con.Open();
                    string query = "SELECT User_Id FROM Users WHERE User_Id= '" + RegID.Text.Trim() + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                        MessageBox.Show("This ID is unavailable");
                    }
                    else
                    {
                        if (RegConfirmPass.Text == RegPass.Text)
                        {
                            SqlCommand cmd = new SqlCommand("INSERT INTO Users (User_Name, User_Id, User_Address, User_Email, User_Mobile, User_Password) VALUES(@User_Name, @User_Id, @User_Address, @User_Email, @User_Mobile, @User_Password)", con);
                            try
                            {

                                cmd.Parameters.AddWithValue("@User_Name", (RegName.Text));
                                cmd.Parameters.AddWithValue("@User_Id", int.Parse(RegID.Text));
                                cmd.Parameters.AddWithValue("@User_Address", (RegAddress.Text));
                                cmd.Parameters.AddWithValue("@User_Email", (RegEmail.Text));
                                cmd.Parameters.AddWithValue("@User_Mobile", (RegMobile.Text));
                                cmd.Parameters.AddWithValue("@User_Password", (RegPass.Text));
                                cmd.ExecuteNonQuery();
                                con.Close();
                                MessageBox.Show("Registered");
                                RegName.Text = "";
                                RegID.Text = "";
                                RegAddress.Text = "";
                                RegEmail.Text = "";
                                RegMobile.Text = "";
                                RegPass.Text = "";
                                this.Hide();
                                Login l1 = new Login();
                                l1.Show();
                            }
                            catch (Exception exc)
                            {
                                MessageBox.Show(exc.Message);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Password did not match");
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Your ID must be of 5 digits");
                }
            }
            else
            {
                MessageBox.Show("Please insert all option");
            }
        }

        private void RegisterClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RegisterMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void RegisterMaximize_Click(object sender, EventArgs e)
        {

        }
    }
}
