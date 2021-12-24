
namespace MedicalService.UserForms
{
    partial class UserSearch
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
            this.UserSearchDataGrid = new System.Windows.Forms.DataGridView();
            this.btnUserSrch = new System.Windows.Forms.Button();
            this.UserHomeSrchtxt = new System.Windows.Forms.TextBox();
            this.UserSearchPriceTag = new System.Windows.Forms.Label();
            this.UserMedicinePriceLbl = new System.Windows.Forms.Label();
            this.UserSearchMobileTxt = new System.Windows.Forms.TextBox();
            this.UserMedicineMobileLbl = new System.Windows.Forms.Label();
            this.UserSearchAddressTxt = new System.Windows.Forms.TextBox();
            this.UserMedicineAddressLbl = new System.Windows.Forms.Label();
            this.UserSearchQuantityTxt = new System.Windows.Forms.TextBox();
            this.UserMedicineQuantityLbl = new System.Windows.Forms.Label();
            this.UserSearchPvdIDTxt = new System.Windows.Forms.TextBox();
            this.UserMedicinePvrIDLbl = new System.Windows.Forms.Label();
            this.UserSearchUserIdTxt = new System.Windows.Forms.TextBox();
            this.UserMedicineUserIDLbl = new System.Windows.Forms.Label();
            this.btnUsrReqSearch = new System.Windows.Forms.Button();
            this.UserSearchNameTxt = new System.Windows.Forms.TextBox();
            this.UserMedicineNameLbl = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.UserSearchDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // UserSearchDataGrid
            // 
            this.UserSearchDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UserSearchDataGrid.BackgroundColor = System.Drawing.Color.LightGray;
            this.UserSearchDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserSearchDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.UserSearchDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UserSearchDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.UserSearchDataGrid.ColumnHeadersHeight = 35;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UserSearchDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.UserSearchDataGrid.EnableHeadersVisualStyles = false;
            this.UserSearchDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UserSearchDataGrid.Location = new System.Drawing.Point(37, 59);
            this.UserSearchDataGrid.Name = "UserSearchDataGrid";
            this.UserSearchDataGrid.RowHeadersVisible = false;
            this.UserSearchDataGrid.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.UserSearchDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.UserSearchDataGrid.RowTemplate.Height = 29;
            this.UserSearchDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UserSearchDataGrid.Size = new System.Drawing.Size(694, 207);
            this.UserSearchDataGrid.TabIndex = 0;
            this.UserSearchDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserSearchDataCell_Click);
            // 
            // btnUserSrch
            // 
            this.btnUserSrch.BackColor = System.Drawing.Color.LightCoral;
            this.btnUserSrch.FlatAppearance.BorderSize = 0;
            this.btnUserSrch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserSrch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUserSrch.ForeColor = System.Drawing.Color.White;
            this.btnUserSrch.Location = new System.Drawing.Point(654, 22);
            this.btnUserSrch.Name = "btnUserSrch";
            this.btnUserSrch.Size = new System.Drawing.Size(75, 29);
            this.btnUserSrch.TabIndex = 48;
            this.btnUserSrch.Text = "Search";
            this.btnUserSrch.UseVisualStyleBackColor = false;
            this.btnUserSrch.Click += new System.EventHandler(this.UserSrch_Click);
            // 
            // UserHomeSrchtxt
            // 
            this.UserHomeSrchtxt.BackColor = System.Drawing.Color.LightCoral;
            this.UserHomeSrchtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserHomeSrchtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserHomeSrchtxt.ForeColor = System.Drawing.Color.White;
            this.UserHomeSrchtxt.Location = new System.Drawing.Point(355, 22);
            this.UserHomeSrchtxt.Multiline = true;
            this.UserHomeSrchtxt.Name = "UserHomeSrchtxt";
            this.UserHomeSrchtxt.Size = new System.Drawing.Size(292, 31);
            this.UserHomeSrchtxt.TabIndex = 47;
            this.UserHomeSrchtxt.Text = "Search in your services";
            this.UserHomeSrchtxt.Click += new System.EventHandler(this.UserSrchtxt_Click);
            // 
            // UserSearchPriceTag
            // 
            this.UserSearchPriceTag.AutoSize = true;
            this.UserSearchPriceTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserSearchPriceTag.ForeColor = System.Drawing.Color.White;
            this.UserSearchPriceTag.Location = new System.Drawing.Point(217, 382);
            this.UserSearchPriceTag.Name = "UserSearchPriceTag";
            this.UserSearchPriceTag.Size = new System.Drawing.Size(0, 18);
            this.UserSearchPriceTag.TabIndex = 74;
            // 
            // UserMedicinePriceLbl
            // 
            this.UserMedicinePriceLbl.AutoSize = true;
            this.UserMedicinePriceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserMedicinePriceLbl.ForeColor = System.Drawing.Color.White;
            this.UserMedicinePriceLbl.Location = new System.Drawing.Point(39, 377);
            this.UserMedicinePriceLbl.Name = "UserMedicinePriceLbl";
            this.UserMedicinePriceLbl.Size = new System.Drawing.Size(61, 25);
            this.UserMedicinePriceLbl.TabIndex = 73;
            this.UserMedicinePriceLbl.Text = "Price";
            // 
            // UserSearchMobileTxt
            // 
            this.UserSearchMobileTxt.BackColor = System.Drawing.Color.Crimson;
            this.UserSearchMobileTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserSearchMobileTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserSearchMobileTxt.ForeColor = System.Drawing.Color.White;
            this.UserSearchMobileTxt.Location = new System.Drawing.Point(515, 341);
            this.UserSearchMobileTxt.Name = "UserSearchMobileTxt";
            this.UserSearchMobileTxt.Size = new System.Drawing.Size(163, 17);
            this.UserSearchMobileTxt.TabIndex = 72;
            // 
            // UserMedicineMobileLbl
            // 
            this.UserMedicineMobileLbl.AutoSize = true;
            this.UserMedicineMobileLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserMedicineMobileLbl.ForeColor = System.Drawing.Color.White;
            this.UserMedicineMobileLbl.Location = new System.Drawing.Point(419, 340);
            this.UserMedicineMobileLbl.Name = "UserMedicineMobileLbl";
            this.UserMedicineMobileLbl.Size = new System.Drawing.Size(76, 25);
            this.UserMedicineMobileLbl.TabIndex = 71;
            this.UserMedicineMobileLbl.Text = "Mobile";
            // 
            // UserSearchAddressTxt
            // 
            this.UserSearchAddressTxt.BackColor = System.Drawing.Color.Crimson;
            this.UserSearchAddressTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserSearchAddressTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserSearchAddressTxt.ForeColor = System.Drawing.Color.White;
            this.UserSearchAddressTxt.Location = new System.Drawing.Point(207, 339);
            this.UserSearchAddressTxt.Name = "UserSearchAddressTxt";
            this.UserSearchAddressTxt.Size = new System.Drawing.Size(163, 17);
            this.UserSearchAddressTxt.TabIndex = 70;
            // 
            // UserMedicineAddressLbl
            // 
            this.UserMedicineAddressLbl.AutoSize = true;
            this.UserMedicineAddressLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserMedicineAddressLbl.ForeColor = System.Drawing.Color.White;
            this.UserMedicineAddressLbl.Location = new System.Drawing.Point(39, 340);
            this.UserMedicineAddressLbl.Name = "UserMedicineAddressLbl";
            this.UserMedicineAddressLbl.Size = new System.Drawing.Size(92, 25);
            this.UserMedicineAddressLbl.TabIndex = 69;
            this.UserMedicineAddressLbl.Text = "Address";
            // 
            // UserSearchQuantityTxt
            // 
            this.UserSearchQuantityTxt.BackColor = System.Drawing.Color.Crimson;
            this.UserSearchQuantityTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserSearchQuantityTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserSearchQuantityTxt.ForeColor = System.Drawing.Color.White;
            this.UserSearchQuantityTxt.Location = new System.Drawing.Point(515, 306);
            this.UserSearchQuantityTxt.Name = "UserSearchQuantityTxt";
            this.UserSearchQuantityTxt.Size = new System.Drawing.Size(163, 17);
            this.UserSearchQuantityTxt.TabIndex = 68;
            // 
            // UserMedicineQuantityLbl
            // 
            this.UserMedicineQuantityLbl.AutoSize = true;
            this.UserMedicineQuantityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserMedicineQuantityLbl.ForeColor = System.Drawing.Color.White;
            this.UserMedicineQuantityLbl.Location = new System.Drawing.Point(402, 305);
            this.UserMedicineQuantityLbl.Name = "UserMedicineQuantityLbl";
            this.UserMedicineQuantityLbl.Size = new System.Drawing.Size(93, 25);
            this.UserMedicineQuantityLbl.TabIndex = 67;
            this.UserMedicineQuantityLbl.Text = "Quantity";
            // 
            // UserSearchPvdIDTxt
            // 
            this.UserSearchPvdIDTxt.BackColor = System.Drawing.Color.Crimson;
            this.UserSearchPvdIDTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserSearchPvdIDTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserSearchPvdIDTxt.ForeColor = System.Drawing.Color.White;
            this.UserSearchPvdIDTxt.Location = new System.Drawing.Point(513, 277);
            this.UserSearchPvdIDTxt.Name = "UserSearchPvdIDTxt";
            this.UserSearchPvdIDTxt.Size = new System.Drawing.Size(163, 17);
            this.UserSearchPvdIDTxt.TabIndex = 66;
            // 
            // UserMedicinePvrIDLbl
            // 
            this.UserMedicinePvrIDLbl.AutoSize = true;
            this.UserMedicinePvrIDLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserMedicinePvrIDLbl.ForeColor = System.Drawing.Color.White;
            this.UserMedicinePvrIDLbl.Location = new System.Drawing.Point(376, 272);
            this.UserMedicinePvrIDLbl.Name = "UserMedicinePvrIDLbl";
            this.UserMedicinePvrIDLbl.Size = new System.Drawing.Size(119, 25);
            this.UserMedicinePvrIDLbl.TabIndex = 65;
            this.UserMedicinePvrIDLbl.Text = "Provider ID";
            // 
            // UserSearchUserIdTxt
            // 
            this.UserSearchUserIdTxt.BackColor = System.Drawing.Color.Crimson;
            this.UserSearchUserIdTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserSearchUserIdTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserSearchUserIdTxt.ForeColor = System.Drawing.Color.White;
            this.UserSearchUserIdTxt.Location = new System.Drawing.Point(207, 270);
            this.UserSearchUserIdTxt.Name = "UserSearchUserIdTxt";
            this.UserSearchUserIdTxt.Size = new System.Drawing.Size(163, 17);
            this.UserSearchUserIdTxt.TabIndex = 64;
            // 
            // UserMedicineUserIDLbl
            // 
            this.UserMedicineUserIDLbl.AutoSize = true;
            this.UserMedicineUserIDLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserMedicineUserIDLbl.ForeColor = System.Drawing.Color.White;
            this.UserMedicineUserIDLbl.Location = new System.Drawing.Point(39, 269);
            this.UserMedicineUserIDLbl.Name = "UserMedicineUserIDLbl";
            this.UserMedicineUserIDLbl.Size = new System.Drawing.Size(84, 25);
            this.UserMedicineUserIDLbl.TabIndex = 63;
            this.UserMedicineUserIDLbl.Text = "User ID";
            // 
            // btnUsrReqSearch
            // 
            this.btnUsrReqSearch.BackColor = System.Drawing.Color.LightCoral;
            this.btnUsrReqSearch.FlatAppearance.BorderSize = 0;
            this.btnUsrReqSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsrReqSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUsrReqSearch.ForeColor = System.Drawing.Color.White;
            this.btnUsrReqSearch.Location = new System.Drawing.Point(338, 398);
            this.btnUsrReqSearch.Name = "btnUsrReqSearch";
            this.btnUsrReqSearch.Size = new System.Drawing.Size(157, 40);
            this.btnUsrReqSearch.TabIndex = 62;
            this.btnUsrReqSearch.Text = "Request";
            this.btnUsrReqSearch.UseVisualStyleBackColor = false;
            this.btnUsrReqSearch.Click += new System.EventHandler(this.UserSearchReq_Click);
            // 
            // UserSearchNameTxt
            // 
            this.UserSearchNameTxt.BackColor = System.Drawing.Color.Crimson;
            this.UserSearchNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserSearchNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserSearchNameTxt.ForeColor = System.Drawing.Color.White;
            this.UserSearchNameTxt.Location = new System.Drawing.Point(207, 303);
            this.UserSearchNameTxt.Name = "UserSearchNameTxt";
            this.UserSearchNameTxt.Size = new System.Drawing.Size(163, 17);
            this.UserSearchNameTxt.TabIndex = 61;
            // 
            // UserMedicineNameLbl
            // 
            this.UserMedicineNameLbl.AutoSize = true;
            this.UserMedicineNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserMedicineNameLbl.ForeColor = System.Drawing.Color.White;
            this.UserMedicineNameLbl.Location = new System.Drawing.Point(39, 304);
            this.UserMedicineNameLbl.Name = "UserMedicineNameLbl";
            this.UserMedicineNameLbl.Size = new System.Drawing.Size(147, 25);
            this.UserMedicineNameLbl.TabIndex = 60;
            this.UserMedicineNameLbl.Text = "Service Name";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(515, 367);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(165, 5);
            this.panel4.TabIndex = 75;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(513, 332);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 5);
            this.panel1.TabIndex = 65;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(513, 296);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(165, 5);
            this.panel2.TabIndex = 65;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(207, 296);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(165, 5);
            this.panel3.TabIndex = 65;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(207, 329);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(165, 5);
            this.panel5.TabIndex = 65;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(207, 365);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(165, 5);
            this.panel6.TabIndex = 65;
            // 
            // UserSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.UserSearchPriceTag);
            this.Controls.Add(this.UserMedicinePriceLbl);
            this.Controls.Add(this.UserSearchMobileTxt);
            this.Controls.Add(this.UserMedicineMobileLbl);
            this.Controls.Add(this.UserSearchAddressTxt);
            this.Controls.Add(this.UserMedicineAddressLbl);
            this.Controls.Add(this.UserSearchQuantityTxt);
            this.Controls.Add(this.UserMedicineQuantityLbl);
            this.Controls.Add(this.UserSearchPvdIDTxt);
            this.Controls.Add(this.UserMedicinePvrIDLbl);
            this.Controls.Add(this.UserSearchUserIdTxt);
            this.Controls.Add(this.UserMedicineUserIDLbl);
            this.Controls.Add(this.btnUsrReqSearch);
            this.Controls.Add(this.UserSearchNameTxt);
            this.Controls.Add(this.UserMedicineNameLbl);
            this.Controls.Add(this.btnUserSrch);
            this.Controls.Add(this.UserHomeSrchtxt);
            this.Controls.Add(this.UserSearchDataGrid);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "UserSearch";
            this.Text = "UserSearch";
            this.Load += new System.EventHandler(this.UserSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserSearchDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView UserSearchDataGrid;
        private System.Windows.Forms.Button btnUserSrch;
        private System.Windows.Forms.TextBox UserHomeSrchtxt;
        private System.Windows.Forms.Label UserSearchPriceTag;
        private System.Windows.Forms.Label UserMedicinePriceLbl;
        private System.Windows.Forms.TextBox UserSearchMobileTxt;
        private System.Windows.Forms.Label UserMedicineMobileLbl;
        private System.Windows.Forms.TextBox UserSearchAddressTxt;
        private System.Windows.Forms.Label UserMedicineAddressLbl;
        private System.Windows.Forms.TextBox UserSearchQuantityTxt;
        private System.Windows.Forms.Label UserMedicineQuantityLbl;
        private System.Windows.Forms.TextBox UserSearchPvdIDTxt;
        private System.Windows.Forms.Label UserMedicinePvrIDLbl;
        private System.Windows.Forms.TextBox UserSearchUserIdTxt;
        private System.Windows.Forms.Label UserMedicineUserIDLbl;
        private System.Windows.Forms.Button btnUsrReqSearch;
        private System.Windows.Forms.TextBox UserSearchNameTxt;
        private System.Windows.Forms.Label UserMedicineNameLbl;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
    }
}