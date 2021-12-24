using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalService.Forms
{
    public partial class HOME : Form
    {
        private Form activeForm;
        public HOME()
        {
            InitializeComponent();
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

        private void label3_Click(object sender, EventArgs e)
        {

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
            this.Home2panel.Controls.Add(childForm);
            this.Home2panel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
           // TitleLabel.Text = childForm.Text;
        }

        private void HomeSearchtext_click(object sender, EventArgs e)
        {
            if (HomeTextBox.Text == "Search in your services")
            {
                HomeTextBox.Clear();
            }
        }

        private void PvdHomeMedicineView_Click(object sender, EventArgs e)
        {
           
        }

        private void HOME_Load(object sender, EventArgs e)
        {

        }

        private void pvdMdcView_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Provider_Medicine(), sender);
        }

        private void pvdToolsView_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Provider_Tools(), sender);
        }

        private void PvdAmbView_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Provider_Ambulance(), sender);
        }

        private void PvdAidView_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Provider_FirstAid(), sender);
        }

        private void HOME_Load_1(object sender, EventArgs e)
        {

        }

        private void PvdHomeSearch_Click(object sender, EventArgs e)
        {
            if (PvdHomeSearchtxt.Text == "Search in your services")
            {
                PvdHomeSearchtxt.Clear();
            }
        }

        private void Home2panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
