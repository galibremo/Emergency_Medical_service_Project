
namespace MedicalService.Adminforms
{
    partial class AdminMediators
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
            this.AdminMedIdtxt = new System.Windows.Forms.TextBox();
            this.AdminMedSrchtxt = new System.Windows.Forms.TextBox();
            this.btnAdminMedSearch = new System.Windows.Forms.Button();
            this.btnAdminMedDelete = new System.Windows.Forms.Button();
            this.AdminMedDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.AdminMedDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(204, 408);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(274, 5);
            this.panel4.TabIndex = 35;
            // 
            // ProviderPassNew
            // 
            this.ProviderPassNew.AutoSize = true;
            this.ProviderPassNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProviderPassNew.ForeColor = System.Drawing.Color.White;
            this.ProviderPassNew.Location = new System.Drawing.Point(36, 375);
            this.ProviderPassNew.Name = "ProviderPassNew";
            this.ProviderPassNew.Size = new System.Drawing.Size(162, 29);
            this.ProviderPassNew.TabIndex = 34;
            this.ProviderPassNew.Text = "Mediator ID :";
            // 
            // AdminMedIdtxt
            // 
            this.AdminMedIdtxt.BackColor = System.Drawing.Color.DarkTurquoise;
            this.AdminMedIdtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AdminMedIdtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AdminMedIdtxt.ForeColor = System.Drawing.Color.White;
            this.AdminMedIdtxt.Location = new System.Drawing.Point(204, 382);
            this.AdminMedIdtxt.Name = "AdminMedIdtxt";
            this.AdminMedIdtxt.Size = new System.Drawing.Size(271, 17);
            this.AdminMedIdtxt.TabIndex = 32;
            // 
            // AdminMedSrchtxt
            // 
            this.AdminMedSrchtxt.BackColor = System.Drawing.Color.DarkTurquoise;
            this.AdminMedSrchtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AdminMedSrchtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AdminMedSrchtxt.ForeColor = System.Drawing.Color.White;
            this.AdminMedSrchtxt.Location = new System.Drawing.Point(417, 41);
            this.AdminMedSrchtxt.Name = "AdminMedSrchtxt";
            this.AdminMedSrchtxt.Size = new System.Drawing.Size(160, 17);
            this.AdminMedSrchtxt.TabIndex = 33;
            // 
            // btnAdminMedSearch
            // 
            this.btnAdminMedSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdminMedSearch.FlatAppearance.BorderSize = 0;
            this.btnAdminMedSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminMedSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdminMedSearch.ForeColor = System.Drawing.Color.White;
            this.btnAdminMedSearch.Location = new System.Drawing.Point(586, 32);
            this.btnAdminMedSearch.Name = "btnAdminMedSearch";
            this.btnAdminMedSearch.Size = new System.Drawing.Size(100, 40);
            this.btnAdminMedSearch.TabIndex = 30;
            this.btnAdminMedSearch.Text = "Search";
            this.btnAdminMedSearch.UseVisualStyleBackColor = false;
            this.btnAdminMedSearch.Click += new System.EventHandler(this.btnAdminMedSearch_Click);
            // 
            // btnAdminMedDelete
            // 
            this.btnAdminMedDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdminMedDelete.FlatAppearance.BorderSize = 0;
            this.btnAdminMedDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminMedDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdminMedDelete.ForeColor = System.Drawing.Color.White;
            this.btnAdminMedDelete.Location = new System.Drawing.Point(495, 375);
            this.btnAdminMedDelete.Name = "btnAdminMedDelete";
            this.btnAdminMedDelete.Size = new System.Drawing.Size(100, 40);
            this.btnAdminMedDelete.TabIndex = 31;
            this.btnAdminMedDelete.Text = "Delete";
            this.btnAdminMedDelete.UseVisualStyleBackColor = false;
            this.btnAdminMedDelete.Click += new System.EventHandler(this.btnAdminMedDelete_Click);
            // 
            // AdminMedDataGrid
            // 
            this.AdminMedDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.AdminMedDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AdminMedDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.AdminMedDataGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.AdminMedDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AdminMedDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.AdminMedDataGrid.ColumnHeadersHeight = 35;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AdminMedDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.AdminMedDataGrid.EnableHeadersVisualStyles = false;
            this.AdminMedDataGrid.GridColor = System.Drawing.Color.LightGray;
            this.AdminMedDataGrid.Location = new System.Drawing.Point(47, 78);
            this.AdminMedDataGrid.Name = "AdminMedDataGrid";
            this.AdminMedDataGrid.RowHeadersVisible = false;
            this.AdminMedDataGrid.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.AdminMedDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.AdminMedDataGrid.RowTemplate.Height = 29;
            this.AdminMedDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AdminMedDataGrid.Size = new System.Drawing.Size(639, 287);
            this.AdminMedDataGrid.TabIndex = 29;
            this.AdminMedDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AdminMedDataCell_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(359, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 29);
            this.label1.TabIndex = 36;
            this.label1.Text = "ID :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(417, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 5);
            this.panel1.TabIndex = 36;
            // 
            // AdminMediators
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.ProviderPassNew);
            this.Controls.Add(this.AdminMedIdtxt);
            this.Controls.Add(this.AdminMedSrchtxt);
            this.Controls.Add(this.btnAdminMedSearch);
            this.Controls.Add(this.btnAdminMedDelete);
            this.Controls.Add(this.AdminMedDataGrid);
            this.Name = "AdminMediators";
            this.Text = "AdminMediators";
            this.Load += new System.EventHandler(this.AdminMediators_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AdminMedDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label ProviderPassNew;
        private System.Windows.Forms.TextBox AdminMedIdtxt;
        private System.Windows.Forms.TextBox AdminMedSrchtxt;
        private System.Windows.Forms.Button btnAdminMedSearch;
        private System.Windows.Forms.Button btnAdminMedDelete;
        private System.Windows.Forms.DataGridView AdminMedDataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}