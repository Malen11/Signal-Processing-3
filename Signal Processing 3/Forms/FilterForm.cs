using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Signal_Processing_3
{
    public partial class FilterForm : Form
    {
        private double[] data;
        private DataHeader header;
        private string name;
        private DataType type;

        public FilterForm(double[] data, string name, DataType type, DataHeader header)
        {
            InitializeComponent();

            this.data = data;
            this.name = name;
            this.type = type;
            this.header = header;

            notchNumericUpDown0.Minimum = notchNumericUpDown1.Minimum = bPFilterNnumericUpDown0.Minimum = 
                bPFilterNumericUpDown1.Minimum = hPFilterNumericUpDown.Minimum = lPFilterNumericUpDown.Minimum = 0;
            notchNumericUpDown0.Maximum = notchNumericUpDown1.Maximum = bPFilterNnumericUpDown0.Maximum = 
                bPFilterNumericUpDown1.Maximum = hPFilterNumericUpDown.Maximum = lPFilterNumericUpDown.Maximum = data.Length / 2;

            notchComboBox.SelectedIndex = bPFilterComboBox.SelectedIndex = hPFilterComboBox.SelectedIndex = lPFilterComboBox.SelectedIndex = 0;
        }

        private void lPFilterButton_Click(object sender, EventArgs e)
        {
            int threshold = (int)lPFilterNumericUpDown.Value;
            if(lPFilterComboBox.Text == "Гц")
            {
                threshold = (int)(threshold / (360.0 / data.Count()));
            }

            var filteredData = FourierTransform.LPFilter(data, threshold);

            var form = new ShowChartForm(filteredData, name + " НЧ фильтр", type);
            form.Show();
        }

        private void hPFilterButton_Click(object sender, EventArgs e)
        {
            int threshold = (int)hPFilterNumericUpDown.Value;
            if (hPFilterComboBox.Text == "Гц")
            {
                threshold = (int)(threshold / (360.0 / data.Count()));
            }

            var filteredData = FourierTransform.HPFilter(data, threshold);

            var form = new ShowChartForm(filteredData, name + " ВЧ фильтр", type);
            form.Show();
        }

        private void bPFilterButton_Click(object sender, EventArgs e)
        {
            int threshold0 = (int)bPFilterNnumericUpDown0.Value;
            int threshold1 = (int)bPFilterNumericUpDown1.Value;

            if (bPFilterComboBox.Text == "Гц")
            {
                threshold0 = (int)(threshold0 / (Hz / data.Count()));
                threshold1 = (int)(threshold1 / (Hz / data.Count()));
            }

            var filteredData = FourierTransform.BPFilter(data, threshold0, threshold1);

            var form = new ShowChartForm(filteredData, name + " полосовой фильтр", type);
            form.Show();
        }

        private void notchFilterButton_Click(object sender, EventArgs e)
        {
            int threshold0 = (int)notchNumericUpDown0.Value;
            int threshold1 = (int)notchNumericUpDown1.Value;

            if (notchComboBox.Text == "Гц")
            {
                threshold0 = (int)(threshold0 / (Hz / data.Count()));
                threshold1 = (int)(threshold1 / (Hz / data.Count()));
            }

            var filteredData = FourierTransform.NotchFilter(data, threshold0, threshold1);

            var form = new ShowChartForm(filteredData, name + " режекторный фильтр", type);
            form.Show();
        }
    }
}
