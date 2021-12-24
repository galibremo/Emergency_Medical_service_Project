
namespace MedicalService.Forms
{
    partial class Mediator_Details
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
            this.MediatorDataGrid = new System.Windows.Forms.DataGridView();
            this.MedAddresstxt = new System.Windows.Forms.TextBox();
            this.UserToolsQuantityLbl = new System.Windows.Forms.Label();
            this.MedEmailtxt = new System.Windows.Forms.TextBox();
            this.UsrToolsPvrIDLbl = new System.Windows.Forms.Label();
            this.MedNametxt = new System.Windows.Forms.TextBox();
            this.UsrIDToolsLbl = new System.Windows.Forms.Label();
            this.MedMbltxt = new System.Windows.Forms.TextBox();
            this.UserToolsNameLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MedIDtxt = new System.Windows.Forms.TextBox();
            this.btnMedInsert = new System.Windows.Forms.Button();
            this.btnMedUpdate = new System.Windows.Forms.Button();
            this.btnMedDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.MedProviderId = new System.Windows.Forms.TextBox();
            this.btnCheckALLMed = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.MediatorDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // MediatorDataGrid
            // 
            this.MediatorDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.MediatorDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MediatorDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.MediatorDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MediatorDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.MediatorDataGrid.ColumnHeadersHeight = 35;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MediatorDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.MediatorDataGrid.EnableHeadersVisualStyles = false;
            this.MediatorDataGrid.GridColor = System.Drawing.Color.LightGray;
            this.MediatorDataGrid.Location = new System.Drawing.Point(388, 71);
            this.MediatorDataGrid.Name = "MediatorDataGrid";
            this.MediatorDataGrid.RowHeadersVisible = false;
            this.MediatorDataGrid.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.MediatorDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.MediatorDataGrid.RowTemplate.Height = 29;
            this.MediatorDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MediatorDataGrid.Size = new System.Drawing.Size(315, 345);
            this.MediatorDataGrid.TabIndex = 0;
            this.MediatorDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MediatorDataGrid_CellClick);
            this.MediatorDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MediatorDataGrid_CellContentClick);
            // 
            // MedAddresstxt
            // 
            this.MedAddresstxt.BackColor = System.Drawing.Color.DodgerBlue;
            this.MedAddresstxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MedAddresstxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MedAddresstxt.ForeColor = System.Drawing.Color.White;
            this.MedAddresstxt.Location = new System.Drawing.Point(189, 205);
            this.MedAddresstxt.Name = "MedAddresstxt";
            this.MedAddresstxt.Size = new System.Drawing.Size(163, 17);
            this.MedAddresstxt.TabIndex = 60;
            // 
            // UserToolsQuantityLbl
            // 
            this.UserToolsQuantityLbl.AutoSize = true;
            this.UserToolsQuantityLbl.BackColor = System.Drawing.Color.Transparent;
            this.UserToolsQuantityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserToolsQuantityLbl.ForeColor = System.Drawing.Color.White;
            this.UserToolsQuantityLbl.Location = new System.Drawing.Point(25, 204);
            this.UserToolsQuantityLbl.Name = "UserToolsQuantityLbl";
            this.UserToolsQuantityLbl.Size = new System.Drawing.Size(92, 25);
            this.UserToolsQuantityLbl.TabIndex = 59;
            this.UserToolsQuantityLbl.Text = "Address";
            // 
            // MedEmailtxt
            // 
            this.MedEmailtxt.BackColor = System.Drawing.Color.DodgerBlue;
            this.MedEmailtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MedEmailtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MedEmailtxt.ForeColor = System.Drawing.Color.White;
            this.MedEmailtxt.Location = new System.Drawing.Point(189, 162);
            this.MedEmailtxt.Name = "MedEmailtxt";
            this.MedEmailtxt.Size = new System.Drawing.Size(163, 17);
            this.MedEmailtxt.TabIndex = 58;
            // 
            // UsrToolsPvrIDLbl
            // 
            this.UsrToolsPvrIDLbl.AutoSize = true;
            this.UsrToolsPvrIDLbl.BackColor = System.Drawing.Color.Transparent;
            this.UsrToolsPvrIDLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UsrToolsPvrIDLbl.ForeColor = System.Drawing.Color.White;
            this.UsrToolsPvrIDLbl.Location = new System.Drawing.Point(25, 164);
            this.UsrToolsPvrIDLbl.Name = "UsrToolsPvrIDLbl";
            this.UsrToolsPvrIDLbl.Size = new System.Drawing.Size(65, 25);
            this.UsrToolsPvrIDLbl.TabIndex = 57;
            this.UsrToolsPvrIDLbl.Text = "Email";
            // 
            // MedNametxt
            // 
            this.MedNametxt.BackColor = System.Drawing.Color.DodgerBlue;
            this.MedNametxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MedNametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MedNametxt.ForeColor = System.Drawing.Color.White;
            this.MedNametxt.Location = new System.Drawing.Point(189, 71);
            this.MedNametxt.Name = "MedNametxt";
            this.MedNametxt.Size = new System.Drawing.Size(163, 17);
            this.MedNametxt.TabIndex = 56;
            // 
            // UsrIDToolsLbl
            // 
            this.UsrIDToolsLbl.AutoSize = true;
            this.UsrIDToolsLbl.BackColor = System.Drawing.Color.Transparent;
            this.UsrIDToolsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UsrIDToolsLbl.ForeColor = System.Drawing.Color.White;
            this.UsrIDToolsLbl.Location = new System.Drawing.Point(25, 71);
            this.UsrIDToolsLbl.Name = "UsrIDToolsLbl";
            this.UsrIDToolsLbl.Size = new System.Drawing.Size(158, 25);
            this.UsrIDToolsLbl.TabIndex = 55;
            this.UsrIDToolsLbl.Text = "Mediator Name";
            // 
            // MedMbltxt
            // 
            this.MedMbltxt.BackColor = System.Drawing.Color.DodgerBlue;
            this.MedMbltxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MedMbltxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MedMbltxt.ForeColor = System.Drawing.Color.White;
            this.MedMbltxt.Location = new System.Drawing.Point(189, 120);
            this.MedMbltxt.Name = "MedMbltxt";
            this.MedMbltxt.Size = new System.Drawing.Size(163, 17);
            this.MedMbltxt.TabIndex = 54;
            // 
            // UserToolsNameLbl
            // 
            this.UserToolsNameLbl.AutoSize = true;
            this.UserToolsNameLbl.BackColor = System.Drawing.Color.Transparent;
            this.UserToolsNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserToolsNameLbl.ForeColor = System.Drawing.Color.White;
            this.UserToolsNameLbl.Location = new System.Drawing.Point(25, 119);
            this.UserToolsNameLbl.Name = "UserToolsNameLbl";
            this.UserToolsNameLbl.Size = new System.Drawing.Size(76, 25);
            this.UserToolsNameLbl.TabIndex = 53;
            this.UserToolsNameLbl.Text = "Mobile";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 25);
            this.label1.TabIndex = 59;
            this.label1.Text = "ID";
            // 
            // MedIDtxt
            // 
            this.MedIDtxt.BackColor = System.Drawing.Color.DodgerBlue;
            this.MedIDtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MedIDtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MedIDtxt.ForeColor = System.Drawing.Color.White;
            this.MedIDtxt.Location = new System.Drawing.Point(189, 250);
            this.MedIDtxt.Name = "MedIDtxt";
            this.MedIDtxt.Size = new System.Drawing.Size(163, 17);
            this.MedIDtxt.TabIndex = 60;
            // 
            // btnMedInsert
            // 
            this.btnMedInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMedInsert.FlatAppearance.BorderSize = 0;
            this.btnMedInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMedInsert.ForeColor = System.Drawing.Color.White;
            this.btnMedInsert.Location = new System.Drawing.Point(25, 304);
            this.btnMedInsert.Name = "btnMedInsert";
            this.btnMedInsert.Size = new System.Drawing.Size(157, 40);
            this.btnMedInsert.TabIndex = 61;
            this.btnMedInsert.Text = "Add Mediator";
            this.btnMedInsert.UseVisualStyleBackColor = false;
            this.btnMedInsert.Click += new System.EventHandler(this.MedInsert_Click);
            // 
            // btnMedUpdate
            // 
            this.btnMedUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMedUpdate.FlatAppearance.BorderSize = 0;
            this.btnMedUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMedUpdate.ForeColor = System.Drawing.Color.White;
            this.btnMedUpdate.Location = new System.Drawing.Point(189, 304);
            this.btnMedUpdate.Name = "btnMedUpdate";
            this.btnMedUpdate.Size = new System.Drawing.Size(165, 40);
            this.btnMedUpdate.TabIndex = 61;
            this.btnMedUpdate.Text = "Update Details";
            this.btnMedUpdate.UseVisualStyleBackColor = false;
            this.btnMedUpdate.Click += new System.EventHandler(this.MedUpdate_Click);
            // 
            // btnMedDelete
            // 
            this.btnMedDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMedDelete.FlatAppearance.BorderSize = 0;
            this.btnMedDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMedDelete.ForeColor = System.Drawing.Color.White;
            this.btnMedDelete.Location = new System.Drawing.Point(109, 360);
            this.btnMedDelete.Name = "btnMedDelete";
            this.btnMedDelete.Size = new System.Drawing.Size(157, 40);
            this.btnMedDelete.TabIndex = 61;
            this.btnMedDelete.Text = "Delete";
            this.btnMedDelete.UseVisualStyleBackColor = false;
            this.btnMedDelete.Click += new System.EventHandler(this.MedDelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 55;
            this.label2.Text = "Your ID";
            // 
            // MedProviderId
            // 
            this.MedProviderId.BackColor = System.Drawing.Color.DodgerBlue;
            this.MedProviderId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MedProviderId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MedProviderId.ForeColor = System.Drawing.Color.White;
            this.MedProviderId.Location = new System.Drawing.Point(189, 29);
            this.MedProviderId.Name = "MedProviderId";
            this.MedProviderId.Size = new System.Drawing.Size(163, 17);
            this.MedProviderId.TabIndex = 56;
            // 
            // btnCheckALLMed
            // 
            this.btnCheckALLMed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCheckALLMed.FlatAppearance.BorderSize = 0;
            this.btnCheckALLMed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckALLMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCheckALLMed.ForeColor = System.Drawing.Color.White;
            this.btnCheckALLMed.Location = new System.Drawing.Point(388, 28);
            this.btnCheckALLMed.Name = "btnCheckALLMed";
            this.btnCheckALLMed.Size = new System.Drawing.Size(220, 32);
            this.btnCheckALLMed.TabIndex = 61;
            this.btnCheckALLMed.Text = "Check all mediators";
            this.btnCheckALLMed.UseVisualStyleBackColor = false;
            this.btnCheckALLMed.Click += new System.EventHandler(this.CheckAllMed_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(187, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 5);
            this.panel1.TabIndex = 62;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(189, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(165, 5);
            this.panel2.TabIndex = 63;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(189, 146);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(165, 5);
            this.panel3.TabIndex = 64;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(189, 188);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(165, 5);
            this.panel4.TabIndex = 65;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(187, 231);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(165, 5);
            this.panel5.TabIndex = 66;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(187, 276);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(165, 5);
            this.panel6.TabIndex = 67;
            // 
            // Mediator_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnMedDelete);
            this.Controls.Add(this.btnMedUpdate);
            this.Controls.Add(this.btnCheckALLMed);
            this.Controls.Add(this.btnMedInsert);
            this.Controls.Add(this.MedIDtxt);
            this.Controls.Add(this.MedAddresstxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserToolsQuantityLbl);
            this.Controls.Add(this.MedEmailtxt);
            this.Controls.Add(this.UsrToolsPvrIDLbl);
            this.Controls.Add(this.MedProviderId);
            this.Controls.Add(this.MedNametxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UsrIDToolsLbl);
            this.Controls.Add(this.MedMbltxt);
            this.Controls.Add(this.UserToolsNameLbl);
            this.Controls.Add(this.MediatorDataGrid);
            this.Name = "Mediator_Details";
            this.Text = "Mediator Details";
            this.Load += new System.EventHandler(this.Mediator_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MediatorDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MediatorDataGrid;
        private System.Windows.Forms.TextBox MedAddresstxt;
        private System.Windows.Forms.Label UserToolsQuantityLbl;
        private System.Windows.Forms.TextBox MedEmailtxt;
        private System.Windows.Forms.Label UsrToolsPvrIDLbl;
        private System.Windows.Forms.TextBox MedNametxt;
        private System.Windows.Forms.Label UsrIDToolsLbl;
        private System.Windows.Forms.TextBox MedMbltxt;
        private System.Windows.Forms.Label UserToolsNameLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MedIDtxt;
        private System.Windows.Forms.Button btnMedInsert;
        private System.Windows.Forms.Button btnMedUpdate;
        private System.Windows.Forms.Button btnMedDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MedProviderId;
        private System.Windows.Forms.Button btnCheckALLMed;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
    }
}