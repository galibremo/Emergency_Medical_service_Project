
namespace MedicalService.UserForms
{
    partial class User_Ambulance
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
            this.UserReqAmbLabel = new System.Windows.Forms.Label();
            this.UserAmbUserIdTxt = new System.Windows.Forms.TextBox();
            this.UserAmbCatagoryTxt = new System.Windows.Forms.TextBox();
            this.btnUsrAmbReq = new System.Windows.Forms.Button();
            this.UserAmbIDLbl = new System.Windows.Forms.Label();
            this.UserAmbCatagoryLbl = new System.Windows.Forms.Label();
            this.UsrAmbDataGrid = new System.Windows.Forms.DataGridView();
            this.UserAmbPvrIDTxt = new System.Windows.Forms.TextBox();
            this.UserAmbPvrIDLbl = new System.Windows.Forms.Label();
            this.UserAmbPriceTag = new System.Windows.Forms.Label();
            this.UserAmbPriceLbl = new System.Windows.Forms.Label();
            this.UserAmbMobileTxt = new System.Windows.Forms.TextBox();
            this.UserAmbMobileLbl = new System.Windows.Forms.Label();
            this.UserAmbAddressTxt = new System.Windows.Forms.TextBox();
            this.UserAmbAddressLbl = new System.Windows.Forms.Label();
            this.UserAmbQuantityTxt = new System.Windows.Forms.TextBox();
            this.UserAmbQuantityLbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.UsrAmbDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // UserReqAmbLabel
            // 
            this.UserReqAmbLabel.AutoSize = true;
            this.UserReqAmbLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserReqAmbLabel.ForeColor = System.Drawing.Color.White;
            this.UserReqAmbLabel.Location = new System.Drawing.Point(72, 17);
            this.UserReqAmbLabel.Name = "UserReqAmbLabel";
            this.UserReqAmbLabel.Size = new System.Drawing.Size(131, 25);
            this.UserReqAmbLabel.TabIndex = 37;
            this.UserReqAmbLabel.Text = "Ambulances";
            // 
            // UserAmbUserIdTxt
            // 
            this.UserAmbUserIdTxt.BackColor = System.Drawing.Color.Crimson;
            this.UserAmbUserIdTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserAmbUserIdTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserAmbUserIdTxt.ForeColor = System.Drawing.Color.White;
            this.UserAmbUserIdTxt.Location = new System.Drawing.Point(221, 279);
            this.UserAmbUserIdTxt.Name = "UserAmbUserIdTxt";
            this.UserAmbUserIdTxt.Size = new System.Drawing.Size(163, 17);
            this.UserAmbUserIdTxt.TabIndex = 35;
            this.UserAmbUserIdTxt.TextChanged += new System.EventHandler(this.PvdIDAmbtxt_TextChanged);
            // 
            // UserAmbCatagoryTxt
            // 
            this.UserAmbCatagoryTxt.BackColor = System.Drawing.Color.Crimson;
            this.UserAmbCatagoryTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserAmbCatagoryTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserAmbCatagoryTxt.ForeColor = System.Drawing.Color.White;
            this.UserAmbCatagoryTxt.Location = new System.Drawing.Point(223, 316);
            this.UserAmbCatagoryTxt.Name = "UserAmbCatagoryTxt";
            this.UserAmbCatagoryTxt.Size = new System.Drawing.Size(163, 17);
            this.UserAmbCatagoryTxt.TabIndex = 36;
            this.UserAmbCatagoryTxt.TextChanged += new System.EventHandler(this.PvdAmbCatagorytxt_TextChanged);
            // 
            // btnUsrAmbReq
            // 
            this.btnUsrAmbReq.BackColor = System.Drawing.Color.LightCoral;
            this.btnUsrAmbReq.FlatAppearance.BorderSize = 0;
            this.btnUsrAmbReq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsrAmbReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUsrAmbReq.ForeColor = System.Drawing.Color.White;
            this.btnUsrAmbReq.Location = new System.Drawing.Point(481, 411);
            this.btnUsrAmbReq.Name = "btnUsrAmbReq";
            this.btnUsrAmbReq.Size = new System.Drawing.Size(113, 40);
            this.btnUsrAmbReq.TabIndex = 32;
            this.btnUsrAmbReq.Text = "Request";
            this.btnUsrAmbReq.UseVisualStyleBackColor = false;
            this.btnUsrAmbReq.Click += new System.EventHandler(this.UsrAmbulanceReq_Click);
            // 
            // UserAmbIDLbl
            // 
            this.UserAmbIDLbl.AutoSize = true;
            this.UserAmbIDLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserAmbIDLbl.ForeColor = System.Drawing.Color.White;
            this.UserAmbIDLbl.Location = new System.Drawing.Point(88, 281);
            this.UserAmbIDLbl.Name = "UserAmbIDLbl";
            this.UserAmbIDLbl.Size = new System.Drawing.Size(84, 25);
            this.UserAmbIDLbl.TabIndex = 30;
            this.UserAmbIDLbl.Text = "User ID";
            // 
            // UserAmbCatagoryLbl
            // 
            this.UserAmbCatagoryLbl.AutoSize = true;
            this.UserAmbCatagoryLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserAmbCatagoryLbl.ForeColor = System.Drawing.Color.White;
            this.UserAmbCatagoryLbl.Location = new System.Drawing.Point(72, 320);
            this.UserAmbCatagoryLbl.Name = "UserAmbCatagoryLbl";
            this.UserAmbCatagoryLbl.Size = new System.Drawing.Size(100, 25);
            this.UserAmbCatagoryLbl.TabIndex = 31;
            this.UserAmbCatagoryLbl.Text = "Catagory";
            // 
            // UsrAmbDataGrid
            // 
            this.UsrAmbDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UsrAmbDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.UsrAmbDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsrAmbDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.UsrAmbDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UsrAmbDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.UsrAmbDataGrid.ColumnHeadersHeight = 35;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UsrAmbDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.UsrAmbDataGrid.EnableHeadersVisualStyles = false;
            this.UsrAmbDataGrid.GridColor = System.Drawing.Color.LightGray;
            this.UsrAmbDataGrid.Location = new System.Drawing.Point(72, 45);
            this.UsrAmbDataGrid.Name = "UsrAmbDataGrid";
            this.UsrAmbDataGrid.RowHeadersVisible = false;
            this.UsrAmbDataGrid.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.UsrAmbDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.UsrAmbDataGrid.RowTemplate.Height = 29;
            this.UsrAmbDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UsrAmbDataGrid.Size = new System.Drawing.Size(656, 215);
            this.UsrAmbDataGrid.TabIndex = 28;
            this.UsrAmbDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserAmbGrid_CellClick);
            // 
            // UserAmbPvrIDTxt
            // 
            this.UserAmbPvrIDTxt.BackColor = System.Drawing.Color.Crimson;
            this.UserAmbPvrIDTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserAmbPvrIDTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserAmbPvrIDTxt.ForeColor = System.Drawing.Color.White;
            this.UserAmbPvrIDTxt.Location = new System.Drawing.Point(563, 279);
            this.UserAmbPvrIDTxt.Name = "UserAmbPvrIDTxt";
            this.UserAmbPvrIDTxt.Size = new System.Drawing.Size(163, 17);
            this.UserAmbPvrIDTxt.TabIndex = 39;
            // 
            // UserAmbPvrIDLbl
            // 
            this.UserAmbPvrIDLbl.AutoSize = true;
            this.UserAmbPvrIDLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserAmbPvrIDLbl.ForeColor = System.Drawing.Color.White;
            this.UserAmbPvrIDLbl.Location = new System.Drawing.Point(424, 281);
            this.UserAmbPvrIDLbl.Name = "UserAmbPvrIDLbl";
            this.UserAmbPvrIDLbl.Size = new System.Drawing.Size(119, 25);
            this.UserAmbPvrIDLbl.TabIndex = 38;
            this.UserAmbPvrIDLbl.Text = "Provider ID";
            // 
            // UserAmbPriceTag
            // 
            this.UserAmbPriceTag.AutoSize = true;
            this.UserAmbPriceTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserAmbPriceTag.ForeColor = System.Drawing.Color.White;
            this.UserAmbPriceTag.Location = new System.Drawing.Point(277, 398);
            this.UserAmbPriceTag.Name = "UserAmbPriceTag";
            this.UserAmbPriceTag.Size = new System.Drawing.Size(0, 18);
            this.UserAmbPriceTag.TabIndex = 79;
            // 
            // UserAmbPriceLbl
            // 
            this.UserAmbPriceLbl.AutoSize = true;
            this.UserAmbPriceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserAmbPriceLbl.ForeColor = System.Drawing.Color.White;
            this.UserAmbPriceLbl.Location = new System.Drawing.Point(111, 391);
            this.UserAmbPriceLbl.Name = "UserAmbPriceLbl";
            this.UserAmbPriceLbl.Size = new System.Drawing.Size(61, 25);
            this.UserAmbPriceLbl.TabIndex = 78;
            this.UserAmbPriceLbl.Text = "Price";
            // 
            // UserAmbMobileTxt
            // 
            this.UserAmbMobileTxt.BackColor = System.Drawing.Color.Crimson;
            this.UserAmbMobileTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserAmbMobileTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserAmbMobileTxt.ForeColor = System.Drawing.Color.White;
            this.UserAmbMobileTxt.Location = new System.Drawing.Point(561, 357);
            this.UserAmbMobileTxt.Name = "UserAmbMobileTxt";
            this.UserAmbMobileTxt.Size = new System.Drawing.Size(163, 17);
            this.UserAmbMobileTxt.TabIndex = 77;
            // 
            // UserAmbMobileLbl
            // 
            this.UserAmbMobileLbl.AutoSize = true;
            this.UserAmbMobileLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserAmbMobileLbl.ForeColor = System.Drawing.Color.White;
            this.UserAmbMobileLbl.Location = new System.Drawing.Point(467, 352);
            this.UserAmbMobileLbl.Name = "UserAmbMobileLbl";
            this.UserAmbMobileLbl.Size = new System.Drawing.Size(76, 25);
            this.UserAmbMobileLbl.TabIndex = 76;
            this.UserAmbMobileLbl.Text = "Mobile";
            // 
            // UserAmbAddressTxt
            // 
            this.UserAmbAddressTxt.BackColor = System.Drawing.Color.Crimson;
            this.UserAmbAddressTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserAmbAddressTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserAmbAddressTxt.ForeColor = System.Drawing.Color.White;
            this.UserAmbAddressTxt.Location = new System.Drawing.Point(221, 353);
            this.UserAmbAddressTxt.Name = "UserAmbAddressTxt";
            this.UserAmbAddressTxt.Size = new System.Drawing.Size(163, 17);
            this.UserAmbAddressTxt.TabIndex = 75;
            // 
            // UserAmbAddressLbl
            // 
            this.UserAmbAddressLbl.AutoSize = true;
            this.UserAmbAddressLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserAmbAddressLbl.ForeColor = System.Drawing.Color.White;
            this.UserAmbAddressLbl.Location = new System.Drawing.Point(80, 355);
            this.UserAmbAddressLbl.Name = "UserAmbAddressLbl";
            this.UserAmbAddressLbl.Size = new System.Drawing.Size(92, 25);
            this.UserAmbAddressLbl.TabIndex = 74;
            this.UserAmbAddressLbl.Text = "Address";
            // 
            // UserAmbQuantityTxt
            // 
            this.UserAmbQuantityTxt.BackColor = System.Drawing.Color.Crimson;
            this.UserAmbQuantityTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserAmbQuantityTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserAmbQuantityTxt.ForeColor = System.Drawing.Color.White;
            this.UserAmbQuantityTxt.Location = new System.Drawing.Point(561, 320);
            this.UserAmbQuantityTxt.Name = "UserAmbQuantityTxt";
            this.UserAmbQuantityTxt.Size = new System.Drawing.Size(163, 17);
            this.UserAmbQuantityTxt.TabIndex = 73;
            // 
            // UserAmbQuantityLbl
            // 
            this.UserAmbQuantityLbl.AutoSize = true;
            this.UserAmbQuantityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserAmbQuantityLbl.ForeColor = System.Drawing.Color.White;
            this.UserAmbQuantityLbl.Location = new System.Drawing.Point(450, 320);
            this.UserAmbQuantityLbl.Name = "UserAmbQuantityLbl";
            this.UserAmbQuantityLbl.Size = new System.Drawing.Size(93, 25);
            this.UserAmbQuantityLbl.TabIndex = 72;
            this.UserAmbQuantityLbl.Text = "Quantity";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(561, 383);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(165, 5);
            this.panel2.TabIndex = 80;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(561, 346);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 5);
            this.panel1.TabIndex = 64;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(563, 305);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(165, 5);
            this.panel3.TabIndex = 64;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(221, 305);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(165, 5);
            this.panel4.TabIndex = 64;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(221, 344);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(165, 5);
            this.panel5.TabIndex = 64;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(221, 380);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(165, 5);
            this.panel6.TabIndex = 64;
            // 
            // User_Ambulance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(762, 488);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.UserAmbPriceTag);
            this.Controls.Add(this.UserAmbPriceLbl);
            this.Controls.Add(this.UserAmbMobileTxt);
            this.Controls.Add(this.UserAmbMobileLbl);
            this.Controls.Add(this.UserAmbAddressTxt);
            this.Controls.Add(this.UserAmbAddressLbl);
            this.Controls.Add(this.UserAmbQuantityTxt);
            this.Controls.Add(this.UserAmbQuantityLbl);
            this.Controls.Add(this.UserAmbPvrIDTxt);
            this.Controls.Add(this.UserAmbPvrIDLbl);
            this.Controls.Add(this.UserReqAmbLabel);
            this.Controls.Add(this.UserAmbUserIdTxt);
            this.Controls.Add(this.UserAmbCatagoryTxt);
            this.Controls.Add(this.btnUsrAmbReq);
            this.Controls.Add(this.UserAmbIDLbl);
            this.Controls.Add(this.UserAmbCatagoryLbl);
            this.Controls.Add(this.UsrAmbDataGrid);
            this.Name = "User_Ambulance";
            this.Text = "User_Ambulance";
            this.Load += new System.EventHandler(this.User_Ambulance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UsrAmbDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserReqAmbLabel;
        private System.Windows.Forms.TextBox UserAmbUserIdTxt;
        private System.Windows.Forms.TextBox UserAmbCatagoryTxt;
        private System.Windows.Forms.Button btnUsrAmbReq;
        private System.Windows.Forms.Label UserAmbIDLbl;
        private System.Windows.Forms.Label UserAmbCatagoryLbl;
        private System.Windows.Forms.DataGridView UsrAmbDataGrid;
        private System.Windows.Forms.TextBox UserAmbPvrIDTxt;
        private System.Windows.Forms.Label UserAmbPvrIDLbl;
        private System.Windows.Forms.Label UserAmbPriceTag;
        private System.Windows.Forms.Label UserAmbPriceLbl;
        private System.Windows.Forms.TextBox UserAmbMobileTxt;
        private System.Windows.Forms.Label UserAmbMobileLbl;
        private System.Windows.Forms.TextBox UserAmbAddressTxt;
        private System.Windows.Forms.Label UserAmbAddressLbl;
        private System.Windows.Forms.TextBox UserAmbQuantityTxt;
        private System.Windows.Forms.Label UserAmbQuantityLbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
    }
}