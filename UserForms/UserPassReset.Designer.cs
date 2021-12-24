
namespace MedicalService.UserForms
{
    partial class UserPassReset
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UserPassNew = new System.Windows.Forms.Label();
            this.UserConfirmPass = new System.Windows.Forms.Label();
            this.UserNewPassTextBox = new System.Windows.Forms.TextBox();
            this.UserConfirmPassTextBox = new System.Windows.Forms.TextBox();
            this.UserPassConfirmbtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // UserPassNew
            // 
            this.UserPassNew.AutoSize = true;
            this.UserPassNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserPassNew.ForeColor = System.Drawing.Color.White;
            this.UserPassNew.Location = new System.Drawing.Point(70, 143);
            this.UserPassNew.Name = "UserPassNew";
            this.UserPassNew.Size = new System.Drawing.Size(213, 32);
            this.UserPassNew.TabIndex = 0;
            this.UserPassNew.Text = "New Password";
            // 
            // UserConfirmPass
            // 
            this.UserConfirmPass.AutoSize = true;
            this.UserConfirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserConfirmPass.ForeColor = System.Drawing.Color.White;
            this.UserConfirmPass.Location = new System.Drawing.Point(70, 214);
            this.UserConfirmPass.Name = "UserConfirmPass";
            this.UserConfirmPass.Size = new System.Drawing.Size(327, 32);
            this.UserConfirmPass.TabIndex = 0;
            this.UserConfirmPass.Text = "Confirm New Password";
            // 
            // UserNewPassTextBox
            // 
            this.UserNewPassTextBox.BackColor = System.Drawing.Color.Crimson;
            this.UserNewPassTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserNewPassTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserNewPassTextBox.ForeColor = System.Drawing.Color.White;
            this.UserNewPassTextBox.Location = new System.Drawing.Point(418, 143);
            this.UserNewPassTextBox.Name = "UserNewPassTextBox";
            this.UserNewPassTextBox.Size = new System.Drawing.Size(302, 17);
            this.UserNewPassTextBox.TabIndex = 1;
            // 
            // UserConfirmPassTextBox
            // 
            this.UserConfirmPassTextBox.BackColor = System.Drawing.Color.Crimson;
            this.UserConfirmPassTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserConfirmPassTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserConfirmPassTextBox.ForeColor = System.Drawing.Color.White;
            this.UserConfirmPassTextBox.Location = new System.Drawing.Point(418, 214);
            this.UserConfirmPassTextBox.Name = "UserConfirmPassTextBox";
            this.UserConfirmPassTextBox.Size = new System.Drawing.Size(302, 17);
            this.UserConfirmPassTextBox.TabIndex = 1;
            // 
            // UserPassConfirmbtn
            // 
            this.UserPassConfirmbtn.BackColor = System.Drawing.Color.LightCoral;
            this.UserPassConfirmbtn.FlatAppearance.BorderSize = 0;
            this.UserPassConfirmbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserPassConfirmbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserPassConfirmbtn.ForeColor = System.Drawing.Color.White;
            this.UserPassConfirmbtn.Location = new System.Drawing.Point(321, 282);
            this.UserPassConfirmbtn.Name = "UserPassConfirmbtn";
            this.UserPassConfirmbtn.Size = new System.Drawing.Size(155, 54);
            this.UserPassConfirmbtn.TabIndex = 2;
            this.UserPassConfirmbtn.Text = "CONFIRM";
            this.UserPassConfirmbtn.UseVisualStyleBackColor = false;
            this.UserPassConfirmbtn.Click += new System.EventHandler(this.UserConfirmPassbtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(418, 169);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(295, 5);
            this.panel2.TabIndex = 64;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(418, 240);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 5);
            this.panel1.TabIndex = 65;
            // 
            // UserPassReset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.UserPassConfirmbtn);
            this.Controls.Add(this.UserConfirmPassTextBox);
            this.Controls.Add(this.UserNewPassTextBox);
            this.Controls.Add(this.UserConfirmPass);
            this.Controls.Add(this.UserPassNew);
            this.Name = "UserPassReset";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reset Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserPassNew;
        private System.Windows.Forms.Label UserConfirmPass;
        private System.Windows.Forms.TextBox UserNewPassTextBox;
        private System.Windows.Forms.TextBox UserConfirmPassTextBox;
        private System.Windows.Forms.Button UserPassConfirmbtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}