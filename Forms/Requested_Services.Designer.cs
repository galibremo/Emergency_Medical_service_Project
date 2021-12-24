
namespace MedicalService.Forms
{
    partial class Requested_Services
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
            this.RequestedDataGrid = new System.Windows.Forms.DataGridView();
            this.RequestSuccess = new System.Windows.Forms.Button();
            this.RequestPending = new System.Windows.Forms.Label();
            this.PvdPendingReqtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PvdIdReqChecktxt = new System.Windows.Forms.TextBox();
            this.btnPvdReqCheck = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.RequestedDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // RequestedDataGrid
            // 
            this.RequestedDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.RequestedDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RequestedDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.RequestedDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RequestedDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.RequestedDataGrid.ColumnHeadersHeight = 35;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RequestedDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.RequestedDataGrid.EnableHeadersVisualStyles = false;
            this.RequestedDataGrid.GridColor = System.Drawing.Color.LightGray;
            this.RequestedDataGrid.Location = new System.Drawing.Point(33, 88);
            this.RequestedDataGrid.Name = "RequestedDataGrid";
            this.RequestedDataGrid.RowHeadersVisible = false;
            this.RequestedDataGrid.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.RequestedDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.RequestedDataGrid.RowTemplate.Height = 29;
            this.RequestedDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RequestedDataGrid.Size = new System.Drawing.Size(683, 268);
            this.RequestedDataGrid.TabIndex = 0;
            this.RequestedDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ReqDataGrid_Click);
            // 
            // RequestSuccess
            // 
            this.RequestSuccess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RequestSuccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RequestSuccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RequestSuccess.ForeColor = System.Drawing.Color.White;
            this.RequestSuccess.Location = new System.Drawing.Point(305, 383);
            this.RequestSuccess.Name = "RequestSuccess";
            this.RequestSuccess.Size = new System.Drawing.Size(98, 45);
            this.RequestSuccess.TabIndex = 1;
            this.RequestSuccess.Text = "Success";
            this.RequestSuccess.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.RequestSuccess.UseVisualStyleBackColor = false;
            this.RequestSuccess.Click += new System.EventHandler(this.PvdReqSuccess_Click);
            // 
            // RequestPending
            // 
            this.RequestPending.AutoSize = true;
            this.RequestPending.BackColor = System.Drawing.Color.Transparent;
            this.RequestPending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RequestPending.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RequestPending.ForeColor = System.Drawing.Color.White;
            this.RequestPending.Location = new System.Drawing.Point(33, 44);
            this.RequestPending.Name = "RequestPending";
            this.RequestPending.Size = new System.Drawing.Size(199, 25);
            this.RequestPending.TabIndex = 2;
            this.RequestPending.Text = "Pending requests : ";
            // 
            // PvdPendingReqtxt
            // 
            this.PvdPendingReqtxt.BackColor = System.Drawing.Color.DodgerBlue;
            this.PvdPendingReqtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PvdPendingReqtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PvdPendingReqtxt.ForeColor = System.Drawing.Color.White;
            this.PvdPendingReqtxt.Location = new System.Drawing.Point(238, 42);
            this.PvdPendingReqtxt.Name = "PvdPendingReqtxt";
            this.PvdPendingReqtxt.Size = new System.Drawing.Size(72, 17);
            this.PvdPendingReqtxt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(411, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID : ";
            // 
            // PvdIdReqChecktxt
            // 
            this.PvdIdReqChecktxt.BackColor = System.Drawing.Color.DodgerBlue;
            this.PvdIdReqChecktxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PvdIdReqChecktxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PvdIdReqChecktxt.ForeColor = System.Drawing.Color.White;
            this.PvdIdReqChecktxt.Location = new System.Drawing.Point(469, 42);
            this.PvdIdReqChecktxt.Name = "PvdIdReqChecktxt";
            this.PvdIdReqChecktxt.Size = new System.Drawing.Size(140, 17);
            this.PvdIdReqChecktxt.TabIndex = 3;
            this.PvdIdReqChecktxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnPvdReqCheck
            // 
            this.btnPvdReqCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPvdReqCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPvdReqCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPvdReqCheck.ForeColor = System.Drawing.Color.White;
            this.btnPvdReqCheck.Location = new System.Drawing.Point(628, 42);
            this.btnPvdReqCheck.Name = "btnPvdReqCheck";
            this.btnPvdReqCheck.Size = new System.Drawing.Size(88, 37);
            this.btnPvdReqCheck.TabIndex = 1;
            this.btnPvdReqCheck.Text = "CHECK";
            this.btnPvdReqCheck.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnPvdReqCheck.UseVisualStyleBackColor = false;
            this.btnPvdReqCheck.Click += new System.EventHandler(this.PvdReqCheck_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(469, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(145, 5);
            this.panel2.TabIndex = 65;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(238, 69);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(75, 5);
            this.panel3.TabIndex = 66;
            // 
            // Requested_Services
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.PvdIdReqChecktxt);
            this.Controls.Add(this.PvdPendingReqtxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RequestPending);
            this.Controls.Add(this.btnPvdReqCheck);
            this.Controls.Add(this.RequestSuccess);
            this.Controls.Add(this.RequestedDataGrid);
            this.Name = "Requested_Services";
            this.Text = "Requested Services";
            ((System.ComponentModel.ISupportInitialize)(this.RequestedDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView RequestedDataGrid;
        private System.Windows.Forms.Button RequestSuccess;
        private System.Windows.Forms.Label RequestPending;
        private System.Windows.Forms.TextBox PvdPendingReqtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PvdIdReqChecktxt;
        private System.Windows.Forms.Button btnPvdReqCheck;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}