using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalService.LoginRegister
{
    public partial class Login : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["EMS"].ConnectionString;
        public Login()
        {
            InitializeComponent();
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

        private void LoginSignUp_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Register r1 = new Register();
            r1.Show();

        }

        

        private void PassShowCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if(PassShowCheckbox.Checked)
            {
                LoginPasstxt.PasswordChar = '\0';
            }
            else
            {
                LoginPasstxt.PasswordChar = '*';
            }
        }

        private void loginButton1_Click(object sender, EventArgs e)
        {            
            if (LoginNametxt.Text != "" && LoginPasstxt.Text != "" && AdminRdoButt.Checked)
            {
                try
                {
                    if (LoginNametxt.Text == "admin" && LoginPasstxt.Text == "admin")
                    {

                        Admin ad = new Admin();
                        this.Hide();
                        ad.Show();
                    }
                    else
                    {
                        MessageBox.Show("Name or Password is incorrect");
                    }
                }
                catch (Exception exc1)
                {
                    MessageBox.Show(exc1.Message);
                }
            }
            else if (LoginNametxt.Text != "" && LoginPasstxt.Text != "" && PatientRdoButt.Checked)
            {
                try
                {
                    SqlConnection con = new SqlConnection(cs);
                    con.Open();
                    string query = "SELECT User_Name, User_Password FROM Users WHERE User_Name= '" + LoginNametxt.Text.Trim() + "' and User_Password= '" + LoginPasstxt.Text.Trim() + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                        ServiceUser.Uname = LoginNametxt.Text;
                        ServiceUser sv = new ServiceUser();
                        this.Hide();
                        sv.Show();
                    }
                    else
                    {
                        MessageBox.Show("Name or Password is incorrect");
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
            else if (LoginNametxt.Text != "" && LoginPasstxt.Text != "" && ProviderRdoButt.Checked)
            {
                try
                {
                    SqlConnection con = new SqlConnection(cs);
                    con.Open();
                    string query = "SELECT Name, Password FROM Providers WHERE Name= '" + LoginNametxt.Text.Trim() + "' and Password= '" + LoginPasstxt.Text.Trim() + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                        Provider.labelName = LoginNametxt.Text;
                        Provider pv = new Provider();
                        this.Hide();
                        pv.Show();
                    }
                    else
                    {
                        MessageBox.Show("Name or Password is incorrect");
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
            else
            {
                MessageBox.Show("Please insert all option");
            }
        }
    }
}
