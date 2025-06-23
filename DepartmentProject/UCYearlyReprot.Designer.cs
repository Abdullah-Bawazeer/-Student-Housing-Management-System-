namespace DepartmentProject
{
    partial class UCYearlyReprot
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
            this.txtSearchData = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvReoprtViolationData = new System.Windows.Forms.DataGridView();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.btnAllStudentViolations = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button6 = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReoprtViolationData)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearchData
            // 
            this.txtSearchData.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.txtSearchData.BorderRadius = 10;
            this.txtSearchData.BorderThickness = 2;
            this.txtSearchData.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchData.DefaultText = "";
            this.txtSearchData.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchData.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchData.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchData.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchData.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchData.ForeColor = System.Drawing.Color.Black;
            this.txtSearchData.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchData.Location = new System.Drawing.Point(1224, 98);
            this.txtSearchData.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtSearchData.Name = "txtSearchData";
            this.txtSearchData.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtSearchData.PlaceholderText = "ابحث بالاسم";
            this.txtSearchData.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSearchData.SelectedText = "";
            this.txtSearchData.Size = new System.Drawing.Size(291, 53);
            this.txtSearchData.TabIndex = 25;
            this.txtSearchData.TextChanged += new System.EventHandler(this.txtSearchData_TextChanged);
            // 
            // dgvReoprtViolationData
            // 
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            this.dgvReoprtViolationData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReoprtViolationData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(250)))), ((int)(((byte)(240)))));
            this.dgvReoprtViolationData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReoprtViolationData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReoprtViolationData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReoprtViolationData.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReoprtViolationData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.dgvReoprtViolationData.Location = new System.Drawing.Point(45, 219);
            this.dgvReoprtViolationData.Margin = new System.Windows.Forms.Padding(4);
            this.dgvReoprtViolationData.Name = "dgvReoprtViolationData";
            this.dgvReoprtViolationData.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvReoprtViolationData.RowHeadersWidth = 40;
            this.dgvReoprtViolationData.RowTemplate.Height = 30;
            this.dgvReoprtViolationData.RowTemplate.ReadOnly = true;
            this.dgvReoprtViolationData.Size = new System.Drawing.Size(1470, 615);
            this.dgvReoprtViolationData.TabIndex = 28;
            // 
            // btnBack
            // 
            this.btnBack.BorderRadius = 15;
            this.btnBack.BorderThickness = 2;
            this.btnBack.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnBack.HoverState.FillColor = System.Drawing.Color.White;
            this.btnBack.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnBack.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBack.ImageSize = new System.Drawing.Size(30, 30);
            this.btnBack.Location = new System.Drawing.Point(45, 41);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(265, 53);
            this.btnBack.TabIndex = 42;
            this.btnBack.Text = "العودة";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAllStudentViolations
            // 
            this.btnAllStudentViolations.BorderRadius = 15;
            this.btnAllStudentViolations.BorderThickness = 2;
            this.btnAllStudentViolations.FillColor = System.Drawing.Color.White;
            this.btnAllStudentViolations.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllStudentViolations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnAllStudentViolations.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnAllStudentViolations.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnAllStudentViolations.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllStudentViolations.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnAllStudentViolations.Location = new System.Drawing.Point(1224, 860);
            this.btnAllStudentViolations.Name = "btnAllStudentViolations";
            this.btnAllStudentViolations.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAllStudentViolations.Size = new System.Drawing.Size(291, 53);
            this.btnAllStudentViolations.TabIndex = 43;
            this.btnAllStudentViolations.Text = "عرض جميع مخالفات الطالب";
            this.btnAllStudentViolations.Click += new System.EventHandler(this.btnAllStudentViolations_Click);
            // 
            // guna2Button6
            // 
            this.guna2Button6.BorderRadius = 15;
            this.guna2Button6.BorderThickness = 2;
            this.guna2Button6.FillColor = System.Drawing.Color.White;
            this.guna2Button6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.guna2Button6.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.guna2Button6.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.guna2Button6.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button6.HoverState.ForeColor = System.Drawing.Color.White;
            this.guna2Button6.Location = new System.Drawing.Point(45, 860);
            this.guna2Button6.Name = "guna2Button6";
            this.guna2Button6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.guna2Button6.Size = new System.Drawing.Size(291, 53);
            this.guna2Button6.TabIndex = 44;
            this.guna2Button6.Text = "طباعة تقرير BDF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(678, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 40);
            this.label2.TabIndex = 45;
            this.label2.Text = "التقرير السنوي النهائي";
            // 
            // UCYearlyReprot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2Button6);
            this.Controls.Add(this.btnAllStudentViolations);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvReoprtViolationData);
            this.Controls.Add(this.txtSearchData);
            this.MaximumSize = new System.Drawing.Size(1566, 938);
            this.MinimumSize = new System.Drawing.Size(1566, 938);
            this.Name = "UCYearlyReprot";
            this.Size = new System.Drawing.Size(1566, 938);
            this.Load += new System.EventHandler(this.UCYearlyReprot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReoprtViolationData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtSearchData;
        private System.Windows.Forms.DataGridView dgvReoprtViolationData;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Guna.UI2.WinForms.Guna2Button btnAllStudentViolations;
        private Guna.UI2.WinForms.Guna2Button guna2Button6;
        private System.Windows.Forms.Label label2;
    }
}
