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

namespace MedicalService.UserForms
{
    public partial class UserHome : Form
    {
        private Form activeForm3;
        public UserHome()
        {
            InitializeComponent();
        }

        private void UserSearch_click(object sender, EventArgs e)
        {
            if(UserTextBox.Text == "Search in your services")
            {
                UserTextBox.Clear();
            }
        }

        private void UserHome_Load(object sender, EventArgs e)
        {

        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm3 != null)
                activeForm3.Close();
            // ActivateButton(btnSender);
            activeForm3 = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.UserHomePanel2.Controls.Add(childForm);
            this.UserHomePanel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //UserTitleLabel.Text = childForm.Text;
        }

        private void UsrMdcView_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserForms.User_Medicine(), sender);
        }

        private void UsrAidView_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserForms.User_FirstAid(), sender);
        }

        private void UsrToolsView_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserForms.User_Tools(), sender);
        }

        private void UsrAmblnsView_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserForms.User_Ambulance(), sender);
        }

        private void UserHomeSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void UserSearch_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserForms.UserSearch(), sender);
        }

        private void UserHomePanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
