using MedicalService.LoginRegister;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MedicalService
{
    public partial class ServiceUser : Form
    {
        private Form activeForm2;
        public static string Uname;        
        public ServiceUser()
        {
            InitializeComponent();
            pnl2.Height = btnUserHome.Height;
            pnl2.Top = btnUserHome.Top;
            pnl2.Left = btnUserHome.Left;
        }

        private void UserHome_click(object sender, EventArgs e)
        {
            pnl2.Height = btnUserHome.Height;
            pnl2.Top = btnUserHome.Top;
            pnl2.Left = btnUserHome.Left;
            OpenChildForm(new UserForms.UserHome(), sender);
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm2 != null)
                activeForm2.Close();
            // ActivateButton(btnSender);
            activeForm2 = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.UserHomePanel.Controls.Add(childForm);
            this.UserHomePanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            UserTitleLabel.Text = childForm.Text;
        }

        private void UserBilling_click(object sender, EventArgs e)
        {
            pnl2.Height = btnUserBilling.Height;
            pnl2.Top = btnUserBilling.Top;
            pnl2.Left = btnUserBilling.Left;
            OpenChildForm(new UserForms.UserBilling(), sender);
        }

        private void UserRequests_click(object sender, EventArgs e)
        {
            pnl2.Height = btnUserRequests.Height;
            pnl2.Top = btnUserRequests.Top;
            pnl2.Left = btnUserRequests.Left;
            OpenChildForm(new UserForms.UserRequests(), sender);
        }

        private void UserAccount_click(object sender, EventArgs e)
        {
            pnl2.Height = btnUserAccount.Height;
            pnl2.Top = btnUserAccount.Top;
            pnl2.Left = btnUserAccount.Left;
            OpenChildForm(new UserForms.UserAccount(), sender);
        }

        private void UserLogout_click(object sender, EventArgs e)
        {
            pnl2.Height = btnUserLogout.Height;
            pnl2.Top = btnUserLogout.Top;
            pnl2.Left = btnUserLogout.Left;
            Login lg = new Login();
            this.Hide();
            lg.Show();
        }

        private void UserSearch_click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureTools_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnUserSearch_click(object sender, EventArgs e)
        {

        }

        private void btnUserTextBox_TextChanged(object sender, EventArgs e)
        {
            if (btnUserTextBox.Text == "Search in your services")
            {
                btnUserTextBox.Clear();
            }
        }

        private void UserMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void UserClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ServiceUser_Load(object sender, EventArgs e)
        {

        }

        private void ServiceUser_Load_1(object sender, EventArgs e)
        {
            ServiceUserName.Text = Uname;
        }

        private void UserMedicine_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserForms.User_Medicine(), sender);
        }

        private void UserAid_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserForms.User_FirstAid(), sender);
        }

        private void UserTools_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserForms.User_Tools(), sender);
        }

        private void UserAmbulance_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserForms.User_Ambulance(), sender);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUser2SearchSvc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserForms.UserSearch(), sender);
        }
    }
}
