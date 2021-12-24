
namespace MedicalService.Adminforms
{
    partial class AdminUsers
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.ProviderPassNew = new System.Windows.Forms.Label();
            this.AdminUserIdtxt = new System.Windows.Forms.TextBox();
            this.AdminUserSrchtxt = new System.Windows.Forms.TextBox();
            this.btnAdminUserSearch = new System.Windows.Forms.Button();
            this.btnAdminUserDelete = new System.Windows.Forms.Button();
            this.AdminUserDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.AdminUserDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(201, 401);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(274, 5);
            this.panel4.TabIndex = 35;
            // 
            // ProviderPassNew
            // 
            this.ProviderPassNew.AutoSize = true;
            this.ProviderPassNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProviderPassNew.ForeColor = System.Drawing.Color.White;
            this.ProviderPassNew.Location = new System.Drawing.Point(81, 377);
            this.ProviderPassNew.Name = "ProviderPassNew";
            this.ProviderPassNew.Size = new System.Drawing.Size(114, 29);
            this.ProviderPassNew.TabIndex = 34;
            this.ProviderPassNew.Text = "User ID :";
            // 
            // AdminUserIdtxt
            // 
            this.AdminUserIdtxt.BackColor = System.Drawing.Color.DarkTurquoise;
            this.AdminUserIdtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AdminUserIdtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AdminUserIdtxt.ForeColor = System.Drawing.Color.White;
            this.AdminUserIdtxt.Location = new System.Drawing.Point(201, 375);
            this.AdminUserIdtxt.Name = "AdminUserIdtxt";
            this.AdminUserIdtxt.Size = new System.Drawing.Size(274, 17);
            this.AdminUserIdtxt.TabIndex = 32;
            // 
            // AdminUserSrchtxt
            // 
            this.AdminUserSrchtxt.BackColor = System.Drawing.Color.DarkTurquoise;
            this.AdminUserSrchtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AdminUserSrchtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AdminUserSrchtxt.ForeColor = System.Drawing.Color.White;
            this.AdminUserSrchtxt.Location = new System.Drawing.Point(414, 41);
            this.AdminUserSrchtxt.Name = "AdminUserSrchtxt";
            this.AdminUserSrchtxt.Size = new System.Drawing.Size(160, 17);
            this.AdminUserSrchtxt.TabIndex = 33;
            // 
            // btnAdminUserSearch
            // 
            this.btnAdminUserSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdminUserSearch.FlatAppearance.BorderSize = 0;
            this.btnAdminUserSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminUserSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdminUserSearch.ForeColor = System.Drawing.Color.White;
            this.btnAdminUserSearch.Location = new System.Drawing.Point(583, 32);
            this.btnAdminUserSearch.Name = "btnAdminUserSearch";
            this.btnAdminUserSearch.Size = new System.Drawing.Size(100, 40);
            this.btnAdminUserSearch.TabIndex = 30;
            this.btnAdminUserSearch.Text = "Search";
            this.btnAdminUserSearch.UseVisualStyleBackColor = false;
            this.btnAdminUserSearch.Click += new System.EventHandler(this.btnAdminUserSearch_Click);
            // 
            // btnAdminUserDelete
            // 
            this.btnAdminUserDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdminUserDelete.FlatAppearance.BorderSize = 0;
            this.btnAdminUserDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminUserDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdminUserDelete.ForeColor = System.Drawing.Color.White;
            this.btnAdminUserDelete.Location = new System.Drawing.Point(495, 375);
            this.btnAdminUserDelete.Name = "btnAdminUserDelete";
            this.btnAdminUserDelete.Size = new System.Drawing.Size(100, 40);
            this.btnAdminUserDelete.TabIndex = 31;
            this.btnAdminUserDelete.Text = "Delete";
            this.btnAdminUserDelete.UseVisualStyleBackColor = false;
            this.btnAdminUserDelete.Click += new System.EventHandler(this.btnAdminUserDelete_Click);
            // 
            // AdminUserDataGrid
            // 
            this.AdminUserDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.AdminUserDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AdminUserDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.AdminUserDataGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.AdminUserDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AdminUserDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.AdminUserDataGrid.ColumnHeadersHeight = 35;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AdminUserDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.AdminUserDataGrid.EnableHeadersVisualStyles = false;
            this.AdminUserDataGrid.GridColor = System.Drawing.Color.LightGray;
            this.AdminUserDataGrid.Location = new System.Drawing.Point(47, 78);
            this.AdminUserDataGrid.Name = "AdminUserDataGrid";
            this.AdminUserDataGrid.RowHeadersVisible = false;
            this.AdminUserDataGrid.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.AdminUserDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.AdminUserDataGrid.RowTemplate.Height = 29;
            this.AdminUserDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AdminUserDataGrid.Size = new System.Drawing.Size(636, 287);
            this.AdminUserDataGrid.TabIndex = 29;
            this.AdminUserDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AdminUsrDataCell_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(356, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 29);
            this.label1.TabIndex = 37;
            this.label1.Text = "ID :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(414, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 5);
            this.panel1.TabIndex = 38;
            // 
            // AdminUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.ProviderPassNew);
            this.Controls.Add(this.AdminUserIdtxt);
            this.Controls.Add(this.AdminUserSrchtxt);
            this.Controls.Add(this.btnAdminUserSearch);
            this.Controls.Add(this.btnAdminUserDelete);
            this.Controls.Add(this.AdminUserDataGrid);
            this.Name = "AdminUsers";
            this.Text = "AdminUsers";
            this.Load += new System.EventHandler(this.AdminUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AdminUserDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label ProviderPassNew;
        private System.Windows.Forms.TextBox AdminUserIdtxt;
        private System.Windows.Forms.TextBox AdminUserSrchtxt;
        private System.Windows.Forms.Button btnAdminUserSearch;
        private System.Windows.Forms.Button btnAdminUserDelete;
        private System.Windows.Forms.DataGridView AdminUserDataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}