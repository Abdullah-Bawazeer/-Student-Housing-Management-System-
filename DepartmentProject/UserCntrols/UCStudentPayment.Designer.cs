namespace DepartmentProject
{
    partial class UCStudentPayment
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
            this.cmbListStudent = new System.Windows.Forms.ComboBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotalPaymnet = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPlacePayment = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.datePayment = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtFoodPayment = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvPaymentInfo = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateFilter = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.rdNotPayment = new System.Windows.Forms.RadioButton();
            this.rdPayment = new System.Windows.Forms.RadioButton();
            this.rdAll = new System.Windows.Forms.RadioButton();
            this.txtYear = new Guna.UI2.WinForms.Guna2TextBox();
            this.numMonth = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnExpertBDF = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMonth)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbListStudent
            // 
            this.cmbListStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbListStudent.FormattingEnabled = true;
            this.cmbListStudent.ItemHeight = 29;
            this.cmbListStudent.Items.AddRange(new object[] {
            "الكل"});
            this.cmbListStudent.Location = new System.Drawing.Point(65, 136);
            this.cmbListStudent.Name = "cmbListStudent";
            this.cmbListStudent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbListStudent.Size = new System.Drawing.Size(413, 37);
            this.cmbListStudent.TabIndex = 35;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Location = new System.Drawing.Point(65, 93);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(413, 41);
            this.guna2Panel1.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(133, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "اختيار طالب";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.guna2GroupBox1.BorderRadius = 20;
            this.guna2GroupBox1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2GroupBox1.BorderThickness = 2;
            this.guna2GroupBox1.Controls.Add(this.btnSave);
            this.guna2GroupBox1.Controls.Add(this.label8);
            this.guna2GroupBox1.Controls.Add(this.label7);
            this.guna2GroupBox1.Controls.Add(this.txtTotalPaymnet);
            this.guna2GroupBox1.Controls.Add(this.label3);
            this.guna2GroupBox1.Controls.Add(this.txtPlacePayment);
            this.guna2GroupBox1.Controls.Add(this.label6);
            this.guna2GroupBox1.Controls.Add(this.datePayment);
            this.guna2GroupBox1.Controls.Add(this.txtFoodPayment);
            this.guna2GroupBox1.Controls.Add(this.guna2Panel1);
            this.guna2GroupBox1.Controls.Add(this.cmbListStudent);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 40, 5, 30);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(1001, 37);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.guna2GroupBox1.ShadowDecoration.BorderRadius = 30;
            this.guna2GroupBox1.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.guna2GroupBox1.ShadowDecoration.Depth = 80;
            this.guna2GroupBox1.ShadowDecoration.Enabled = true;
            this.guna2GroupBox1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10);
            this.guna2GroupBox1.Size = new System.Drawing.Size(533, 850);
            this.guna2GroupBox1.TabIndex = 36;
            this.guna2GroupBox1.Text = "اضافة مساهمة";
            this.guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 15;
            this.btnSave.BorderThickness = 2;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnSave.HoverState.FillColor = System.Drawing.Color.White;
            this.btnSave.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Image = global::DepartmentProject.Properties.Resources.arrow_dotted_rotate_anticlockwise_10x;
            this.btnSave.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSave.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSave.Location = new System.Drawing.Point(174, 728);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(265, 53);
            this.btnSave.TabIndex = 57;
            this.btnSave.Text = "حفظ";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(324, 574);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 36);
            this.label8.TabIndex = 56;
            this.label8.Text = "تاريخ المساهمة";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(256, 447);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(239, 36);
            this.label7.TabIndex = 55;
            this.label7.Text = "اجمالي مبلغ المساهمة";
            // 
            // txtTotalPaymnet
            // 
            this.txtTotalPaymnet.BackColor = System.Drawing.Color.Transparent;
            this.txtTotalPaymnet.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.txtTotalPaymnet.BorderRadius = 15;
            this.txtTotalPaymnet.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalPaymnet.DefaultText = "";
            this.txtTotalPaymnet.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotalPaymnet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotalPaymnet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalPaymnet.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalPaymnet.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalPaymnet.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPaymnet.ForeColor = System.Drawing.Color.Black;
            this.txtTotalPaymnet.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalPaymnet.Location = new System.Drawing.Point(98, 507);
            this.txtTotalPaymnet.Margin = new System.Windows.Forms.Padding(5);
            this.txtTotalPaymnet.Name = "txtTotalPaymnet";
            this.txtTotalPaymnet.PlaceholderText = "00000";
            this.txtTotalPaymnet.ReadOnly = true;
            this.txtTotalPaymnet.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotalPaymnet.SelectedText = "";
            this.txtTotalPaymnet.Size = new System.Drawing.Size(391, 42);
            this.txtTotalPaymnet.TabIndex = 54;
            this.txtTotalPaymnet.TextChanged += new System.EventHandler(this.txtTotalPaymnet_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(344, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 36);
            this.label3.TabIndex = 53;
            this.label3.Text = "مبلغ التسكين";
            // 
            // txtPlacePayment
            // 
            this.txtPlacePayment.BackColor = System.Drawing.Color.Transparent;
            this.txtPlacePayment.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.txtPlacePayment.BorderRadius = 15;
            this.txtPlacePayment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPlacePayment.DefaultText = "";
            this.txtPlacePayment.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPlacePayment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPlacePayment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPlacePayment.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPlacePayment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPlacePayment.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlacePayment.ForeColor = System.Drawing.Color.Black;
            this.txtPlacePayment.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPlacePayment.Location = new System.Drawing.Point(91, 374);
            this.txtPlacePayment.Margin = new System.Windows.Forms.Padding(5);
            this.txtPlacePayment.Name = "txtPlacePayment";
            this.txtPlacePayment.PlaceholderText = "00000";
            this.txtPlacePayment.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPlacePayment.SelectedText = "";
            this.txtPlacePayment.Size = new System.Drawing.Size(394, 42);
            this.txtPlacePayment.TabIndex = 52;
            this.txtPlacePayment.TextChanged += new System.EventHandler(this.txtPlacePayment_TextChanged);
            this.txtPlacePayment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumValidate_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(346, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 36);
            this.label6.TabIndex = 51;
            this.label6.Text = "مبلغ التغذية";
            // 
            // datePayment
            // 
            this.datePayment.BorderColor = System.Drawing.Color.White;
            this.datePayment.BorderRadius = 15;
            this.datePayment.BorderThickness = 1;
            this.datePayment.Checked = true;
            this.datePayment.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.datePayment.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.datePayment.ForeColor = System.Drawing.Color.White;
            this.datePayment.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePayment.Location = new System.Drawing.Point(98, 640);
            this.datePayment.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datePayment.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datePayment.Name = "datePayment";
            this.datePayment.Size = new System.Drawing.Size(402, 55);
            this.datePayment.TabIndex = 50;
            this.datePayment.Value = new System.DateTime(2025, 2, 28, 17, 10, 57, 275);
            // 
            // txtFoodPayment
            // 
            this.txtFoodPayment.BackColor = System.Drawing.Color.Transparent;
            this.txtFoodPayment.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.txtFoodPayment.BorderRadius = 15;
            this.txtFoodPayment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFoodPayment.DefaultText = "";
            this.txtFoodPayment.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFoodPayment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFoodPayment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFoodPayment.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFoodPayment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFoodPayment.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFoodPayment.ForeColor = System.Drawing.Color.Black;
            this.txtFoodPayment.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFoodPayment.Location = new System.Drawing.Point(91, 252);
            this.txtFoodPayment.Margin = new System.Windows.Forms.Padding(5);
            this.txtFoodPayment.Name = "txtFoodPayment";
            this.txtFoodPayment.PlaceholderText = "0000";
            this.txtFoodPayment.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFoodPayment.SelectedText = "";
            this.txtFoodPayment.Size = new System.Drawing.Size(394, 42);
            this.txtFoodPayment.TabIndex = 47;
            this.txtFoodPayment.TextChanged += new System.EventHandler(this.txtFoodPayment_TextChanged);
            this.txtFoodPayment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumValidate_KeyPress);
            // 
            // dgvPaymentInfo
            // 
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            this.dgvPaymentInfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPaymentInfo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(250)))), ((int)(((byte)(240)))));
            this.dgvPaymentInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPaymentInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPaymentInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPaymentInfo.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPaymentInfo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.dgvPaymentInfo.Location = new System.Drawing.Point(4, 196);
            this.dgvPaymentInfo.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPaymentInfo.Name = "dgvPaymentInfo";
            this.dgvPaymentInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvPaymentInfo.RowHeadersWidth = 40;
            this.dgvPaymentInfo.RowTemplate.Height = 30;
            this.dgvPaymentInfo.RowTemplate.ReadOnly = true;
            this.dgvPaymentInfo.Size = new System.Drawing.Size(953, 660);
            this.dgvPaymentInfo.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(539, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 36);
            this.label2.TabIndex = 43;
            this.label2.Text = "جميع المساهمات";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(43, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(296, 24);
            this.label4.TabIndex = 44;
            this.label4.Text = "تحديد المساهمات بتاريخ محدد";
            // 
            // dateFilter
            // 
            this.dateFilter.BorderColor = System.Drawing.Color.White;
            this.dateFilter.BorderRadius = 15;
            this.dateFilter.BorderThickness = 1;
            this.dateFilter.Checked = true;
            this.dateFilter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.dateFilter.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFilter.ForeColor = System.Drawing.Color.White;
            this.dateFilter.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFilter.Location = new System.Drawing.Point(562, 117);
            this.dateFilter.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateFilter.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateFilter.Name = "dateFilter";
            this.dateFilter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateFilter.Size = new System.Drawing.Size(275, 54);
            this.dateFilter.TabIndex = 45;
            this.dateFilter.Value = new System.DateTime(2025, 2, 28, 0, 0, 0, 0);
            // 
            // rdNotPayment
            // 
            this.rdNotPayment.AutoSize = true;
            this.rdNotPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdNotPayment.Location = new System.Drawing.Point(27, 136);
            this.rdNotPayment.Name = "rdNotPayment";
            this.rdNotPayment.Size = new System.Drawing.Size(155, 33);
            this.rdNotPayment.TabIndex = 46;
            this.rdNotPayment.Text = "غير السماهمين";
            this.rdNotPayment.UseVisualStyleBackColor = true;
            this.rdNotPayment.CheckedChanged += new System.EventHandler(this.rdNotPayment_CheckedChanged);
            // 
            // rdPayment
            // 
            this.rdPayment.AutoSize = true;
            this.rdPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdPayment.Location = new System.Drawing.Point(202, 130);
            this.rdPayment.Name = "rdPayment";
            this.rdPayment.Size = new System.Drawing.Size(116, 33);
            this.rdPayment.TabIndex = 47;
            this.rdPayment.Text = "المساهمين";
            this.rdPayment.UseVisualStyleBackColor = true;
            this.rdPayment.CheckedChanged += new System.EventHandler(this.rdPayment_CheckedChanged);
            // 
            // rdAll
            // 
            this.rdAll.AutoSize = true;
            this.rdAll.Checked = true;
            this.rdAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdAll.Location = new System.Drawing.Point(349, 136);
            this.rdAll.Name = "rdAll";
            this.rdAll.Size = new System.Drawing.Size(69, 33);
            this.rdAll.TabIndex = 48;
            this.rdAll.TabStop = true;
            this.rdAll.Text = "الكل";
            this.rdAll.UseVisualStyleBackColor = true;
            this.rdAll.CheckedChanged += new System.EventHandler(this.rdAll_CheckedChanged);
            // 
            // txtYear
            // 
            this.txtYear.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.txtYear.BorderRadius = 4;
            this.txtYear.BorderThickness = 2;
            this.txtYear.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtYear.DefaultText = "";
            this.txtYear.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtYear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtYear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtYear.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtYear.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtYear.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.ForeColor = System.Drawing.Color.Black;
            this.txtYear.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtYear.Location = new System.Drawing.Point(27, 74);
            this.txtYear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtYear.Name = "txtYear";
            this.txtYear.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtYear.PlaceholderText = "سنة";
            this.txtYear.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtYear.SelectedText = "";
            this.txtYear.Size = new System.Drawing.Size(127, 49);
            this.txtYear.TabIndex = 49;
            this.txtYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumValidate_KeyPress);
            // 
            // numMonth
            // 
            this.numMonth.BackColor = System.Drawing.Color.Transparent;
            this.numMonth.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.numMonth.BorderThickness = 2;
            this.numMonth.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numMonth.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMonth.Location = new System.Drawing.Point(188, 74);
            this.numMonth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numMonth.Name = "numMonth";
            this.numMonth.Size = new System.Drawing.Size(151, 49);
            this.numMonth.TabIndex = 50;
            this.numMonth.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.numMonth.UpDownButtonForeColor = System.Drawing.Color.White;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(235, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 25);
            this.label5.TabIndex = 51;
            this.label5.Text = "لشهر";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(60, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 25);
            this.label9.TabIndex = 52;
            this.label9.Text = "لسنة";
            // 
            // btnExpertBDF
            // 
            this.btnExpertBDF.BorderRadius = 15;
            this.btnExpertBDF.BorderThickness = 2;
            this.btnExpertBDF.FillColor = System.Drawing.Color.White;
            this.btnExpertBDF.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpertBDF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnExpertBDF.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnExpertBDF.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnExpertBDF.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpertBDF.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnExpertBDF.Location = new System.Drawing.Point(326, 871);
            this.btnExpertBDF.Name = "btnExpertBDF";
            this.btnExpertBDF.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnExpertBDF.Size = new System.Drawing.Size(291, 53);
            this.btnExpertBDF.TabIndex = 53;
            this.btnExpertBDF.Text = "طباعة تقرير BDF";
            this.btnExpertBDF.Click += new System.EventHandler(this.btnExpertBDF_Click);
            // 
            // UCStudentPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnExpertBDF);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numMonth);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.rdAll);
            this.Controls.Add(this.rdPayment);
            this.Controls.Add(this.rdNotPayment);
            this.Controls.Add(this.dateFilter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvPaymentInfo);
            this.Controls.Add(this.guna2GroupBox1);
            this.MaximumSize = new System.Drawing.Size(1566, 938);
            this.MinimumSize = new System.Drawing.Size(1566, 938);
            this.Name = "UCStudentPayment";
            this.Size = new System.Drawing.Size(1566, 938);
            this.Load += new System.EventHandler(this.UCStudentPayment_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMonth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbListStudent;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtFoodPayment;
        private System.Windows.Forms.DataGridView dgvPaymentInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateFilter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalPaymnet;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtPlacePayment;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2DateTimePicker datePayment;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.RadioButton rdNotPayment;
        private System.Windows.Forms.RadioButton rdPayment;
        private System.Windows.Forms.RadioButton rdAll;
        private Guna.UI2.WinForms.Guna2TextBox txtYear;
        private Guna.UI2.WinForms.Guna2NumericUpDown numMonth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2Button btnExpertBDF;
    }
}
