
namespace MedicalService.UserForms
{
    partial class UserBilling
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.UserBillingDataGrid = new System.Windows.Forms.DataGridView();
            this.UserBillingPay = new System.Windows.Forms.Button();
            this.UserBillUserIdTxt = new System.Windows.Forms.TextBox();
            this.UserBillServiceName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UsrIDToolsLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UserBillPvdId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.UserAccNumTxt = new System.Windows.Forms.TextBox();
            this.UserBillSearch = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.UserBillingDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(63, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Your Requests";
            // 
            // UserBillingDataGrid
            // 
            this.UserBillingDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.UserBillingDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserBillingDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.UserBillingDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UserBillingDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.UserBillingDataGrid.ColumnHeadersHeight = 35;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UserBillingDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.UserBillingDataGrid.EnableHeadersVisualStyles = false;
            this.UserBillingDataGrid.GridColor = System.Drawing.Color.LightGray;
            this.UserBillingDataGrid.Location = new System.Drawing.Point(63, 59);
            this.UserBillingDataGrid.Name = "UserBillingDataGrid";
            this.UserBillingDataGrid.RowHeadersVisible = false;
            this.UserBillingDataGrid.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.UserBillingDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.UserBillingDataGrid.RowTemplate.Height = 29;
            this.UserBillingDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UserBillingDataGrid.Size = new System.Drawing.Size(664, 212);
            this.UserBillingDataGrid.TabIndex = 6;
            this.UserBillingDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserBillingDataGrid_CellClick);
            // 
            // UserBillingPay
            // 
            this.UserBillingPay.BackColor = System.Drawing.Color.LightCoral;
            this.UserBillingPay.FlatAppearance.BorderSize = 0;
            this.UserBillingPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserBillingPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserBillingPay.ForeColor = System.Drawing.Color.White;
            this.UserBillingPay.Location = new System.Drawing.Point(330, 389);
            this.UserBillingPay.Name = "UserBillingPay";
            this.UserBillingPay.Size = new System.Drawing.Size(143, 40);
            this.UserBillingPay.TabIndex = 7;
            this.UserBillingPay.Text = "Pay Now";
            this.UserBillingPay.UseVisualStyleBackColor = false;
            this.UserBillingPay.Click += new System.EventHandler(this.UserPay_Click);
            // 
            // UserBillUserIdTxt
            // 
            this.UserBillUserIdTxt.BackColor = System.Drawing.Color.Crimson;
            this.UserBillUserIdTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserBillUserIdTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserBillUserIdTxt.ForeColor = System.Drawing.Color.White;
            this.UserBillUserIdTxt.Location = new System.Drawing.Point(475, 22);
            this.UserBillUserIdTxt.Name = "UserBillUserIdTxt";
            this.UserBillUserIdTxt.Size = new System.Drawing.Size(163, 17);
            this.UserBillUserIdTxt.TabIndex = 59;
            // 
            // UserBillServiceName
            // 
            this.UserBillServiceName.BackColor = System.Drawing.Color.Crimson;
            this.UserBillServiceName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserBillServiceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserBillServiceName.ForeColor = System.Drawing.Color.White;
            this.UserBillServiceName.Location = new System.Drawing.Point(241, 312);
            this.UserBillServiceName.Name = "UserBillServiceName";
            this.UserBillServiceName.Size = new System.Drawing.Size(163, 17);
            this.UserBillServiceName.TabIndex = 60;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(385, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 57;
            this.label2.Text = "Your ID :";
            // 
            // UsrIDToolsLbl
            // 
            this.UsrIDToolsLbl.AutoSize = true;
            this.UsrIDToolsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UsrIDToolsLbl.ForeColor = System.Drawing.Color.White;
            this.UsrIDToolsLbl.Location = new System.Drawing.Point(63, 312);
            this.UsrIDToolsLbl.Name = "UsrIDToolsLbl";
            this.UsrIDToolsLbl.Size = new System.Drawing.Size(147, 25);
            this.UsrIDToolsLbl.TabIndex = 58;
            this.UsrIDToolsLbl.Text = "Service Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(63, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 58;
            this.label1.Text = "Provider ID";
            // 
            // UserBillPvdId
            // 
            this.UserBillPvdId.BackColor = System.Drawing.Color.Crimson;
            this.UserBillPvdId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserBillPvdId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserBillPvdId.ForeColor = System.Drawing.Color.White;
            this.UserBillPvdId.Location = new System.Drawing.Point(241, 276);
            this.UserBillPvdId.Name = "UserBillPvdId";
            this.UserBillPvdId.Size = new System.Drawing.Size(163, 17);
            this.UserBillPvdId.TabIndex = 60;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(63, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 25);
            this.label4.TabIndex = 58;
            this.label4.Text = "Account Number";
            // 
            // UserAccNumTxt
            // 
            this.UserAccNumTxt.BackColor = System.Drawing.Color.Crimson;
            this.UserAccNumTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserAccNumTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserAccNumTxt.ForeColor = System.Drawing.Color.White;
            this.UserAccNumTxt.Location = new System.Drawing.Point(241, 352);
            this.UserAccNumTxt.Name = "UserAccNumTxt";
            this.UserAccNumTxt.Size = new System.Drawing.Size(390, 17);
            this.UserAccNumTxt.TabIndex = 60;
            // 
            // UserBillSearch
            // 
            this.UserBillSearch.BackColor = System.Drawing.Color.LightCoral;
            this.UserBillSearch.FlatAppearance.BorderSize = 0;
            this.UserBillSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserBillSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserBillSearch.ForeColor = System.Drawing.Color.White;
            this.UserBillSearch.Location = new System.Drawing.Point(644, 20);
            this.UserBillSearch.Name = "UserBillSearch";
            this.UserBillSearch.Size = new System.Drawing.Size(79, 30);
            this.UserBillSearch.TabIndex = 62;
            this.UserBillSearch.Text = "Check";
            this.UserBillSearch.UseVisualStyleBackColor = false;
            this.UserBillSearch.Click += new System.EventHandler(this.UserBillSearch_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(241, 378);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(390, 5);
            this.panel2.TabIndex = 64;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(241, 338);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 5);
            this.panel1.TabIndex = 64;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(241, 302);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(165, 5);
            this.panel3.TabIndex = 64;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(475, 48);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(165, 5);
            this.panel4.TabIndex = 64;
            // 
            // UserBilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.UserBillSearch);
            this.Controls.Add(this.UserBillUserIdTxt);
            this.Controls.Add(this.UserBillPvdId);
            this.Controls.Add(this.UserAccNumTxt);
            this.Controls.Add(this.UserBillServiceName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UsrIDToolsLbl);
            this.Controls.Add(this.UserBillingPay);
            this.Controls.Add(this.UserBillingDataGrid);
            this.Controls.Add(this.label3);
            this.Name = "UserBilling";
            this.Text = "Billing";
            this.Load += new System.EventHandler(this.UserBilling_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserBillingDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView UserBillingDataGrid;
        private System.Windows.Forms.Button UserBillingPay;
        private System.Windows.Forms.TextBox UserBillUserIdTxt;
        private System.Windows.Forms.TextBox UserBillServiceName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label UsrIDToolsLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UserBillPvdId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox UserAccNumTxt;
        private System.Windows.Forms.Button UserBillSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}