namespace DepartmentProject
{
    partial class StudentMangementTC
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbStudent = new System.Windows.Forms.ComboBox();
            this.cmbUniversity = new System.Windows.Forms.ComboBox();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbMajors = new System.Windows.Forms.ComboBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbLevels = new System.Windows.Forms.ComboBox();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTimePeriod = new System.Windows.Forms.ComboBox();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUpadetStudentInfo = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteStudent = new Guna.UI2.WinForms.Guna2Button();
            this.btnShowStudentInfo = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearchData = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.btnRefreash = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddStudent = new Guna.UI2.WinForms.Guna2Button();
            this.dgvShowStudentInfo = new System.Windows.Forms.DataGridView();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowStudentInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Location = new System.Drawing.Point(1187, 148);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(241, 41);
            this.guna2Panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(88, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "الطلاب";
            // 
            // cmbStudent
            // 
            this.cmbStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStudent.FormattingEnabled = true;
            this.cmbStudent.ItemHeight = 20;
            this.cmbStudent.Items.AddRange(new object[] {
            "الكل",
            "الخريجين",
            "قيد الدراسة"});
            this.cmbStudent.Location = new System.Drawing.Point(1187, 189);
            this.cmbStudent.Name = "cmbStudent";
            this.cmbStudent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbStudent.Size = new System.Drawing.Size(241, 28);
            this.cmbStudent.TabIndex = 5;
            this.cmbStudent.SelectedIndexChanged += new System.EventHandler(this.cmbStudent_SelectedIndexChanged);
            // 
            // cmbUniversity
            // 
            this.cmbUniversity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUniversity.FormattingEnabled = true;
            this.cmbUniversity.ItemHeight = 20;
            this.cmbUniversity.Items.AddRange(new object[] {
            "الكل"});
            this.cmbUniversity.Location = new System.Drawing.Point(904, 189);
            this.cmbUniversity.Name = "cmbUniversity";
            this.cmbUniversity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbUniversity.Size = new System.Drawing.Size(241, 28);
            this.cmbUniversity.TabIndex = 11;
            this.cmbUniversity.SelectedIndexChanged += new System.EventHandler(this.cmbUniversity_SelectedIndexChanged);
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.guna2Panel4.Controls.Add(this.label4);
            this.guna2Panel4.Location = new System.Drawing.Point(904, 148);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(241, 41);
            this.guna2Panel4.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(88, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "الجامعات";
            // 
            // cmbMajors
            // 
            this.cmbMajors.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMajors.FormattingEnabled = true;
            this.cmbMajors.ItemHeight = 20;
            this.cmbMajors.Items.AddRange(new object[] {
            "الكل"});
            this.cmbMajors.Location = new System.Drawing.Point(621, 189);
            this.cmbMajors.Name = "cmbMajors";
            this.cmbMajors.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbMajors.Size = new System.Drawing.Size(241, 28);
            this.cmbMajors.TabIndex = 13;
            this.cmbMajors.SelectedIndexChanged += new System.EventHandler(this.cmbMajors_SelectedIndexChanged);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.guna2Panel2.Controls.Add(this.label2);
            this.guna2Panel2.Location = new System.Drawing.Point(621, 148);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(241, 41);
            this.guna2Panel2.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(75, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "التخصصات";
            // 
            // cmbLevels
            // 
            this.cmbLevels.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLevels.FormattingEnabled = true;
            this.cmbLevels.ItemHeight = 20;
            this.cmbLevels.Items.AddRange(new object[] {
            "الكل"});
            this.cmbLevels.Location = new System.Drawing.Point(321, 189);
            this.cmbLevels.Name = "cmbLevels";
            this.cmbLevels.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbLevels.Size = new System.Drawing.Size(241, 28);
            this.cmbLevels.TabIndex = 15;
            this.cmbLevels.SelectedIndexChanged += new System.EventHandler(this.cmbLevels_SelectedIndexChanged);
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.guna2Panel3.Controls.Add(this.label3);
            this.guna2Panel3.Location = new System.Drawing.Point(321, 148);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(241, 41);
            this.guna2Panel3.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(75, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "المستويات";
            // 
            // cmbTimePeriod
            // 
            this.cmbTimePeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTimePeriod.FormattingEnabled = true;
            this.cmbTimePeriod.ItemHeight = 20;
            this.cmbTimePeriod.Items.AddRange(new object[] {
            "الكل"});
            this.cmbTimePeriod.Location = new System.Drawing.Point(25, 189);
            this.cmbTimePeriod.Name = "cmbTimePeriod";
            this.cmbTimePeriod.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbTimePeriod.Size = new System.Drawing.Size(241, 28);
            this.cmbTimePeriod.TabIndex = 17;
            this.cmbTimePeriod.SelectedIndexChanged += new System.EventHandler(this.cmbTimePeriod_SelectedIndexChanged);
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.guna2Panel5.Controls.Add(this.label5);
            this.guna2Panel5.Location = new System.Drawing.Point(25, 148);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Size = new System.Drawing.Size(241, 41);
            this.guna2Panel5.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(57, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "فترة الدراسة";
            // 
            // btnUpadetStudentInfo
            // 
            this.btnUpadetStudentInfo.BackColor = System.Drawing.Color.White;
            this.btnUpadetStudentInfo.BorderRadius = 15;
            this.btnUpadetStudentInfo.BorderThickness = 2;
            this.btnUpadetStudentInfo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnUpadetStudentInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpadetStudentInfo.ForeColor = System.Drawing.Color.White;
            this.btnUpadetStudentInfo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnUpadetStudentInfo.HoverState.FillColor = System.Drawing.Color.White;
            this.btnUpadetStudentInfo.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnUpadetStudentInfo.Location = new System.Drawing.Point(1139, 828);
            this.btnUpadetStudentInfo.Name = "btnUpadetStudentInfo";
            this.btnUpadetStudentInfo.Size = new System.Drawing.Size(291, 53);
            this.btnUpadetStudentInfo.TabIndex = 19;
            this.btnUpadetStudentInfo.Text = "تعديل طالب";
            this.btnUpadetStudentInfo.Click += new System.EventHandler(this.btnUpadetStudentInfo_Click);
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.BackColor = System.Drawing.Color.White;
            this.btnDeleteStudent.BorderRadius = 15;
            this.btnDeleteStudent.BorderThickness = 2;
            this.btnDeleteStudent.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnDeleteStudent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteStudent.ForeColor = System.Drawing.Color.White;
            this.btnDeleteStudent.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnDeleteStudent.HoverState.FillColor = System.Drawing.Color.White;
            this.btnDeleteStudent.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteStudent.Location = new System.Drawing.Point(401, 828);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(291, 53);
            this.btnDeleteStudent.TabIndex = 21;
            this.btnDeleteStudent.Text = "حذف طالب";
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // btnShowStudentInfo
            // 
            this.btnShowStudentInfo.BackColor = System.Drawing.Color.White;
            this.btnShowStudentInfo.BorderRadius = 15;
            this.btnShowStudentInfo.BorderThickness = 2;
            this.btnShowStudentInfo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnShowStudentInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowStudentInfo.ForeColor = System.Drawing.Color.White;
            this.btnShowStudentInfo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnShowStudentInfo.HoverState.FillColor = System.Drawing.Color.White;
            this.btnShowStudentInfo.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnShowStudentInfo.Location = new System.Drawing.Point(771, 828);
            this.btnShowStudentInfo.Name = "btnShowStudentInfo";
            this.btnShowStudentInfo.Size = new System.Drawing.Size(291, 53);
            this.btnShowStudentInfo.TabIndex = 22;
            this.btnShowStudentInfo.Text = "عرض معلومات طالب";
            this.btnShowStudentInfo.Click += new System.EventHandler(this.btnShowStudentInfo_Click);
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
            this.txtSearchData.Location = new System.Drawing.Point(1136, 32);
            this.txtSearchData.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtSearchData.Name = "txtSearchData";
            this.txtSearchData.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtSearchData.PlaceholderText = "ابحث بالاسم";
            this.txtSearchData.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSearchData.SelectedText = "";
            this.txtSearchData.Size = new System.Drawing.Size(291, 53);
            this.txtSearchData.TabIndex = 24;
            this.txtSearchData.TextChanged += new System.EventHandler(this.txtSearchData_TextChanged);
            // 
            // guna2Button5
            // 
            this.guna2Button5.BackColor = System.Drawing.Color.White;
            this.guna2Button5.BorderRadius = 15;
            this.guna2Button5.BorderThickness = 2;
            this.guna2Button5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.guna2Button5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button5.ForeColor = System.Drawing.Color.White;
            this.guna2Button5.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.guna2Button5.HoverState.FillColor = System.Drawing.Color.White;
            this.guna2Button5.HoverState.ForeColor = System.Drawing.Color.Black;
            this.guna2Button5.Image = global::DepartmentProject.Properties.Resources.file_content_10x;
            this.guna2Button5.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button5.Location = new System.Drawing.Point(32, 828);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.Size = new System.Drawing.Size(291, 53);
            this.guna2Button5.TabIndex = 20;
            this.guna2Button5.Text = "طباعة تقرير";
            // 
            // btnRefreash
            // 
            this.btnRefreash.BackColor = System.Drawing.Color.White;
            this.btnRefreash.BorderRadius = 15;
            this.btnRefreash.BorderThickness = 2;
            this.btnRefreash.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnRefreash.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreash.ForeColor = System.Drawing.Color.White;
            this.btnRefreash.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnRefreash.HoverState.FillColor = System.Drawing.Color.White;
            this.btnRefreash.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnRefreash.Image = global::DepartmentProject.Properties.Resources.arrow_dotted_rotate_anticlockwise_10x;
            this.btnRefreash.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRefreash.ImageSize = new System.Drawing.Size(30, 30);
            this.btnRefreash.Location = new System.Drawing.Point(79, 32);
            this.btnRefreash.Name = "btnRefreash";
            this.btnRefreash.Size = new System.Drawing.Size(265, 53);
            this.btnRefreash.TabIndex = 3;
            this.btnRefreash.Text = "تحديث";
            this.btnRefreash.Click += new System.EventHandler(this.btnRefreash_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.BackColor = System.Drawing.Color.White;
            this.guna2Button2.BorderRadius = 15;
            this.guna2Button2.BorderThickness = 2;
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.guna2Button2.HoverState.FillColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.ForeColor = System.Drawing.Color.Black;
            this.guna2Button2.Image = global::DepartmentProject.Properties.Resources.print_10x;
            this.guna2Button2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button2.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button2.Location = new System.Drawing.Point(419, 32);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(291, 53);
            this.guna2Button2.TabIndex = 2;
            this.guna2Button2.Text = "طباعة";
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.BackColor = System.Drawing.Color.White;
            this.btnAddStudent.BorderRadius = 15;
            this.btnAddStudent.BorderThickness = 2;
            this.btnAddStudent.CheckedState.BorderColor = System.Drawing.Color.Blue;
            this.btnAddStudent.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnAddStudent.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnAddStudent.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnAddStudent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudent.ForeColor = System.Drawing.Color.White;
            this.btnAddStudent.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnAddStudent.HoverState.FillColor = System.Drawing.Color.White;
            this.btnAddStudent.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnAddStudent.Image = global::DepartmentProject.Properties.Resources.square_plus_10x;
            this.btnAddStudent.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddStudent.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddStudent.Location = new System.Drawing.Point(767, 32);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(291, 53);
            this.btnAddStudent.TabIndex = 1;
            this.btnAddStudent.Text = "اضافة طالب";
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // dgvShowStudentInfo
            // 
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver;
            this.dgvShowStudentInfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvShowStudentInfo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(250)))), ((int)(((byte)(240)))));
            this.dgvShowStudentInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShowStudentInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvShowStudentInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvShowStudentInfo.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvShowStudentInfo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.dgvShowStudentInfo.Location = new System.Drawing.Point(25, 249);
            this.dgvShowStudentInfo.Margin = new System.Windows.Forms.Padding(4);
            this.dgvShowStudentInfo.Name = "dgvShowStudentInfo";
            this.dgvShowStudentInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvShowStudentInfo.RowHeadersWidth = 40;
            this.dgvShowStudentInfo.RowTemplate.Height = 30;
            this.dgvShowStudentInfo.RowTemplate.ReadOnly = true;
            this.dgvShowStudentInfo.Size = new System.Drawing.Size(1426, 549);
            this.dgvShowStudentInfo.TabIndex = 27;
            // 
            // StudentMangementTC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvShowStudentInfo);
            this.Controls.Add(this.txtSearchData);
            this.Controls.Add(this.btnShowStudentInfo);
            this.Controls.Add(this.btnDeleteStudent);
            this.Controls.Add(this.guna2Button5);
            this.Controls.Add(this.btnUpadetStudentInfo);
            this.Controls.Add(this.cmbTimePeriod);
            this.Controls.Add(this.guna2Panel5);
            this.Controls.Add(this.cmbLevels);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.cmbMajors);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.cmbUniversity);
            this.Controls.Add(this.guna2Panel4);
            this.Controls.Add(this.cmbStudent);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.btnRefreash);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.btnAddStudent);
            this.Name = "StudentMangementTC";
            this.Size = new System.Drawing.Size(1566, 938);
            this.Load += new System.EventHandler(this.StudentMangementTC_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.guna2Panel5.ResumeLayout(false);
            this.guna2Panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowStudentInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnAddStudent;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button btnRefreash;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbStudent;
        private System.Windows.Forms.ComboBox cmbUniversity;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbMajors;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbLevels;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTimePeriod;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button btnUpadetStudentInfo;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Guna.UI2.WinForms.Guna2Button btnDeleteStudent;
        private Guna.UI2.WinForms.Guna2Button btnShowStudentInfo;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchData;
        private System.Windows.Forms.DataGridView dgvShowStudentInfo;
    }
}
