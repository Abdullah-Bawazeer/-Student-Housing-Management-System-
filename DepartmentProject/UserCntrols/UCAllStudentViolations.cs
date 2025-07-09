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
    public partial class UCAllStudentViolations : UserControl
    {
        int _StudentID = 0;
        UCYearlyReprot UCReport= new UCYearlyReprot();
        public UCAllStudentViolations( int ID)
        {
            this._StudentID = ID;
            InitializeComponent();
        }

        private void UCAllStudentViolations_Load(object sender, EventArgs e)
        {
            LoadAllStudentViolation();
            UCTitle.Text += "  : " + clsStudent.GetStudentNameById(_StudentID);
        }

        void ChangeDataGridViewViolationHeader()
        {
            dgvViolationsData.Columns["ID"].HeaderText = "الرقم";
            dgvViolationsData.Columns["StudentName"].HeaderText = "اسم الطلب ";
            dgvViolationsData.Columns["ViolationName"].HeaderText = " نوع المخالفة";
            dgvViolationsData.Columns["ViolationDate"].HeaderText = " تاريخ المخالفة";
            dgvViolationsData.Columns["ViolationDescription"].HeaderText = "وصف المخالفة ";
            dgvViolationsData.Columns["ViolationCount"].HeaderText = " عدد المخالفات";


            dgvViolationsData.Columns[0].Width = 50;
            dgvViolationsData.Columns[1].Width = 250;
            dgvViolationsData.Columns[2].Width = 170;
            dgvViolationsData.Columns[3].Width = 160;
            dgvViolationsData.Columns[4].Width = 320;
            dgvViolationsData.Columns[5].Width = 130;
        }

        void LoadAllStudentViolation()
        {
            DataTable dt = new DataTable();
            dt = clsViolation.GetAllStudentViloationsByID(_StudentID);
            if(dt.Rows.Count > 0)
            {
                dgvViolationsData.DataSource = dt;
                ChangeDataGridViewViolationHeader();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AddUserControlToPanel.ShowUserControl(UCReport);
        }

        private void btnExpertToPDF_Click(object sender, EventArgs e)
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
                    PdfPTable pdfTable = new PdfPTable(dgvViolationsData.Columns.Count);
                    pdfTable.WidthPercentage = 100;

                    // إضافة العناوين
                    foreach (DataGridViewColumn column in dgvViolationsData.Columns)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                        cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                        pdfTable.AddCell(cell);
                    }

                    // إضافة الصفوف
                    foreach (DataGridViewRow row in dgvViolationsData.Rows)
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
