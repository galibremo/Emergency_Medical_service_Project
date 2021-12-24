
namespace MedicalService.Forms
{
    partial class ProviderPassReset
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
            this.ProviderPassNew = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PvdAccConfirmPass = new System.Windows.Forms.TextBox();
            this.PvdAccNewPass = new System.Windows.Forms.TextBox();
            this.btnProviderConfirmPass = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // ProviderPassNew
            // 
            this.ProviderPassNew.AutoSize = true;
            this.ProviderPassNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProviderPassNew.ForeColor = System.Drawing.Color.White;
            this.ProviderPassNew.Location = new System.Drawing.Point(88, 151);
            this.ProviderPassNew.Name = "ProviderPassNew";
            this.ProviderPassNew.Size = new System.Drawing.Size(188, 29);
            this.ProviderPassNew.TabIndex = 0;
            this.ProviderPassNew.Text = "New Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(88, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Confirm New Password";
            // 
            // PvdAccConfirmPass
            // 
            this.PvdAccConfirmPass.BackColor = System.Drawing.Color.DodgerBlue;
            this.PvdAccConfirmPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PvdAccConfirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PvdAccConfirmPass.ForeColor = System.Drawing.Color.White;
            this.PvdAccConfirmPass.Location = new System.Drawing.Point(401, 230);
            this.PvdAccConfirmPass.Name = "PvdAccConfirmPass";
            this.PvdAccConfirmPass.Size = new System.Drawing.Size(290, 17);
            this.PvdAccConfirmPass.TabIndex = 1;
            // 
            // PvdAccNewPass
            // 
            this.PvdAccNewPass.BackColor = System.Drawing.Color.DodgerBlue;
            this.PvdAccNewPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PvdAccNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PvdAccNewPass.ForeColor = System.Drawing.Color.White;
            this.PvdAccNewPass.Location = new System.Drawing.Point(401, 155);
            this.PvdAccNewPass.Name = "PvdAccNewPass";
            this.PvdAccNewPass.Size = new System.Drawing.Size(290, 17);
            this.PvdAccNewPass.TabIndex = 1;
            // 
            // btnProviderConfirmPass
            // 
            this.btnProviderConfirmPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnProviderConfirmPass.FlatAppearance.BorderSize = 0;
            this.btnProviderConfirmPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProviderConfirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnProviderConfirmPass.ForeColor = System.Drawing.Color.White;
            this.btnProviderConfirmPass.Location = new System.Drawing.Point(321, 293);
            this.btnProviderConfirmPass.Name = "btnProviderConfirmPass";
            this.btnProviderConfirmPass.Size = new System.Drawing.Size(164, 59);
            this.btnProviderConfirmPass.TabIndex = 2;
            this.btnProviderConfirmPass.Text = "CONFIRM";
            this.btnProviderConfirmPass.UseVisualStyleBackColor = false;
            this.btnProviderConfirmPass.Click += new System.EventHandler(this.ProviderConfirmPass_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(401, 181);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(295, 5);
            this.panel2.TabIndex = 63;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(401, 256);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 5);
            this.panel1.TabIndex = 64;
            // 
            // ProviderPassReset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(747, 446);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnProviderConfirmPass);
            this.Controls.Add(this.PvdAccNewPass);
            this.Controls.Add(this.PvdAccConfirmPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProviderPassNew);
            this.Location = new System.Drawing.Point(186, 84);
            this.Name = "ProviderPassReset";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProviderPassReset";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProviderPassNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PvdAccConfirmPass;
        private System.Windows.Forms.TextBox PvdAccNewPass;
        private System.Windows.Forms.Button btnProviderConfirmPass;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}