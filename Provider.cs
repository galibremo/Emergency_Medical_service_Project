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
    public partial class Provider : Form
    {
        private Form activeForm;
        public static String labelName;
        public Provider()
        {
            InitializeComponent();
            panel3.Height = btnProviderHome.Height;
            panel3.Top = btnProviderHome.Top;
            panel3.Left = btnProviderHome.Left;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Home_Click(object sender, EventArgs e)
        {
            panel3.Height = btnProviderHome.Height;
            panel3.Top = btnProviderHome.Top;
            panel3.Left = btnProviderHome.Left;
            OpenChildForm(new Forms.HOME(), sender);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Provider_Load(object sender, EventArgs e)
        {


            ProviderUsername.Text = labelName;
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
           // ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.HomePanel.Controls.Add(childForm);
            this.HomePanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            TitleLabel.Text = childForm.Text;
        }

        private void btnWorkers_Click(object sender, EventArgs e)
        {
            panel3.Height = btnWorkers.Height;
            panel3.Top = btnWorkers.Top;
            panel3.Left = btnWorkers.Left;
            OpenChildForm(new Forms.Mediator_Details(), sender);
        }

        private void btnRequests_Click(object sender, EventArgs e)
        {
            panel3.Height = btnRequests.Height;
            panel3.Top = btnRequests.Top;
            panel3.Left = btnRequests.Left;
            OpenChildForm(new Forms.Requested_Services(), sender);
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            panel3.Height = btnProviderAccount.Height;
            panel3.Top = btnProviderAccount.Top;
            panel3.Left = btnProviderAccount.Left;            
            OpenChildForm(new Forms.My_Account(), sender);
        }

        private void btnHome_Leave(object sender, EventArgs e)
        {
            //btnHome.BackColor = Color.FromArgb(82, 12, 23);
        }

        private void btnWorkers_Leave(object sender, EventArgs e)
        {
            //btnWorkers.BackColor = Color.FromArgb(82, 12, 23);
        }

        private void btnRequests_Leave(object sender, EventArgs e)
        {
           // btnRequests.BackColor = Color.FromArgb(82, 12, 23);
        }

        private void btnAccount_Leave(object sender, EventArgs e)
        {
           // btnAccount.BackColor = Color.FromArgb(82, 12, 23);
        }

        private void btnLogout_Leave(object sender, EventArgs e)
        {
           // btnLogout.BackColor = Color.FromArgb(82, 12, 23);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            panel3.Height = btnProviderLogout.Height;
            panel3.Top = btnProviderLogout.Top;
            panel3.Left = btnProviderLogout.Left;
            Login lg = new Login();
            this.Hide();
            lg.Show();
        }

        private void View1_click(object sender, EventArgs e)
        {

        }

        private void View2_click(object sender, EventArgs e)
        {

        }

        private void View3_click(object sender, EventArgs e)
        {

        }

        private void View4_click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void ProviderSearchText_click(object sender, EventArgs e)
        {
            if(ProviderTextBox.Text== "Search in your services")
            {
                ProviderTextBox.Clear();
            }
        }

        private void ProviderUsername_Click(object sender, EventArgs e)
        {

        }

        private void ProviderSearch_click(object sender, EventArgs e)
        {

        }

        private void ProviderClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ProviderMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ProviderMedicine_Click(object sender, EventArgs e)
        {
            
        }

        private void ProviderTools_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Provider_Tools(), sender);
        }

        private void ProviderAmbulance_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Provider_Ambulance(), sender);
        }

        private void ProviderMedicinePanel_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void ProviderMedicineView_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Provider_Medicine(), sender);
        }

        private void ProviderAid_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Provider_FirstAid(), sender);
        }
    }
}
