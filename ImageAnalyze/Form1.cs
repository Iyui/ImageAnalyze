﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;
using static ImageAnalyze.ImageProcess;
namespace ImageAnalyze
{
    public partial class Form1 : Form
    {
        #region 变量
        int[][] initRGB;
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void AnalyzeRGB(Bitmap bitmap)
        {
            initRGB = new int[5][];
            for (int i = 0; i < 5; i++)
                initRGB[i] = new int[bitmap.Height * bitmap.Width];
            int m = 0;
            for (int i = 0; i < bitmap.Height; i++)
            {
                for (int j = 0; j < bitmap.Width; j++)
                {
                    //获取当前点的Color对象
                    Color c = bitmap.GetPixel(j, i);
                    //计算转化过灰度图之后的rgb值（套用已有的计算公式）
                    int rgb = Gray(c);
                    initRGB[0][m] = m++;
                    initRGB[1][i * j] = rgb;
                    initRGB[1][i * j] = c.R;
                    initRGB[2][i * j] = c.G;
                    initRGB[3][i * j] = c.B;
                }
            }
        }

        private void InitChart()
        {
            var X = initRGB[0];
            var R = initRGB[1];
            var G = initRGB[2];
            var B = initRGB[3];

            GeneralChart(ct_InitChart, "R", X, R);
            //GeneralChart(ct_InitChart, "G", X, G);
            //GeneralChart(ct_InitChart, "B", X, B);
        }

        private void GeneralChart(Chart chart, string name, int[] x, int[] y, SeriesChartType seriesChartType = SeriesChartType.Spline)
        {
            chart.Series.Add(name);
            chart.Series[name].ChartType = seriesChartType;
            chart.Series[name].Points.DataBindXY(x, y);
            //chart.ChartAreas[0].AxisX.Enabled = AxisEnabled.True;
            //chart.ChartAreas[0].AxisX.LabelStyle.Enabled = false;
            //chart.ChartAreas[0].AxisX.MajorTickMark.Size = 0;
            chart.ChartAreas[0].AxisX.ScaleView.Size = 256;
            //chart.ChartAreas[0].AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.All;
            //chart.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;
        }

        private void btn_SelectImage_Click(object sender, EventArgs e)
        {
            ReadInitImage();
            AnalyzeRGB(image);
            //InitChart();
        }
        Bitmap image = null;
        private void ReadInitImage()
        {

            OpenFileDialog oi = new OpenFileDialog
            {
                //oi.InitialDirectory = "c:\\";
                Filter = "图片(*.jpg,*.jpeg,*.bmp) | *.jpg;*.jpeg;*.bmp| 所有文件(*.*) | *.*",
                RestoreDirectory = true,
                FilterIndex = 1
            };
            if (oi.ShowDialog() == DialogResult.OK)
            {
                var filename = oi.FileName;
                var Format = new string[] { ".jpg", ".bmp" };
                if (Format.Contains(Path.GetExtension(filename).ToLower()))
                {
                    try
                    {
                        image = (Bitmap)Image.FromFile(filename);
                        //var image1 = Image.FromFile(filename);
                        //image = new Bitmap(image1);
                        pB_Init.Image = image.Clone() as Image;
                    }
                    catch
                    {
                        MessageBox.Show("不正确的格式", "错误的预期", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btn_Threshod_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Threshoding(image);
            GC.Collect();

        }
        //反色
        private void btn_Complementary_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Complementary(image);
            GC.Collect();
        }

        private void btn_Gray_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = ImageToGrey(image);
            GC.Collect();
        }

        private void btn_Histogram_Click(object sender, EventArgs e)
        {
            if (image != null)
            {
                Histogramcs hs = new Histogramcs(image);
                hs.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            pictureBox2.Image = ImageToGrey2(image);
            GC.Collect();
        }

        private void btn_Frequency_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = Fourier.BitmapFFT(image);
        }
    }
}
