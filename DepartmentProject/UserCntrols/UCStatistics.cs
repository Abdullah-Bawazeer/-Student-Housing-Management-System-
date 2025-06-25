using DepartmentBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace DepartmentProject
{
    public partial class UCStatistics : UserControl
    {

        public UCStatistics()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }


        void FailChartinByStatisticData()
        {
            DataTable dt = new DataTable();
            dt = clsStatisticBusiness.GetStatisticData();
         
                 Chart chart = new Chart();
                chart.Dock = DockStyle.Fill;
                this.Controls.Add(chart);

                ChartArea chartArea = new ChartArea();
                chart.ChartAreas.Add(chartArea);

                Series series = new Series
                {
                    ChartType = SeriesChartType.Column,  // تغيير نوع المخطط إلى أعمدة
                    IsValueShownAsLabel = true
                };

                //إضافة بيانات المخالفات
                // إضافة البيانات إلى المخطط البياني
                foreach (DataRow row in dt.Rows)
                {
                    series.Points.AddXY(row["Name"], row["Percentage"]);
                }

            // تحسينات التصميم
            series.Color = System.Drawing.Color.CornflowerBlue;
                series.Palette = ChartColorPalette.BrightPastel;

                chart.Series.Add(series);

                // إضافة عنوان جذاب
                Title title = new Title
                {
                    Text = "إحصائيات المخالفات",
                    Font = new System.Drawing.Font("Arial", 16, System.Drawing.FontStyle.Bold),
                    ForeColor = System.Drawing.Color.DarkBlue
                };
                chart.Titles.Add(title);
        }

        private void Create3DChart()
        {
            DataTable dt = new DataTable();
            dt = clsStatisticBusiness.GetStatisticData();

            // إنشاء المخطط
            Chart chart = new Chart
            {
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(220, 250, 240)  // خلفية داكنة أنيقة
            };
            this.Controls.Add(chart);

            // إعداد منطقة المخطط
            ChartArea chartArea = new ChartArea
            {
                BackColor = Color.Transparent,
                Area3DStyle = new ChartArea3DStyle
                {
                    Enable3D = true,         // تفعيل 3D
                    Inclination = 30,        // ميلان الزاوية
                    Rotation = 25,           // دوران المحور
                    LightStyle = LightStyle.Realistic,  // تأثير الإضاءة
                    PointDepth = 100
                }
            };
            chart.ChartAreas.Add(chartArea);

            // إضافة البيانات
            Series series = new Series
            {
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = true,
                Font = new Font("Arial", 20, FontStyle.Bold),
                LabelForeColor = Color.Black
            };

            // بيانات المخالفات
            foreach (DataRow row in dt.Rows)
            {
                series.Points.AddXY(row["Name"], row["Percentage"]);
            }

            // تنسيق الألوان لكل عمود
            Color[] colors = { Color.Cyan, Color.Orange, Color.LimeGreen, Color.Red, Color.Purple };
            for (int i = 0; i < series.Points.Count; i++)
            {
                series.Points[i].Color = colors[i];
            }

            chart.Series.Add(series);

            // إضافة عنوان للمخطط
            Title title = new Title
            {
                Text = "إحصائيات المخالفات ",
                Font = new Font("Arial", 20, FontStyle.Bold),
                ForeColor = Color.Black
            };
            chart.Titles.Add(title);

            // تحسين المحاور
            chartArea.AxisX.LabelStyle.Font = new Font("Arial", 20, FontStyle.Bold);
            chartArea.AxisX.LabelStyle.ForeColor = Color.Black;
            chartArea.AxisY.LabelStyle.Font = new Font("Arial", 20, FontStyle.Bold);
            chartArea.AxisY.LabelStyle.ForeColor = Color.Black;

            chartArea.AxisX.MajorGrid.LineColor = Color.Black;
            chartArea.AxisY.MajorGrid.LineColor = Color.Black;
        }





        private void UCStatistics_Load(object sender, EventArgs e)
        {
            Create3DChart();
            //FailChartinByStatisticData();
        }

       
    }
}
