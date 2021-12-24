
namespace MedicalService.Adminforms
{
    partial class AdminService
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.ProviderPassNew = new System.Windows.Forms.Label();
            this.AdminReqPvdIdtxt = new System.Windows.Forms.TextBox();
            this.btnAdminReqSearch = new System.Windows.Forms.Button();
            this.AdminReqDataGrid = new System.Windows.Forms.DataGridView();
            this.AdminReqUserIdtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AdminReqSvcNametxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.AdminReqDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(47, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 29);
            this.label1.TabIndex = 45;
            this.label1.Text = "Requests";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(244, 364);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(169, 5);
            this.panel4.TabIndex = 44;
            // 
            // ProviderPassNew
            // 
            this.ProviderPassNew.AutoSize = true;
            this.ProviderPassNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProviderPassNew.ForeColor = System.Drawing.Color.White;
            this.ProviderPassNew.Location = new System.Drawing.Point(56, 340);
            this.ProviderPassNew.Name = "ProviderPassNew";
            this.ProviderPassNew.Size = new System.Drawing.Size(158, 29);
            this.ProviderPassNew.TabIndex = 43;
            this.ProviderPassNew.Text = "Provider ID :";
            // 
            // AdminReqPvdIdtxt
            // 
            this.AdminReqPvdIdtxt.BackColor = System.Drawing.Color.DarkTurquoise;
            this.AdminReqPvdIdtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AdminReqPvdIdtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AdminReqPvdIdtxt.ForeColor = System.Drawing.Color.White;
            this.AdminReqPvdIdtxt.Location = new System.Drawing.Point(244, 338);
            this.AdminReqPvdIdtxt.Name = "AdminReqPvdIdtxt";
            this.AdminReqPvdIdtxt.Size = new System.Drawing.Size(169, 17);
            this.AdminReqPvdIdtxt.TabIndex = 41;
            // 
            // btnAdminReqSearch
            // 
            this.btnAdminReqSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdminReqSearch.FlatAppearance.BorderSize = 0;
            this.btnAdminReqSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminReqSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdminReqSearch.ForeColor = System.Drawing.Color.White;
            this.btnAdminReqSearch.Location = new System.Drawing.Point(488, 380);
            this.btnAdminReqSearch.Name = "btnAdminReqSearch";
            this.btnAdminReqSearch.Size = new System.Drawing.Size(100, 40);
            this.btnAdminReqSearch.TabIndex = 39;
            this.btnAdminReqSearch.Text = "Search";
            this.btnAdminReqSearch.UseVisualStyleBackColor = false;
            this.btnAdminReqSearch.Click += new System.EventHandler(this.btnAdminReqSearch_Click);
            // 
            // AdminReqDataGrid
            // 
            this.AdminReqDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.AdminReqDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AdminReqDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.AdminReqDataGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.AdminReqDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AdminReqDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.AdminReqDataGrid.ColumnHeadersHeight = 35;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AdminReqDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.AdminReqDataGrid.EnableHeadersVisualStyles = false;
            this.AdminReqDataGrid.GridColor = System.Drawing.Color.LightGray;
            this.AdminReqDataGrid.Location = new System.Drawing.Point(47, 43);
            this.AdminReqDataGrid.Name = "AdminReqDataGrid";
            this.AdminReqDataGrid.RowHeadersVisible = false;
            this.AdminReqDataGrid.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.AdminReqDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.AdminReqDataGrid.RowTemplate.Height = 29;
            this.AdminReqDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AdminReqDataGrid.Size = new System.Drawing.Size(650, 287);
            this.AdminReqDataGrid.TabIndex = 38;
            this.AdminReqDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AdminReqDataGridCell_Click);
            // 
            // AdminReqUserIdtxt
            // 
            this.AdminReqUserIdtxt.BackColor = System.Drawing.Color.DarkTurquoise;
            this.AdminReqUserIdtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AdminReqUserIdtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AdminReqUserIdtxt.ForeColor = System.Drawing.Color.White;
            this.AdminReqUserIdtxt.Location = new System.Drawing.Point(546, 336);
            this.AdminReqUserIdtxt.Name = "AdminReqUserIdtxt";
            this.AdminReqUserIdtxt.Size = new System.Drawing.Size(151, 17);
            this.AdminReqUserIdtxt.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(426, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 29);
            this.label2.TabIndex = 43;
            this.label2.Text = "User ID :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(546, 362);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(152, 5);
            this.panel1.TabIndex = 44;
            // 
            // AdminReqSvcNametxt
            // 
            this.AdminReqSvcNametxt.BackColor = System.Drawing.Color.DarkTurquoise;
            this.AdminReqSvcNametxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AdminReqSvcNametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AdminReqSvcNametxt.ForeColor = System.Drawing.Color.White;
            this.AdminReqSvcNametxt.Location = new System.Drawing.Point(244, 380);
            this.AdminReqSvcNametxt.Name = "AdminReqSvcNametxt";
            this.AdminReqSvcNametxt.Size = new System.Drawing.Size(169, 17);
            this.AdminReqSvcNametxt.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(47, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 29);
            this.label3.TabIndex = 43;
            this.label3.Text = "Service Name :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(244, 406);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(172, 5);
            this.panel2.TabIndex = 44;
            // 
            // AdminService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AdminReqUserIdtxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AdminReqSvcNametxt);
            this.Controls.Add(this.ProviderPassNew);
            this.Controls.Add(this.AdminReqPvdIdtxt);
            this.Controls.Add(this.btnAdminReqSearch);
            this.Controls.Add(this.AdminReqDataGrid);
            this.Name = "AdminService";
            this.Text = "AdminService";
            this.Load += new System.EventHandler(this.AdminService_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AdminReqDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label ProviderPassNew;
        private System.Windows.Forms.TextBox AdminReqPvdIdtxt;
        private System.Windows.Forms.Button btnAdminReqSearch;
        private System.Windows.Forms.DataGridView AdminReqDataGrid;
        private System.Windows.Forms.TextBox AdminReqUserIdtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox AdminReqSvcNametxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
    }
}