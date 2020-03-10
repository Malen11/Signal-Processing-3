using Signal_Processing_3.Filters;
using Signal_Processing_3.Signals;
using Signal_Processing_3.Signals.Writers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Signal_Processing_3.Forms
{
    public partial class FirFilterForm : Form
    {
        private SimpleSignal signal;
        private string filePath;

        public FirFilterForm(SimpleSignal signal, string filePath)
        {
            InitializeComponent();

            this.signal = signal;
            this.filePath = filePath;

            filePathTextBox.Text = filePath;

            notchNumericUpDown0.Minimum = notchNumericUpDown1.Minimum = bPFilterNnumericUpDown0.Minimum =
                bPFilterNumericUpDown1.Minimum =
                hPImpulceCharacteristicThresholdNumericUpDown.Minimum = hPImpulceCharacteristicNNumericUpDown.Minimum =
                lPImpulceCharacteristicThresholdNumericUpDown.Minimum = lPImpulceCharacteristicNNumericUpDown.Minimum =
                impulceCharacteristicThresholdNumericUpDown.Minimum = impulceCharacteristicNNumericUpDown.Minimum = 0;
            notchNumericUpDown0.Maximum = notchNumericUpDown1.Maximum = bPFilterNnumericUpDown0.Maximum =
                bPFilterNumericUpDown1.Maximum =
                hPImpulceCharacteristicThresholdNumericUpDown.Maximum = hPImpulceCharacteristicNNumericUpDown.Maximum =
                lPImpulceCharacteristicThresholdNumericUpDown.Maximum = lPImpulceCharacteristicNNumericUpDown.Maximum =
                impulceCharacteristicThresholdNumericUpDown.Maximum = impulceCharacteristicNNumericUpDown.Maximum = signal.Data.Length / 2;

            notchComboBox.SelectedIndex = bPFilterComboBox.SelectedIndex = 0;
        }

        private void lPFilterButton_Click(object sender, EventArgs e)
        {
            try
            {
                int n = (int)lPImpulceCharacteristicNNumericUpDown.Value;
                double threshold = (double)lPImpulceCharacteristicThresholdNumericUpDown.Value;
                double[] filteredData = FiniteImpulseResponse.lPFirFilter(signal.Data, threshold, signal.Hz, n);

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
                int n = (int)hPImpulceCharacteristicNNumericUpDown.Value;
                double threshold = (double)hPImpulceCharacteristicThresholdNumericUpDown.Value;
                double[] filteredData = FiniteImpulseResponse.hPFirFilter(signal.Data, threshold, signal.Hz, n);

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

        private void showImpulceCharacteristicButton_Click(object sender, EventArgs e)
        {
            try
            {
                int n = (int)impulceCharacteristicNNumericUpDown.Value;
                double threshold = (double)impulceCharacteristicThresholdNumericUpDown.Value;
                double[] h = FiniteImpulseResponse.ImpulseCharacteristic(threshold, signal.Hz, n);

                var form = new ShowSpectrumForm(h, " Импульсная характеристика", SpectrumType.NotSet, n);
                form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showFrequencyResponseButton_Click(object sender, EventArgs e)
        {
            Stopwatch watch = new Stopwatch();

            try
            {
                int n = (int)impulceCharacteristicNNumericUpDown.Value;
                double threshold = (double)impulceCharacteristicThresholdNumericUpDown.Value;

                watch.Start();
                double[] h = FiniteImpulseResponse.ImpulseCharacteristic(threshold, signal.Hz, n);
                double[] amplSpec = FiniteImpulseResponse.FrequencyResponse(h, signal.Hz);
                watch.Stop();

                var form = new ShowSpectrumForm(amplSpec, "АЧX", SpectrumType.Amplitude, signal.Hz, watch.ElapsedMilliseconds);
                form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showPhaseResponseButton_Click(object sender, EventArgs e)
        {
            Stopwatch watch = new Stopwatch();

            try
            {
                int n = (int)impulceCharacteristicNNumericUpDown.Value;
                double threshold = (double)impulceCharacteristicThresholdNumericUpDown.Value;

                watch.Start();
                double[] h = FiniteImpulseResponse.ImpulseCharacteristic(threshold, signal.Hz, n);
                double[] phaseSpec = FiniteImpulseResponse.PhaseResponse(h, signal.Hz);
                watch.Stop();

                var form = new ShowSpectrumForm(phaseSpec, "ФЧX", SpectrumType.Phase, signal.Hz, watch.ElapsedMilliseconds);
                form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showFrequencyResponseDButton_Click(object sender, EventArgs e)
        {
            Stopwatch watch = new Stopwatch();

            try
            {
                int n = (int)impulceCharacteristicNNumericUpDown.Value;
                double threshold = (double)impulceCharacteristicThresholdNumericUpDown.Value;

                watch.Start();
                double[] h = FiniteImpulseResponse.ImpulseCharacteristic(threshold, signal.Hz, n);
                double[] amplSpec = FiniteImpulseResponse.FrequencyResponse(h, signal.Hz);
                watch.Stop();

                var form = new ShowSpectrumForm(amplSpec, "АЧX", SpectrumType.AmplitudeDecibels, signal.Hz, watch.ElapsedMilliseconds);
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
