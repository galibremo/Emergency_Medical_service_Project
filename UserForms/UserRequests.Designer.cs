
namespace MedicalService.UserForms
{
    partial class UserRequests
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ReqUserIdtxt = new System.Windows.Forms.TextBox();
            this.UserReqQuantitytxt = new System.Windows.Forms.TextBox();
            this.UserRequestsDelete = new System.Windows.Forms.Button();
            this.UserRequestsDataGrid = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UserReqPvdIDtxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.UserReqNametxt = new System.Windows.Forms.Label();
            this.UserReqTypetxt = new System.Windows.Forms.TextBox();
            this.UserSerNamTxt = new System.Windows.Forms.TextBox();
            this.UserReqCosttxt = new System.Windows.Forms.Label();
            this.UserMyReqCheck = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.UserRequestsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(435, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(52, 380);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Quantity";
            // 
            // ReqUserIdtxt
            // 
            this.ReqUserIdtxt.BackColor = System.Drawing.Color.Crimson;
            this.ReqUserIdtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReqUserIdtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ReqUserIdtxt.ForeColor = System.Drawing.Color.White;
            this.ReqUserIdtxt.Location = new System.Drawing.Point(525, 26);
            this.ReqUserIdtxt.Name = "ReqUserIdtxt";
            this.ReqUserIdtxt.Size = new System.Drawing.Size(145, 17);
            this.ReqUserIdtxt.TabIndex = 1;
            // 
            // UserReqQuantitytxt
            // 
            this.UserReqQuantitytxt.BackColor = System.Drawing.Color.Crimson;
            this.UserReqQuantitytxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserReqQuantitytxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserReqQuantitytxt.ForeColor = System.Drawing.Color.White;
            this.UserReqQuantitytxt.Location = new System.Drawing.Point(205, 381);
            this.UserReqQuantitytxt.Name = "UserReqQuantitytxt";
            this.UserReqQuantitytxt.Size = new System.Drawing.Size(165, 17);
            this.UserReqQuantitytxt.TabIndex = 1;
            this.UserReqQuantitytxt.TextChanged += new System.EventHandler(this.UserQuantity_TextChanged);
            // 
            // UserRequestsDelete
            // 
            this.UserRequestsDelete.BackColor = System.Drawing.Color.LightCoral;
            this.UserRequestsDelete.FlatAppearance.BorderSize = 0;
            this.UserRequestsDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserRequestsDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserRequestsDelete.ForeColor = System.Drawing.Color.White;
            this.UserRequestsDelete.Location = new System.Drawing.Point(387, 404);
            this.UserRequestsDelete.Name = "UserRequestsDelete";
            this.UserRequestsDelete.Size = new System.Drawing.Size(100, 34);
            this.UserRequestsDelete.TabIndex = 2;
            this.UserRequestsDelete.Text = "Delete";
            this.UserRequestsDelete.UseVisualStyleBackColor = false;
            this.UserRequestsDelete.Click += new System.EventHandler(this.UserRequestsDelete_Click);
            // 
            // UserRequestsDataGrid
            // 
            this.UserRequestsDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.UserRequestsDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserRequestsDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.UserRequestsDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UserRequestsDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.UserRequestsDataGrid.ColumnHeadersHeight = 35;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UserRequestsDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.UserRequestsDataGrid.EnableHeadersVisualStyles = false;
            this.UserRequestsDataGrid.GridColor = System.Drawing.Color.LightGray;
            this.UserRequestsDataGrid.Location = new System.Drawing.Point(52, 65);
            this.UserRequestsDataGrid.Name = "UserRequestsDataGrid";
            this.UserRequestsDataGrid.RowHeadersVisible = false;
            this.UserRequestsDataGrid.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.UserRequestsDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.UserRequestsDataGrid.RowTemplate.Height = 29;
            this.UserRequestsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UserRequestsDataGrid.Size = new System.Drawing.Size(695, 236);
            this.UserRequestsDataGrid.TabIndex = 3;
            this.UserRequestsDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserMyReqDataGrid_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(52, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(52, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Provider ID";
            // 
            // UserReqPvdIDtxt
            // 
            this.UserReqPvdIDtxt.BackColor = System.Drawing.Color.Crimson;
            this.UserReqPvdIDtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserReqPvdIDtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserReqPvdIDtxt.ForeColor = System.Drawing.Color.White;
            this.UserReqPvdIDtxt.Location = new System.Drawing.Point(205, 307);
            this.UserReqPvdIDtxt.Name = "UserReqPvdIDtxt";
            this.UserReqPvdIDtxt.Size = new System.Drawing.Size(165, 17);
            this.UserReqPvdIDtxt.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(52, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Service Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(471, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Cost";
            // 
            // UserReqNametxt
            // 
            this.UserReqNametxt.AutoSize = true;
            this.UserReqNametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserReqNametxt.ForeColor = System.Drawing.Color.White;
            this.UserReqNametxt.Location = new System.Drawing.Point(387, 306);
            this.UserReqNametxt.Name = "UserReqNametxt";
            this.UserReqNametxt.Size = new System.Drawing.Size(147, 25);
            this.UserReqNametxt.TabIndex = 0;
            this.UserReqNametxt.Text = "Service Name";
            // 
            // UserReqTypetxt
            // 
            this.UserReqTypetxt.BackColor = System.Drawing.Color.Crimson;
            this.UserReqTypetxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserReqTypetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserReqTypetxt.ForeColor = System.Drawing.Color.White;
            this.UserReqTypetxt.Location = new System.Drawing.Point(205, 344);
            this.UserReqTypetxt.Name = "UserReqTypetxt";
            this.UserReqTypetxt.Size = new System.Drawing.Size(165, 17);
            this.UserReqTypetxt.TabIndex = 1;
            // 
            // UserSerNamTxt
            // 
            this.UserSerNamTxt.BackColor = System.Drawing.Color.Crimson;
            this.UserSerNamTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserSerNamTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserSerNamTxt.ForeColor = System.Drawing.Color.White;
            this.UserSerNamTxt.Location = new System.Drawing.Point(540, 306);
            this.UserSerNamTxt.Name = "UserSerNamTxt";
            this.UserSerNamTxt.Size = new System.Drawing.Size(165, 17);
            this.UserSerNamTxt.TabIndex = 1;
            // 
            // UserReqCosttxt
            // 
            this.UserReqCosttxt.AutoSize = true;
            this.UserReqCosttxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserReqCosttxt.ForeColor = System.Drawing.Color.White;
            this.UserReqCosttxt.Location = new System.Drawing.Point(551, 353);
            this.UserReqCosttxt.Name = "UserReqCosttxt";
            this.UserReqCosttxt.Size = new System.Drawing.Size(0, 18);
            this.UserReqCosttxt.TabIndex = 5;
            // 
            // UserMyReqCheck
            // 
            this.UserMyReqCheck.BackColor = System.Drawing.Color.LightCoral;
            this.UserMyReqCheck.FlatAppearance.BorderSize = 0;
            this.UserMyReqCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserMyReqCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserMyReqCheck.ForeColor = System.Drawing.Color.White;
            this.UserMyReqCheck.Location = new System.Drawing.Point(678, 25);
            this.UserMyReqCheck.Name = "UserMyReqCheck";
            this.UserMyReqCheck.Size = new System.Drawing.Size(69, 28);
            this.UserMyReqCheck.TabIndex = 7;
            this.UserMyReqCheck.Text = "Check";
            this.UserMyReqCheck.UseVisualStyleBackColor = false;
            this.UserMyReqCheck.Click += new System.EventHandler(this.UserMyReqCheck_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(540, 332);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(165, 5);
            this.panel4.TabIndex = 65;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(205, 407);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 5);
            this.panel1.TabIndex = 65;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(205, 370);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(165, 5);
            this.panel2.TabIndex = 65;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(205, 333);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(165, 5);
            this.panel3.TabIndex = 65;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(525, 52);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(145, 5);
            this.panel5.TabIndex = 65;
            // 
            // UserRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.UserMyReqCheck);
            this.Controls.Add(this.UserReqCosttxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UserRequestsDataGrid);
            this.Controls.Add(this.UserRequestsDelete);
            this.Controls.Add(this.UserReqQuantitytxt);
            this.Controls.Add(this.UserSerNamTxt);
            this.Controls.Add(this.UserReqPvdIDtxt);
            this.Controls.Add(this.UserReqTypetxt);
            this.Controls.Add(this.ReqUserIdtxt);
            this.Controls.Add(this.UserReqNametxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "UserRequests";
            this.Text = "My Requests";
            this.Load += new System.EventHandler(this.UserRequests_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserRequestsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ReqUserIdtxt;
        private System.Windows.Forms.TextBox UserReqQuantitytxt;
        private System.Windows.Forms.Button UserRequestsDelete;
        private System.Windows.Forms.DataGridView UserRequestsDataGrid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox UserReqPvdIDtxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label UserReqNametxt;
        private System.Windows.Forms.TextBox UserReqTypetxt;
        private System.Windows.Forms.TextBox UserSerNamTxt;
        private System.Windows.Forms.Label UserReqCosttxt;
        private System.Windows.Forms.Button UserMyReqCheck;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
    }
}