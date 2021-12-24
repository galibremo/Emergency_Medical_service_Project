
namespace MedicalService.Adminforms
{
    partial class AdminProviders
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
            this.AdminPvdDataGrid = new System.Windows.Forms.DataGridView();
            this.AdminPvdSrchtxt = new System.Windows.Forms.TextBox();
            this.btnAdminPvdSearch = new System.Windows.Forms.Button();
            this.btnAdminPvdDelete = new System.Windows.Forms.Button();
            this.AdminPvdIdtxt = new System.Windows.Forms.TextBox();
            this.ProviderPassNew = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.AdminPvdDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AdminPvdDataGrid
            // 
            this.AdminPvdDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.AdminPvdDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AdminPvdDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.AdminPvdDataGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.AdminPvdDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AdminPvdDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.AdminPvdDataGrid.ColumnHeadersHeight = 35;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AdminPvdDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.AdminPvdDataGrid.EnableHeadersVisualStyles = false;
            this.AdminPvdDataGrid.GridColor = System.Drawing.Color.LightGray;
            this.AdminPvdDataGrid.Location = new System.Drawing.Point(46, 63);
            this.AdminPvdDataGrid.Name = "AdminPvdDataGrid";
            this.AdminPvdDataGrid.RowHeadersVisible = false;
            this.AdminPvdDataGrid.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.AdminPvdDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.AdminPvdDataGrid.RowTemplate.Height = 29;
            this.AdminPvdDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AdminPvdDataGrid.Size = new System.Drawing.Size(648, 287);
            this.AdminPvdDataGrid.TabIndex = 0;
            this.AdminPvdDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AdminPvdDataCell_Click);
            // 
            // AdminPvdSrchtxt
            // 
            this.AdminPvdSrchtxt.BackColor = System.Drawing.Color.DarkTurquoise;
            this.AdminPvdSrchtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AdminPvdSrchtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AdminPvdSrchtxt.ForeColor = System.Drawing.Color.White;
            this.AdminPvdSrchtxt.Location = new System.Drawing.Point(425, 26);
            this.AdminPvdSrchtxt.Name = "AdminPvdSrchtxt";
            this.AdminPvdSrchtxt.Size = new System.Drawing.Size(160, 17);
            this.AdminPvdSrchtxt.TabIndex = 26;
            // 
            // btnAdminPvdSearch
            // 
            this.btnAdminPvdSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdminPvdSearch.FlatAppearance.BorderSize = 0;
            this.btnAdminPvdSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminPvdSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdminPvdSearch.ForeColor = System.Drawing.Color.White;
            this.btnAdminPvdSearch.Location = new System.Drawing.Point(594, 17);
            this.btnAdminPvdSearch.Name = "btnAdminPvdSearch";
            this.btnAdminPvdSearch.Size = new System.Drawing.Size(100, 40);
            this.btnAdminPvdSearch.TabIndex = 24;
            this.btnAdminPvdSearch.Text = "Search";
            this.btnAdminPvdSearch.UseVisualStyleBackColor = false;
            this.btnAdminPvdSearch.Click += new System.EventHandler(this.btnAdminPvdSearch_Click);
            // 
            // btnAdminPvdDelete
            // 
            this.btnAdminPvdDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdminPvdDelete.FlatAppearance.BorderSize = 0;
            this.btnAdminPvdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminPvdDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdminPvdDelete.ForeColor = System.Drawing.Color.White;
            this.btnAdminPvdDelete.Location = new System.Drawing.Point(494, 360);
            this.btnAdminPvdDelete.Name = "btnAdminPvdDelete";
            this.btnAdminPvdDelete.Size = new System.Drawing.Size(100, 40);
            this.btnAdminPvdDelete.TabIndex = 25;
            this.btnAdminPvdDelete.Text = "Delete";
            this.btnAdminPvdDelete.UseVisualStyleBackColor = false;
            this.btnAdminPvdDelete.Click += new System.EventHandler(this.btnAdminPvdDelete_Click);
            // 
            // AdminPvdIdtxt
            // 
            this.AdminPvdIdtxt.BackColor = System.Drawing.Color.DarkTurquoise;
            this.AdminPvdIdtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AdminPvdIdtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AdminPvdIdtxt.ForeColor = System.Drawing.Color.White;
            this.AdminPvdIdtxt.Location = new System.Drawing.Point(210, 360);
            this.AdminPvdIdtxt.Name = "AdminPvdIdtxt";
            this.AdminPvdIdtxt.Size = new System.Drawing.Size(274, 17);
            this.AdminPvdIdtxt.TabIndex = 26;
            // 
            // ProviderPassNew
            // 
            this.ProviderPassNew.AutoSize = true;
            this.ProviderPassNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProviderPassNew.ForeColor = System.Drawing.Color.White;
            this.ProviderPassNew.Location = new System.Drawing.Point(46, 360);
            this.ProviderPassNew.Name = "ProviderPassNew";
            this.ProviderPassNew.Size = new System.Drawing.Size(158, 29);
            this.ProviderPassNew.TabIndex = 27;
            this.ProviderPassNew.Text = "Provider ID :";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(210, 386);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(274, 5);
            this.panel4.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(367, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 29);
            this.label1.TabIndex = 37;
            this.label1.Text = "ID :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(425, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 5);
            this.panel1.TabIndex = 37;
            // 
            // AdminProviders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.ProviderPassNew);
            this.Controls.Add(this.AdminPvdIdtxt);
            this.Controls.Add(this.AdminPvdSrchtxt);
            this.Controls.Add(this.btnAdminPvdSearch);
            this.Controls.Add(this.btnAdminPvdDelete);
            this.Controls.Add(this.AdminPvdDataGrid);
            this.Name = "AdminProviders";
            this.Text = "AdminProviders";
            this.Load += new System.EventHandler(this.AdminProviders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AdminPvdDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AdminPvdDataGrid;
        private System.Windows.Forms.TextBox AdminPvdSrchtxt;
        private System.Windows.Forms.Button btnAdminPvdSearch;
        private System.Windows.Forms.Button btnAdminPvdDelete;
        private System.Windows.Forms.TextBox AdminPvdIdtxt;
        private System.Windows.Forms.Label ProviderPassNew;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}