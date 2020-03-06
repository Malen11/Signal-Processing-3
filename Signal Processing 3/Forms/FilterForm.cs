using Signal_Processing_3.Filters;
using Signal_Processing_3.Signals;
using Signal_Processing_3.Signals.Writers;
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
    public partial class FilterForm : Form
    {
        private SimpleSignal signal;
        private string filePath;

        public FilterForm(SimpleSignal signal, string filePath)
        {
            InitializeComponent();

            this.signal = signal;
            this.filePath = filePath;

            filePathTextBox.Text = filePath;

            notchNumericUpDown0.Minimum = notchNumericUpDown1.Minimum = bPFilterNnumericUpDown0.Minimum =
                bPFilterNumericUpDown1.Minimum = hPFilterNumericUpDown.Minimum = lPFilterNumericUpDown.Minimum = 0;
            notchNumericUpDown0.Maximum = notchNumericUpDown1.Maximum = bPFilterNnumericUpDown0.Maximum =
                bPFilterNumericUpDown1.Maximum = hPFilterNumericUpDown.Maximum = lPFilterNumericUpDown.Maximum = signal.Data.Length / 2;

            notchComboBox.SelectedIndex = bPFilterComboBox.SelectedIndex = hPFilterComboBox.SelectedIndex = lPFilterComboBox.SelectedIndex = 0;
        }

        private void lPFilterButton_Click(object sender, EventArgs e)
        {
            try
            {
                int threshold = (int)lPFilterNumericUpDown.Value;
                if (lPFilterComboBox.Text == "Гц")
                {
                    threshold = (int)(threshold / (signal.Hz / signal.Data.Count()));
                }

                FilterType type = GetFourierTransformType();
                double[] preparedData = FiltersUtils.PrepareDataToFilter(signal.Data, type);

                double[] filteredData = FourierTransform.LPFilter(preparedData, threshold, type);

                if (saveToFileCheckBox.Checked)
                {
                    WriteDataToFile(filteredData);
                }

                var form = new ShowChartForm(filteredData, filePath + " НЧ фильтр", signal.Type, signal.Hz);
                form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void hPFilterButton_Click(object sender, EventArgs e)
        {
            try
            {
                int threshold = (int)hPFilterNumericUpDown.Value;
                if (hPFilterComboBox.Text == "Гц")
                {
                    threshold = (int)(threshold / (signal.Hz / signal.Count));
                }

                FilterType type = GetFourierTransformType();
                double[] preparedData = FiltersUtils.PrepareDataToFilter(signal.Data, type);

                var filteredData = FourierTransform.HPFilter(preparedData, threshold, type);

                if (saveToFileCheckBox.Checked)
                {
                    WriteDataToFile(filteredData);
                }

                var form = new ShowChartForm(filteredData, filePath + " ВЧ фильтр", signal.Type, signal.Hz);
                form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bPFilterButton_Click(object sender, EventArgs e)
        {
            try
            {
                int threshold0 = (int)bPFilterNnumericUpDown0.Value;
                int threshold1 = (int)bPFilterNumericUpDown1.Value;

                if (bPFilterComboBox.Text == "Гц")
                {
                    threshold0 = (int)(threshold0 / (signal.Hz / signal.Count));
                    threshold1 = (int)(threshold1 / (signal.Hz / signal.Count));
                }

                FilterType type = GetFourierTransformType();
                double[] preparedData = FiltersUtils.PrepareDataToFilter(signal.Data, type);

                var filteredData = FourierTransform.BPFilter(preparedData, threshold0, threshold1, type);

                if (saveToFileCheckBox.Checked)
                {
                    WriteDataToFile(filteredData);
                }

                var form = new ShowChartForm(filteredData, filePath + " полосовой фильтр", signal.Type, signal.Hz);
                form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void notchFilterButton_Click(object sender, EventArgs e)
        {
            try
            {
                int threshold0 = (int)notchNumericUpDown0.Value;
                int threshold1 = (int)notchNumericUpDown1.Value;

                if (notchComboBox.Text == "Гц")
                {
                    threshold0 = (int)(threshold0 / (signal.Hz / signal.Count));
                    threshold1 = (int)(threshold1 / (signal.Hz / signal.Count));
                }

                FilterType type = GetFourierTransformType();
                double[] preparedData = FiltersUtils.PrepareDataToFilter(signal.Data, type);

                var filteredData = FourierTransform.NotchFilter(preparedData, threshold0, threshold1, type);

                if (saveToFileCheckBox.Checked)
                {
                    WriteDataToFile(filteredData);
                }

                var form = new ShowChartForm(filteredData, filePath + " режекторный фильтр", signal.Type, signal.Hz);
                form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveToFileCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked)
            {
                filePathTextBox.Enabled = true;
            }
            else
            {
                filePathTextBox.Enabled = false;
            }
        }

        private FilterType GetFourierTransformType()
        {
            if (bFTRadioButton.Checked)
            {
                return FilterType.FourierBase;
            }
            else if (fFTRadioButton.Checked)
            {
                return FilterType.FourierFast;
            }
            else if (fTSRadioButton.Checked)
            {
                return FilterType.FourierSpeed;
            }
            else
            {
                throw new ArgumentException();
            }
        }

        private void WriteDataToFile(double[] data)
        {
            if (signal is AudioSignal)
            {
                AudioSignal filteredSignal = new AudioSignal(((AudioSignal)signal).AudioProperties, data);
                SignalsWriter signalsWriter = new SignalsWriter();
                signalsWriter.WriteAudioSignalToFile(filteredSignal, filePathTextBox.Text);
            }
        }
    }
}
