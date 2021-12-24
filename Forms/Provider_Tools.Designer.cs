
namespace MedicalService.Forms
{
    partial class Provider_Tools
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
            this.btnPvdToolsDelete = new System.Windows.Forms.Button();
            this.btnPvdToolsUpdate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PvdToolsDataGrid = new System.Windows.Forms.DataGridView();
            this.ProviderToolsQuantitytxt = new System.Windows.Forms.TextBox();
            this.ProviderToolsNametxt = new System.Windows.Forms.TextBox();
            this.PvdIDToolstxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PvdToolPricetxt = new System.Windows.Forms.TextBox();
            this.btnPvdToolInsert = new System.Windows.Forms.Button();
            this.btnPvdToolsCheck = new System.Windows.Forms.Button();
            this.btnToolsSearch = new System.Windows.Forms.Button();
            this.PvdToolsSearchtxt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.PvdToolsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPvdToolsDelete
            // 
            this.btnPvdToolsDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPvdToolsDelete.FlatAppearance.BorderSize = 0;
            this.btnPvdToolsDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPvdToolsDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPvdToolsDelete.ForeColor = System.Drawing.Color.White;
            this.btnPvdToolsDelete.Location = new System.Drawing.Point(325, 398);
            this.btnPvdToolsDelete.Name = "btnPvdToolsDelete";
            this.btnPvdToolsDelete.Size = new System.Drawing.Size(100, 40);
            this.btnPvdToolsDelete.TabIndex = 15;
            this.btnPvdToolsDelete.Text = "Delete";
            this.btnPvdToolsDelete.UseVisualStyleBackColor = false;
            this.btnPvdToolsDelete.Click += new System.EventHandler(this.PvdToolsDelete_Click);
            // 
            // btnPvdToolsUpdate
            // 
            this.btnPvdToolsUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPvdToolsUpdate.FlatAppearance.BorderSize = 0;
            this.btnPvdToolsUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPvdToolsUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPvdToolsUpdate.ForeColor = System.Drawing.Color.White;
            this.btnPvdToolsUpdate.Location = new System.Drawing.Point(206, 398);
            this.btnPvdToolsUpdate.Name = "btnPvdToolsUpdate";
            this.btnPvdToolsUpdate.Size = new System.Drawing.Size(113, 40);
            this.btnPvdToolsUpdate.TabIndex = 14;
            this.btnPvdToolsUpdate.Text = "Update";
            this.btnPvdToolsUpdate.UseVisualStyleBackColor = false;
            this.btnPvdToolsUpdate.Click += new System.EventHandler(this.PvdToolsUpdate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(72, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Available Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(72, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tool Name";
            // 
            // PvdToolsDataGrid
            // 
            this.PvdToolsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PvdToolsDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.PvdToolsDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PvdToolsDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.PvdToolsDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PvdToolsDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.PvdToolsDataGrid.ColumnHeadersHeight = 35;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PvdToolsDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.PvdToolsDataGrid.EnableHeadersVisualStyles = false;
            this.PvdToolsDataGrid.GridColor = System.Drawing.Color.LightGray;
            this.PvdToolsDataGrid.Location = new System.Drawing.Point(72, 65);
            this.PvdToolsDataGrid.Name = "PvdToolsDataGrid";
            this.PvdToolsDataGrid.RowHeadersVisible = false;
            this.PvdToolsDataGrid.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.PvdToolsDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.PvdToolsDataGrid.RowTemplate.Height = 29;
            this.PvdToolsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PvdToolsDataGrid.Size = new System.Drawing.Size(639, 246);
            this.PvdToolsDataGrid.TabIndex = 9;
            this.PvdToolsDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PvdToolsDataCell_Click);
            // 
            // ProviderToolsQuantitytxt
            // 
            this.ProviderToolsQuantitytxt.BackColor = System.Drawing.Color.DodgerBlue;
            this.ProviderToolsQuantitytxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProviderToolsQuantitytxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProviderToolsQuantitytxt.ForeColor = System.Drawing.Color.White;
            this.ProviderToolsQuantitytxt.Location = new System.Drawing.Point(260, 355);
            this.ProviderToolsQuantitytxt.Name = "ProviderToolsQuantitytxt";
            this.ProviderToolsQuantitytxt.Size = new System.Drawing.Size(163, 17);
            this.ProviderToolsQuantitytxt.TabIndex = 16;
            // 
            // ProviderToolsNametxt
            // 
            this.ProviderToolsNametxt.BackColor = System.Drawing.Color.DodgerBlue;
            this.ProviderToolsNametxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProviderToolsNametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProviderToolsNametxt.ForeColor = System.Drawing.Color.White;
            this.ProviderToolsNametxt.Location = new System.Drawing.Point(260, 317);
            this.ProviderToolsNametxt.Name = "ProviderToolsNametxt";
            this.ProviderToolsNametxt.Size = new System.Drawing.Size(163, 17);
            this.ProviderToolsNametxt.TabIndex = 17;
            // 
            // PvdIDToolstxt
            // 
            this.PvdIDToolstxt.BackColor = System.Drawing.Color.DodgerBlue;
            this.PvdIDToolstxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PvdIDToolstxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PvdIDToolstxt.ForeColor = System.Drawing.Color.White;
            this.PvdIDToolstxt.Location = new System.Drawing.Point(453, 32);
            this.PvdIDToolstxt.Name = "PvdIDToolstxt";
            this.PvdIDToolstxt.Size = new System.Drawing.Size(163, 17);
            this.PvdIDToolstxt.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(350, 34);
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
            this.label4.Location = new System.Drawing.Point(72, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 25);
            this.label4.TabIndex = 27;
            this.label4.Text = "Available Tools";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(487, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Price";
            // 
            // PvdToolPricetxt
            // 
            this.PvdToolPricetxt.BackColor = System.Drawing.Color.DodgerBlue;
            this.PvdToolPricetxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PvdToolPricetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PvdToolPricetxt.ForeColor = System.Drawing.Color.White;
            this.PvdToolPricetxt.Location = new System.Drawing.Point(546, 317);
            this.PvdToolPricetxt.Name = "PvdToolPricetxt";
            this.PvdToolPricetxt.Size = new System.Drawing.Size(165, 17);
            this.PvdToolPricetxt.TabIndex = 16;
            // 
            // btnPvdToolInsert
            // 
            this.btnPvdToolInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPvdToolInsert.FlatAppearance.BorderSize = 0;
            this.btnPvdToolInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPvdToolInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPvdToolInsert.ForeColor = System.Drawing.Color.White;
            this.btnPvdToolInsert.Location = new System.Drawing.Point(87, 398);
            this.btnPvdToolInsert.Name = "btnPvdToolInsert";
            this.btnPvdToolInsert.Size = new System.Drawing.Size(113, 40);
            this.btnPvdToolInsert.TabIndex = 14;
            this.btnPvdToolInsert.Text = "Add";
            this.btnPvdToolInsert.UseVisualStyleBackColor = false;
            this.btnPvdToolInsert.Click += new System.EventHandler(this.PvdToolsInsert_Click);
            // 
            // btnPvdToolsCheck
            // 
            this.btnPvdToolsCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPvdToolsCheck.FlatAppearance.BorderSize = 0;
            this.btnPvdToolsCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPvdToolsCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPvdToolsCheck.ForeColor = System.Drawing.Color.White;
            this.btnPvdToolsCheck.Location = new System.Drawing.Point(622, 30);
            this.btnPvdToolsCheck.Name = "btnPvdToolsCheck";
            this.btnPvdToolsCheck.Size = new System.Drawing.Size(89, 33);
            this.btnPvdToolsCheck.TabIndex = 15;
            this.btnPvdToolsCheck.Text = "Check";
            this.btnPvdToolsCheck.UseVisualStyleBackColor = false;
            this.btnPvdToolsCheck.Click += new System.EventHandler(this.PvdToolsCheck_Click);
            // 
            // btnToolsSearch
            // 
            this.btnToolsSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnToolsSearch.FlatAppearance.BorderSize = 0;
            this.btnToolsSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToolsSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnToolsSearch.ForeColor = System.Drawing.Color.White;
            this.btnToolsSearch.Location = new System.Drawing.Point(431, 398);
            this.btnToolsSearch.Name = "btnToolsSearch";
            this.btnToolsSearch.Size = new System.Drawing.Size(89, 40);
            this.btnToolsSearch.TabIndex = 15;
            this.btnToolsSearch.Text = "Search";
            this.btnToolsSearch.UseVisualStyleBackColor = false;
            this.btnToolsSearch.Click += new System.EventHandler(this.PvdToolsSearch_Click);
            // 
            // PvdToolsSearchtxt
            // 
            this.PvdToolsSearchtxt.BackColor = System.Drawing.Color.DodgerBlue;
            this.PvdToolsSearchtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PvdToolsSearchtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PvdToolsSearchtxt.ForeColor = System.Drawing.Color.White;
            this.PvdToolsSearchtxt.Location = new System.Drawing.Point(526, 407);
            this.PvdToolsSearchtxt.Name = "PvdToolsSearchtxt";
            this.PvdToolsSearchtxt.Size = new System.Drawing.Size(165, 17);
            this.PvdToolsSearchtxt.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(260, 343);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 5);
            this.panel1.TabIndex = 63;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(260, 381);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(165, 5);
            this.panel2.TabIndex = 63;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(526, 433);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(165, 5);
            this.panel3.TabIndex = 63;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(546, 343);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(165, 5);
            this.panel4.TabIndex = 63;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(451, 58);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(165, 5);
            this.panel5.TabIndex = 63;
            // 
            // Provider_Tools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PvdToolsSearchtxt);
            this.Controls.Add(this.PvdIDToolstxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PvdToolPricetxt);
            this.Controls.Add(this.ProviderToolsQuantitytxt);
            this.Controls.Add(this.btnToolsSearch);
            this.Controls.Add(this.ProviderToolsNametxt);
            this.Controls.Add(this.btnPvdToolsCheck);
            this.Controls.Add(this.btnPvdToolsDelete);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnPvdToolInsert);
            this.Controls.Add(this.btnPvdToolsUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PvdToolsDataGrid);
            this.Name = "Provider_Tools";
            this.Text = "Provider_Tools";
            this.Load += new System.EventHandler(this.Provider_Tools_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PvdToolsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPvdToolsDelete;
        private System.Windows.Forms.Button btnPvdToolsUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView PvdToolsDataGrid;
        private System.Windows.Forms.TextBox ProviderToolsQuantitytxt;
        private System.Windows.Forms.TextBox ProviderToolsNametxt;
        private System.Windows.Forms.TextBox PvdIDToolstxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PvdToolPricetxt;
        private System.Windows.Forms.Button btnPvdToolInsert;
        private System.Windows.Forms.Button btnPvdToolsCheck;
        private System.Windows.Forms.Button btnToolsSearch;
        private System.Windows.Forms.TextBox PvdToolsSearchtxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}