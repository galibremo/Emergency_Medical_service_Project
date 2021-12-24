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
using MedicalService.LoginRegister;

namespace MedicalService
{
    public partial class Admin : Form
    {
        private Form activeForm4;      
        public Admin()
        {
            InitializeComponent();
            panelp.Height = btnAdminPvd.Height;
            panelp.Top = btnAdminPvd.Top;
            panelp.Left = btnAdminPvd.Left;

        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm4 != null)
                activeForm4.Close();
            // ActivateButton(btnSender);
            activeForm4 = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.adminpanel.Controls.Add(childForm);
            this.adminpanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //TitleLabel.Text = childForm.Text;
        }

        private void btnAdminPvd_Click(object sender, EventArgs e)
        {
            panelp.Height = btnAdminPvd.Height;
            panelp.Top = btnAdminPvd.Top;
            panelp.Left = btnAdminPvd.Left;
            OpenChildForm(new Adminforms.AdminProviders(), sender);
        }

        private void btnAdminUsers_Click(object sender, EventArgs e)
        {
            panelp.Height = btnAdminUsers.Height;
            panelp.Top = btnAdminUsers.Top;
            panelp.Left = btnAdminUsers.Left;            
            OpenChildForm(new Adminforms.AdminUsers(), sender);
        }

        private void btnAdminMed_Click(object sender, EventArgs e)
        {
            panelp.Height = btnAdminMed.Height;
            panelp.Top = btnAdminMed.Top;
            panelp.Left = btnAdminMed.Left;
            OpenChildForm(new Adminforms.AdminMediators(), sender);
        }

        private void btnAdminReq_Click(object sender, EventArgs e)
        {
            panelp.Height = btnAdminReq.Height;
            panelp.Top = btnAdminReq.Top;
            panelp.Left = btnAdminReq.Left;
            OpenChildForm(new Adminforms.AdminService(), sender);
        }

        private void btnAdminLogout_Click(object sender, EventArgs e)
        {
            panelp.Height = btnAdminLogout.Height;
            panelp.Top = btnAdminLogout.Top;
            panelp.Left = btnAdminLogout.Left;
            Login log = new Login();
            this.Hide();
            log.Show();
        }

        private void AdminClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AdminMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
