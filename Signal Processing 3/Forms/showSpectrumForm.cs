﻿using System;
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
    public partial class showSpectrumForm : Form
    {
        double[] data;
        SpectrumType type;
        double Hz;

        public showSpectrumForm(double[] data, string name, SpectrumType type, double Hz, long execTime = 0)
        {
            InitializeComponent();

            this.Text = name;
            this.data = data;
            this.type = type;
            this.Hz = Hz;

            dataChart.ChartAreas[0].AxisX.Title = "Гц";
            if (execTime == 0)
            {
                execTimeLabel.Visible = false;
                execTimeTextBox.Visible = false;
            }
            else
            {
                execTimeTextBox.Text = execTime.ToString();
            }

            minNumericUpDown.Minimum = minNumericUpDown.Minimum = 0;
            maxNumericUpDown.Maximum = maxNumericUpDown.Maximum = (int)Hz;

            minNumericUpDown.Value = 0;
            maxNumericUpDown.Value = (int)Hz;

            dataChart.ChartAreas[0].AxisX.Interval = 10;

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

            double h = (double)Hz / data.Length;

            //оффициальный костыль майкрософт!
            dataChart.Series[0].Points.SuspendUpdates();
            while (dataChart.Series[0].Points.Count > 0)
            {
                dataChart.Series[0].Points.RemoveAt(dataChart.Series[0].Points.Count - 1);
            }
            dataChart.Series[0].Points.ResumeUpdates();

            dataChart.ChartAreas[0].AxisX.Minimum = min;
            dataChart.ChartAreas[0].AxisX.Maximum = max;
            dataChart.ChartAreas[0].AxisX.IntervalOffset = (dataChart.ChartAreas[0].AxisX.Interval - min) % dataChart.ChartAreas[0].AxisX.Interval;
            dataChart.ChartAreas[0].AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;

            for (int i = (int)(min / h); i < (int)(max / h); i++)
            {
                dataChart.Series[0].Points.AddXY(i * h, data[i]);
            }
        }
    }
}
