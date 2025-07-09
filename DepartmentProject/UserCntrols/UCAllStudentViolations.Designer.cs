namespace DepartmentProject
{
    partial class UCAllStudentViolations
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.UCTitle = new System.Windows.Forms.Label();
            this.btnExpertToPDF = new Guna.UI2.WinForms.Guna2Button();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.dgvViolationsData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViolationsData)).BeginInit();
            this.SuspendLayout();
            // 
            // UCTitle
            // 
            this.UCTitle.AutoSize = true;
            this.UCTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UCTitle.Location = new System.Drawing.Point(814, 39);
            this.UCTitle.Name = "UCTitle";
            this.UCTitle.Size = new System.Drawing.Size(248, 36);
            this.UCTitle.TabIndex = 44;
            this.UCTitle.Text = "جميع مخالفات الطالب ";
            // 
            // btnExpertToPDF
            // 
            this.btnExpertToPDF.BorderRadius = 15;
            this.btnExpertToPDF.BorderThickness = 2;
            this.btnExpertToPDF.FillColor = System.Drawing.Color.White;
            this.btnExpertToPDF.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpertToPDF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnExpertToPDF.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnExpertToPDF.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnExpertToPDF.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpertToPDF.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnExpertToPDF.Location = new System.Drawing.Point(23, 860);
            this.btnExpertToPDF.Name = "btnExpertToPDF";
            this.btnExpertToPDF.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnExpertToPDF.Size = new System.Drawing.Size(291, 53);
            this.btnExpertToPDF.TabIndex = 45;
            this.btnExpertToPDF.Text = "طباعة تقرير BDF";
            this.btnExpertToPDF.Click += new System.EventHandler(this.btnExpertToPDF_Click);
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
            this.btnBack.Location = new System.Drawing.Point(23, 22);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(265, 53);
            this.btnBack.TabIndex = 46;
            this.btnBack.Text = "العودة";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dgvViolationsData
            // 
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver;
            this.dgvViolationsData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvViolationsData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(250)))), ((int)(((byte)(240)))));
            this.dgvViolationsData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvViolationsData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvViolationsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvViolationsData.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvViolationsData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.dgvViolationsData.Location = new System.Drawing.Point(33, 145);
            this.dgvViolationsData.Margin = new System.Windows.Forms.Padding(4);
            this.dgvViolationsData.Name = "dgvViolationsData";
            this.dgvViolationsData.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvViolationsData.RowHeadersWidth = 40;
            this.dgvViolationsData.RowTemplate.Height = 30;
            this.dgvViolationsData.RowTemplate.ReadOnly = true;
            this.dgvViolationsData.Size = new System.Drawing.Size(1509, 685);
            this.dgvViolationsData.TabIndex = 47;
            // 
            // UCAllStudentViolations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvViolationsData);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnExpertToPDF);
            this.Controls.Add(this.UCTitle);
            this.MaximumSize = new System.Drawing.Size(1566, 938);
            this.MinimumSize = new System.Drawing.Size(1566, 938);
            this.Name = "UCAllStudentViolations";
            this.Size = new System.Drawing.Size(1566, 938);
            this.Load += new System.EventHandler(this.UCAllStudentViolations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViolationsData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label UCTitle;
        private Guna.UI2.WinForms.Guna2Button btnExpertToPDF;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private System.Windows.Forms.DataGridView dgvViolationsData;
    }
}
