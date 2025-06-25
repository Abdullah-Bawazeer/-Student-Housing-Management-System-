namespace DepartmentProject
{
    partial class UCExpensesManagement
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnUpdateBills = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteBills = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddBills = new Guna.UI2.WinForms.Guna2Button();
            this.dgvShowExpensesInfo = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowExpensesInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdateBills
            // 
            this.btnUpdateBills.BorderRadius = 15;
            this.btnUpdateBills.BorderThickness = 2;
            this.btnUpdateBills.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnUpdateBills.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateBills.ForeColor = System.Drawing.Color.White;
            this.btnUpdateBills.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnUpdateBills.HoverState.FillColor = System.Drawing.Color.White;
            this.btnUpdateBills.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnUpdateBills.Location = new System.Drawing.Point(788, 727);
            this.btnUpdateBills.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateBills.Name = "btnUpdateBills";
            this.btnUpdateBills.Size = new System.Drawing.Size(292, 53);
            this.btnUpdateBills.TabIndex = 25;
            this.btnUpdateBills.Text = "تعديل الفاتورة";
            this.btnUpdateBills.Click += new System.EventHandler(this.btnUpdateBills_Click);
            // 
            // btnDeleteBills
            // 
            this.btnDeleteBills.BorderRadius = 15;
            this.btnDeleteBills.BorderThickness = 2;
            this.btnDeleteBills.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnDeleteBills.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteBills.ForeColor = System.Drawing.Color.White;
            this.btnDeleteBills.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnDeleteBills.HoverState.FillColor = System.Drawing.Color.White;
            this.btnDeleteBills.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnDeleteBills.Location = new System.Drawing.Point(397, 727);
            this.btnDeleteBills.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteBills.Name = "btnDeleteBills";
            this.btnDeleteBills.Size = new System.Drawing.Size(292, 53);
            this.btnDeleteBills.TabIndex = 24;
            this.btnDeleteBills.Text = "حذف الفاتورة";
            this.btnDeleteBills.Click += new System.EventHandler(this.btnDeleteBills_Click);
            // 
            // btnAddBills
            // 
            this.btnAddBills.BorderRadius = 15;
            this.btnAddBills.BorderThickness = 2;
            this.btnAddBills.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnAddBills.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBills.ForeColor = System.Drawing.Color.White;
            this.btnAddBills.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnAddBills.HoverState.FillColor = System.Drawing.Color.White;
            this.btnAddBills.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnAddBills.Location = new System.Drawing.Point(1115, 104);
            this.btnAddBills.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddBills.Name = "btnAddBills";
            this.btnAddBills.Size = new System.Drawing.Size(292, 53);
            this.btnAddBills.TabIndex = 23;
            this.btnAddBills.Text = "اضافة فاتورة";
            this.btnAddBills.Click += new System.EventHandler(this.btnAddBills_Click);
            // 
            // dgvShowExpensesInfo
            // 
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            this.dgvShowExpensesInfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvShowExpensesInfo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(250)))), ((int)(((byte)(240)))));
            this.dgvShowExpensesInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShowExpensesInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvShowExpensesInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvShowExpensesInfo.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvShowExpensesInfo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.dgvShowExpensesInfo.Location = new System.Drawing.Point(72, 232);
            this.dgvShowExpensesInfo.Margin = new System.Windows.Forms.Padding(4);
            this.dgvShowExpensesInfo.Name = "dgvShowExpensesInfo";
            this.dgvShowExpensesInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvShowExpensesInfo.RowHeadersWidth = 40;
            this.dgvShowExpensesInfo.RowTemplate.Height = 30;
            this.dgvShowExpensesInfo.RowTemplate.ReadOnly = true;
            this.dgvShowExpensesInfo.Size = new System.Drawing.Size(1335, 441);
            this.dgvShowExpensesInfo.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(659, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 29);
            this.label1.TabIndex = 28;
            this.label1.Text = "ادارة المصروفات";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 15;
            this.guna2Button1.BorderThickness = 2;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.guna2Button1.Location = new System.Drawing.Point(22, 727);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(292, 53);
            this.guna2Button1.TabIndex = 29;
            this.guna2Button1.Text = "طباعة فاتورة";
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderRadius = 15;
            this.guna2Button2.BorderThickness = 2;
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.guna2Button2.HoverState.FillColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.guna2Button2.Location = new System.Drawing.Point(1126, 727);
            this.guna2Button2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(292, 53);
            this.guna2Button2.TabIndex = 30;
            this.guna2Button2.Text = "عرض قاتورة";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BorderRadius = 15;
            this.btnRefresh.BorderThickness = 2;
            this.btnRefresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnRefresh.HoverState.FillColor = System.Drawing.Color.White;
            this.btnRefresh.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnRefresh.Image = global::DepartmentProject.Properties.Resources.arrow_dotted_rotate_anticlockwise_10x1;
            this.btnRefresh.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRefresh.ImageSize = new System.Drawing.Size(30, 30);
            this.btnRefresh.Location = new System.Drawing.Point(194, 104);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(209, 53);
            this.btnRefresh.TabIndex = 31;
            this.btnRefresh.Text = "تحديث";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DepartmentProject.Properties.Resources.Data_report_amico;
            this.pictureBox1.Location = new System.Drawing.Point(485, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(429, 171);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // UCExpensesManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvShowExpensesInfo);
            this.Controls.Add(this.btnUpdateBills);
            this.Controls.Add(this.btnDeleteBills);
            this.Controls.Add(this.btnAddBills);
            this.Name = "UCExpensesManagement";
            this.Size = new System.Drawing.Size(1467, 812);
            this.Load += new System.EventHandler(this.UCExpensesManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowExpensesInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnUpdateBills;
        private Guna.UI2.WinForms.Guna2Button btnDeleteBills;
        private Guna.UI2.WinForms.Guna2Button btnAddBills;
        private System.Windows.Forms.DataGridView dgvShowExpensesInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
    }
}
