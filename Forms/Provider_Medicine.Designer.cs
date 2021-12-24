
namespace MedicalService.Forms
{
    partial class Provider_Medicine
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
            this.PvdMdcDataGrid = new System.Windows.Forms.DataGridView();
            this.btnPvdMedicineUpdate = new System.Windows.Forms.Button();
            this.ProviderMedicineQuantitytxt = new System.Windows.Forms.TextBox();
            this.ProviderMedicineNametxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPvdMedicineDelete = new System.Windows.Forms.Button();
            this.PvdIDMedicinetxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PvdMdcPricetxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPvdMdcInsert = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.PvdMdcSearchtxt = new System.Windows.Forms.TextBox();
            this.btnPvdMdcSearch = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.PvdMdcDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // PvdMdcDataGrid
            // 
            this.PvdMdcDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PvdMdcDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.PvdMdcDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PvdMdcDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PvdMdcDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.PvdMdcDataGrid.ColumnHeadersHeight = 35;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PvdMdcDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.PvdMdcDataGrid.EnableHeadersVisualStyles = false;
            this.PvdMdcDataGrid.GridColor = System.Drawing.Color.LightGray;
            this.PvdMdcDataGrid.Location = new System.Drawing.Point(70, 69);
            this.PvdMdcDataGrid.Name = "PvdMdcDataGrid";
            this.PvdMdcDataGrid.RowHeadersVisible = false;
            this.PvdMdcDataGrid.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.PvdMdcDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.PvdMdcDataGrid.RowTemplate.Height = 29;
            this.PvdMdcDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PvdMdcDataGrid.Size = new System.Drawing.Size(639, 246);
            this.PvdMdcDataGrid.TabIndex = 0;
            this.PvdMdcDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PvdMedDataCell_Click);
            // 
            // btnPvdMedicineUpdate
            // 
            this.btnPvdMedicineUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPvdMedicineUpdate.FlatAppearance.BorderSize = 0;
            this.btnPvdMedicineUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPvdMedicineUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPvdMedicineUpdate.ForeColor = System.Drawing.Color.White;
            this.btnPvdMedicineUpdate.Location = new System.Drawing.Point(189, 398);
            this.btnPvdMedicineUpdate.Name = "btnPvdMedicineUpdate";
            this.btnPvdMedicineUpdate.Size = new System.Drawing.Size(113, 40);
            this.btnPvdMedicineUpdate.TabIndex = 7;
            this.btnPvdMedicineUpdate.Text = "Update";
            this.btnPvdMedicineUpdate.UseVisualStyleBackColor = false;
            this.btnPvdMedicineUpdate.Click += new System.EventHandler(this.PvdMedicineUpdate_Click);
            // 
            // ProviderMedicineQuantitytxt
            // 
            this.ProviderMedicineQuantitytxt.BackColor = System.Drawing.Color.DodgerBlue;
            this.ProviderMedicineQuantitytxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProviderMedicineQuantitytxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProviderMedicineQuantitytxt.ForeColor = System.Drawing.Color.White;
            this.ProviderMedicineQuantitytxt.Location = new System.Drawing.Point(272, 359);
            this.ProviderMedicineQuantitytxt.Name = "ProviderMedicineQuantitytxt";
            this.ProviderMedicineQuantitytxt.Size = new System.Drawing.Size(163, 17);
            this.ProviderMedicineQuantitytxt.TabIndex = 5;
            // 
            // ProviderMedicineNametxt
            // 
            this.ProviderMedicineNametxt.BackColor = System.Drawing.Color.DodgerBlue;
            this.ProviderMedicineNametxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProviderMedicineNametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProviderMedicineNametxt.ForeColor = System.Drawing.Color.White;
            this.ProviderMedicineNametxt.Location = new System.Drawing.Point(272, 322);
            this.ProviderMedicineNametxt.Name = "ProviderMedicineNametxt";
            this.ProviderMedicineNametxt.Size = new System.Drawing.Size(163, 17);
            this.ProviderMedicineNametxt.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(70, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Available Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(70, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Medicine Name";
            // 
            // btnPvdMedicineDelete
            // 
            this.btnPvdMedicineDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPvdMedicineDelete.FlatAppearance.BorderSize = 0;
            this.btnPvdMedicineDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPvdMedicineDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPvdMedicineDelete.ForeColor = System.Drawing.Color.White;
            this.btnPvdMedicineDelete.Location = new System.Drawing.Point(308, 398);
            this.btnPvdMedicineDelete.Name = "btnPvdMedicineDelete";
            this.btnPvdMedicineDelete.Size = new System.Drawing.Size(100, 40);
            this.btnPvdMedicineDelete.TabIndex = 8;
            this.btnPvdMedicineDelete.Text = "Delete";
            this.btnPvdMedicineDelete.UseVisualStyleBackColor = false;
            this.btnPvdMedicineDelete.Click += new System.EventHandler(this.ProviderMedicineDelete_Click);
            // 
            // PvdIDMedicinetxt
            // 
            this.PvdIDMedicinetxt.BackColor = System.Drawing.Color.DodgerBlue;
            this.PvdIDMedicinetxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PvdIDMedicinetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PvdIDMedicinetxt.ForeColor = System.Drawing.Color.White;
            this.PvdIDMedicinetxt.Location = new System.Drawing.Point(455, 32);
            this.PvdIDMedicinetxt.Name = "PvdIDMedicinetxt";
            this.PvdIDMedicinetxt.Size = new System.Drawing.Size(163, 17);
            this.PvdIDMedicinetxt.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(352, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "Your ID :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(70, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 25);
            this.label4.TabIndex = 27;
            this.label4.Text = "Available Medicines";
            // 
            // PvdMdcPricetxt
            // 
            this.PvdMdcPricetxt.BackColor = System.Drawing.Color.DodgerBlue;
            this.PvdMdcPricetxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PvdMdcPricetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PvdMdcPricetxt.ForeColor = System.Drawing.Color.White;
            this.PvdMdcPricetxt.Location = new System.Drawing.Point(546, 321);
            this.PvdMdcPricetxt.Name = "PvdMdcPricetxt";
            this.PvdMdcPricetxt.Size = new System.Drawing.Size(163, 17);
            this.PvdMdcPricetxt.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(479, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Price";
            // 
            // btnPvdMdcInsert
            // 
            this.btnPvdMdcInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPvdMdcInsert.FlatAppearance.BorderSize = 0;
            this.btnPvdMdcInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPvdMdcInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPvdMdcInsert.ForeColor = System.Drawing.Color.White;
            this.btnPvdMdcInsert.Location = new System.Drawing.Point(70, 398);
            this.btnPvdMdcInsert.Name = "btnPvdMdcInsert";
            this.btnPvdMdcInsert.Size = new System.Drawing.Size(113, 40);
            this.btnPvdMdcInsert.TabIndex = 7;
            this.btnPvdMdcInsert.Text = "Add";
            this.btnPvdMdcInsert.UseVisualStyleBackColor = false;
            this.btnPvdMdcInsert.Click += new System.EventHandler(this.PvdMdcInsert_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(624, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 32);
            this.button1.TabIndex = 7;
            this.button1.Text = "Check";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.PvdMedicineCheck_Click);
            // 
            // PvdMdcSearchtxt
            // 
            this.PvdMdcSearchtxt.BackColor = System.Drawing.Color.DodgerBlue;
            this.PvdMdcSearchtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PvdMdcSearchtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PvdMdcSearchtxt.ForeColor = System.Drawing.Color.White;
            this.PvdMdcSearchtxt.Location = new System.Drawing.Point(561, 407);
            this.PvdMdcSearchtxt.Name = "PvdMdcSearchtxt";
            this.PvdMdcSearchtxt.Size = new System.Drawing.Size(163, 17);
            this.PvdMdcSearchtxt.TabIndex = 5;
            // 
            // btnPvdMdcSearch
            // 
            this.btnPvdMdcSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPvdMdcSearch.FlatAppearance.BorderSize = 0;
            this.btnPvdMdcSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPvdMdcSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPvdMdcSearch.ForeColor = System.Drawing.Color.White;
            this.btnPvdMdcSearch.Location = new System.Drawing.Point(455, 398);
            this.btnPvdMdcSearch.Name = "btnPvdMdcSearch";
            this.btnPvdMdcSearch.Size = new System.Drawing.Size(100, 40);
            this.btnPvdMdcSearch.TabIndex = 8;
            this.btnPvdMdcSearch.Text = "Search";
            this.btnPvdMdcSearch.UseVisualStyleBackColor = false;
            this.btnPvdMdcSearch.Click += new System.EventHandler(this.ProviderMedicineSearch_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(561, 433);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 5);
            this.panel1.TabIndex = 63;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(546, 348);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(165, 5);
            this.panel2.TabIndex = 63;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(270, 348);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(165, 5);
            this.panel3.TabIndex = 63;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(455, 58);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(165, 5);
            this.panel4.TabIndex = 63;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(270, 384);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(165, 5);
            this.panel5.TabIndex = 63;
            // 
            // Provider_Medicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PvdIDMedicinetxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPvdMdcSearch);
            this.Controls.Add(this.btnPvdMedicineDelete);
            this.Controls.Add(this.btnPvdMdcInsert);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPvdMedicineUpdate);
            this.Controls.Add(this.PvdMdcSearchtxt);
            this.Controls.Add(this.PvdMdcPricetxt);
            this.Controls.Add(this.ProviderMedicineQuantitytxt);
            this.Controls.Add(this.ProviderMedicineNametxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PvdMdcDataGrid);
            this.Name = "Provider_Medicine";
            this.Text = "Provider Medicines";
            this.Load += new System.EventHandler(this.Provider_Medicine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PvdMdcDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PvdMdcDataGrid;
        private System.Windows.Forms.Button btnPvdMedicineUpdate;
        private System.Windows.Forms.TextBox ProviderMedicineQuantitytxt;
        private System.Windows.Forms.TextBox ProviderMedicineNametxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPvdMedicineDelete;
        private System.Windows.Forms.TextBox PvdIDMedicinetxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PvdMdcPricetxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPvdMdcInsert;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox PvdMdcSearchtxt;
        private System.Windows.Forms.Button btnPvdMdcSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}