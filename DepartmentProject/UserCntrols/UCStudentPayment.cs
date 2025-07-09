using DepartmentBusinessLayer;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepartmentProject
{
    public partial class UCStudentPayment : UserControl
    {
        public UCStudentPayment()
        {
            InitializeComponent();
        }

      

        private void UCStudentPayment_Load(object sender, EventArgs e)
        {
            FailCmbListActiveStudent();
            LoadDataToGridView();
        }


        void FailCmbListActiveStudent()
        {
            DataTable dt = new DataTable();
            dt = clsPayment.GetAllActiveStudent();
            foreach(DataRow record in dt.Rows)
            {
                cmbListStudent.Items.Add(record["Name"]);
            }
        }

        private void txtValidate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void NumValidate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            clsPayment Payment = new clsPayment();
            Payment.StudentID = clsStudent.GetIdStudentByName(cmbListStudent.Text);
            Payment.FoodPrice =Convert.ToDecimal( txtFoodPayment.Text);
            Payment.PlcaePrice =Convert.ToDecimal( txtPlacePayment.Text);
            Payment.TotalPayment =Convert.ToDecimal( txtTotalPaymnet.Text);
            Payment.Date =datePayment.Value;
            if(Payment.AddNewPayment())
            {
                MessageBox.Show("Payment Added successfully :(" ,"Successed" ,MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataToGridView();
                cmbListStudent.SelectedIndex = 0;
                txtFoodPayment.Text = "";
                txtPlacePayment.Text = "";
                txtTotalPaymnet.Text = "";
                datePayment.Value = DateTime.Now;

            }
            else
            {
                MessageBox.Show("Payment Fail Added :(", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        void CalculatePayment()
        {
            decimal FoodPayment = 0;
            decimal PlacePayment = 0;
            if(txtFoodPayment.Text != "")
            {
                FoodPayment = Convert.ToDecimal(txtFoodPayment.Text);
            }
            if (txtPlacePayment.Text != "")
            {
                PlacePayment = Convert.ToDecimal(txtPlacePayment.Text);
            }
          
            txtTotalPaymnet.Text = (FoodPayment + PlacePayment).ToString();
        }

        void ChangeDataGridViewViolationHeader()
        {
            dgvPaymentInfo.Columns["ID"].HeaderText = "الرقم";
            dgvPaymentInfo.Columns["Name"].HeaderText = "اسم الطلب ";
            dgvPaymentInfo.Columns["FoodPrice"].HeaderText = " مبلغ التغذية";
            dgvPaymentInfo.Columns["PlacePrice"].HeaderText = " مبلغ التسكين";
            dgvPaymentInfo.Columns["TotalPayment"].HeaderText = "اجمالي المبلغ";
            dgvPaymentInfo.Columns["Date"].HeaderText = "تاريخ الدفع";


            dgvPaymentInfo.Columns[0].Width = 50;
            dgvPaymentInfo.Columns[1].Width = 170;
            dgvPaymentInfo.Columns[2].Width = 100;
            dgvPaymentInfo.Columns[3].Width = 110;
            dgvPaymentInfo.Columns[4].Width = 110;
            dgvPaymentInfo.Columns[5].Width = 120;
        }

        void LoadDataToGridView()
        {
            DataTable dt = new DataTable();
            dt = clsPayment.GetAllStudentWhichPaymented();
            dgvPaymentInfo.DataSource = dt;
            ChangeDataGridViewViolationHeader();
        }


        

        private void txtFoodPayment_TextChanged(object sender, EventArgs e)
        {
            CalculatePayment();
        }

        private void txtPlacePayment_TextChanged(object sender, EventArgs e)
        {
            CalculatePayment();
        }

        private void txtTotalPaymnet_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void rdAll_CheckedChanged(object sender, EventArgs e)
        {
            txtYear.Text = "";
            numMonth.Value = 0;
            LoadDataToGridView();
        }

       
       
        private void rdPayment_CheckedChanged(object sender, EventArgs e)
        {
            if(txtYear.Text =="" || numMonth.Value == 0)
            {
                //MessageBox.Show("please Enter both Year and Month on not both" ,"Error" , MessageBoxButtons.OK ,MessageBoxIcon.Error);
                txtYear.Text = "";
                numMonth.Value = 0;
                LoadDataToGridView();
            }
            else
            {
                DataTable dt = new DataTable();
                dt = clsPayment.GetAllStudentPaymentedInSpecficDate(Convert.ToInt32(txtYear.Text), Convert.ToInt32(numMonth.Value));
                if (dt.Rows.Count > 0)
                {

                    dgvPaymentInfo.DataSource = dt;
                }
            }
           
           
        }

        private void rdNotPayment_CheckedChanged(object sender, EventArgs e)
        {
            if (txtYear.Text == "" || numMonth.Value == 0)
            {
                // MessageBox.Show("please Enter both Year and Month on not both", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtYear.Text = "";
                numMonth.Value = 0;
                LoadDataToGridView();
            }
            else
            {
                DataTable dt = new DataTable();
                dt = clsPayment.GetAllStudentWhichNotPaymented(Convert.ToInt32(txtYear.Text), Convert.ToInt32(numMonth.Value));
                if (dt.Rows.Count > 0)
                {

                    dgvPaymentInfo.DataSource = dt;
                }
            }
        }

        private void btnExpertBDF_Click(object sender, EventArgs e)
        {
            // تحديد مكان الحفظ
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
            saveFileDialog.Title = "حفظ ملف PDF";
            saveFileDialog.FileName = "data.pdf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // إنشاء مستند PDF
                    Document document = new Document(PageSize.A4, 10f, 10f, 20f, 20f);
                    PdfWriter.GetInstance(document, new FileStream(saveFileDialog.FileName, FileMode.Create));
                    document.Open();

                    // إنشاء جدول PDF بنفس عدد الأعمدة
                    PdfPTable pdfTable = new PdfPTable(dgvPaymentInfo.Columns.Count);
                    pdfTable.WidthPercentage = 100;

                    // إضافة العناوين
                    foreach (DataGridViewColumn column in dgvPaymentInfo.Columns)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                        cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                        pdfTable.AddCell(cell);
                    }

                    // إضافة الصفوف
                    foreach (DataGridViewRow row in dgvPaymentInfo.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                pdfTable.AddCell(cell.Value?.ToString() ?? "");
                            }
                        }
                    }

                    document.Add(pdfTable);
                    document.Close();

                    MessageBox.Show("تم حفظ البيانات في ملف PDF بنجاح.", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("حدث خطأ أثناء التصدير: " + ex.Message);
                }
            }
        }
    
    }
}
