using Signal_Processing_3.Signals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Signal_Processing_3.Forms
{
    public partial class ShowChartForm : Form
    {
        double[] data;
        DataType type;
        double step;

        public ShowChartForm(double[] data, string name, DataType type, double Hz)
        {
            InitializeComponent();

            this.Text = name;
            this.data = data;
            this.type = type;

            switch (type)
            {
                case DataType.Test:
                    SetTestChartParams(Hz);
                    break;

                case DataType.Cardio:
                    SetCardioChartParams(Hz);
                    break;

                case DataType.Reo:
                    SetReoChartParams(Hz);
                    break;

                case DataType.Velo:
                    SetVeloChartParams(Hz);
                    break;

                case DataType.Spiro:
                    SetSpiroChartParams(Hz);
                    break;

                case DataType.Audio:
                    SetAudioChartParams(Hz);
                    break;

                default:
                    throw new ArgumentException("Неожиданный тип данных");
            }

            dataChart.ChartAreas[0].AxisX.Interval = 0.5;
            //dataChart.ChartAreas[0].AxisX.IntervalOffset = - dataChart.ChartAreas[0].AxisX.Minimum;

            minNumericUpDown.Minimum = 0;
            minNumericUpDown.Maximum = data.Length;

            maxNumericUpDown.Minimum = 0;
            maxNumericUpDown.Maximum = data.Length;

            minNumericUpDown.Value = 0;
            maxNumericUpDown.Value = data.Length;

            minValueLabel.Text = "Минимальное значение ";
            maxValueLabel.Text = "Максимальное значение ";

            DrawChart();
        }

        private void changeIntervalButton_Click(object sender, EventArgs e)
        {
            DrawChart();
        }

        private void DrawChart()
        {
            int min = (int)minNumericUpDown.Value;
            int max = (int)maxNumericUpDown.Value;

            //оффициальный костыль майкрософт!
            dataChart.Series[0].Points.SuspendUpdates();
            while (dataChart.Series[0].Points.Count > 0)
            {
                dataChart.Series[0].Points.RemoveAt(dataChart.Series[0].Points.Count - 1);
            }
            dataChart.Series[0].Points.ResumeUpdates();
            dataChart.ChartAreas[0].AxisX.Minimum = min * step;
            dataChart.ChartAreas[0].AxisX.Maximum = max * step;

            for (int i = min; i < max; i++)
            {
                dataChart.Series[0].Points.AddXY(i * step, data[i]);
            }
        }

        private void SetTestChartParams(double Hz)
        {
            step = 1.0 / Hz;

            dataChart.ChartAreas[0].AxisX.Title = "cек";
            dataChart.ChartAreas[0].AxisX.Minimum = 0;
            dataChart.ChartAreas[0].AxisX.Maximum = 2.0;
        }

        private void SetCardioChartParams(double Hz)
        {
            step = 1.0 / Hz;

            dataChart.ChartAreas[0].AxisX.Title = "cек";
            dataChart.ChartAreas[0].AxisX.Minimum = 0;

            dataChart.ChartAreas[0].AxisY.Title = "мВ";
            //dataChart.ChartAreas[0].AxisY.Minimum = Math.Round((data.Min() - 127) / 60.0, MidpointRounding.AwayFromZero) - 0.5;
            //dataChart.ChartAreas[0].AxisY.Maximum = Math.Round((data.Max() - 127) / 60.0, MidpointRounding.AwayFromZero) + 0.5;
        }

        private void SetReoChartParams(double Hz)
        {
            step = 1.0 / Hz;

            dataChart.ChartAreas[0].AxisX.Title = "cек";
            dataChart.ChartAreas[0].AxisX.Minimum = 0;

            dataChart.ChartAreas[0].AxisY.Title = "мОм";
        }

        private void SetVeloChartParams(double Hz)
        {
            step = 1.0 / Hz;

            dataChart.ChartAreas[0].AxisX.Title = "cек";
            dataChart.ChartAreas[0].AxisX.Minimum = 0;

            dataChart.ChartAreas[0].AxisY.Title = "мВ";
        }

        private void SetSpiroChartParams(double Hz)
        {
            step = 1.0 / Hz;

            dataChart.ChartAreas[0].AxisX.Title = "cек";
            dataChart.ChartAreas[0].AxisX.Minimum = 0;

            dataChart.ChartAreas[0].AxisY.Title = "Л";
        }

        private void SetAmplitudeChartParams(double Hz)
        {
            step = 1.0 / Hz;

            dataChart.ChartAreas[0].AxisX.Title = "Номера отсчётов";
            dataChart.ChartAreas[0].AxisX.Minimum = 0;
        }

        private void SetAudioChartParams(double Hz)
        {
            step = 1.0 / Hz;

            dataChart.ChartAreas[0].AxisX.Title = "Сек";
        }
    }
}
