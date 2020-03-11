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

            var ImpulseCharacteristicTypeValues = Enum.GetValues(typeof(FirFilterType)).Cast<FirFilterType>().ToList();
            
            foreach (var type in ImpulseCharacteristicTypeValues)
            {
                impulseCharacteristicTypeComboBox.Items.Add(type.ToString());
            }

            notchImpulceCharacteristicThreshold0NumericUpDown.Minimum = notchImpulceCharacteristicThreshold1NumericUpDown.Minimum = bPImpulceCharacteristicThreshold0NumericUpDown.Minimum =
                bPImpulceCharacteristicThreshold1NumericUpDown.Minimum =
                hPImpulceCharacteristicThresholdNumericUpDown.Minimum = hPImpulceCharacteristicNNumericUpDown.Minimum =
                lPImpulceCharacteristicThresholdNumericUpDown.Minimum = lPImpulceCharacteristicNNumericUpDown.Minimum =
                impulceCharacteristicThresholdNumericUpDown.Minimum = impulceCharacteristicNNumericUpDown.Minimum = 0;
            notchImpulceCharacteristicThreshold0NumericUpDown.Maximum = notchImpulceCharacteristicThreshold1NumericUpDown.Maximum = bPImpulceCharacteristicThreshold0NumericUpDown.Maximum =
                bPImpulceCharacteristicThreshold1NumericUpDown.Maximum =
                hPImpulceCharacteristicThresholdNumericUpDown.Maximum = hPImpulceCharacteristicNNumericUpDown.Maximum =
                lPImpulceCharacteristicThresholdNumericUpDown.Maximum = lPImpulceCharacteristicNNumericUpDown.Maximum =
                impulceCharacteristicThresholdNumericUpDown.Maximum = impulceCharacteristicNNumericUpDown.Maximum = signal.Data.Length / 2;
        }

        private void showImpulceCharacteristicButton_Click(object sender, EventArgs e)
        {
            try
            {
                int n = (int)impulceCharacteristicNNumericUpDown.Value;
                double threshold = (double)impulceCharacteristicThresholdNumericUpDown.Value;
                var windowType = GetFourierTransformType(); 
                var impCharType = (FirFilterType)Enum.Parse(typeof(FirFilterType), (string)impulseCharacteristicTypeComboBox.SelectedItem);

                double[] h = FiniteImpulseResponse.ImpulseCharacteristic(signal.Hz, n, threshold, impCharType, windowType);

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
                var windowType = GetFourierTransformType();
                var impCharType = (FirFilterType)Enum.Parse(typeof(FirFilterType), (string)impulseCharacteristicTypeComboBox.SelectedItem);
                
                watch.Start();
                double[] h = FiniteImpulseResponse.ImpulseCharacteristic(signal.Hz, n, threshold, impCharType, windowType);
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

        private void showFrequencyResponseDButton_Click(object sender, EventArgs e)
        {
            Stopwatch watch = new Stopwatch();

            try
            {
                int n = (int)impulceCharacteristicNNumericUpDown.Value;
                double threshold = (double)impulceCharacteristicThresholdNumericUpDown.Value;
                var windowType = GetFourierTransformType();
                var impCharType = (FirFilterType)Enum.Parse(typeof(FirFilterType), (string)impulseCharacteristicTypeComboBox.SelectedItem);
                
                watch.Start();
                double[] h = FiniteImpulseResponse.ImpulseCharacteristic(signal.Hz, n, threshold, impCharType, windowType);
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

        private void showPhaseResponseButton_Click(object sender, EventArgs e)
        {
            Stopwatch watch = new Stopwatch();

            try
            {
                var impCharType = (FirFilterType)Enum.Parse(typeof(FirFilterType), (string)impulseCharacteristicTypeComboBox.SelectedItem);
                int n = (int)impulceCharacteristicNNumericUpDown.Value;
                double threshold = (double)impulceCharacteristicThresholdNumericUpDown.Value;

                watch.Start();
                double[] h = FiniteImpulseResponse.ImpulseCharacteristic(signal.Hz, n, threshold, impCharType);
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

        private void lPFilterButton_Click(object sender, EventArgs e)
        {
            try
            {
                var windowType = GetFourierTransformType();
                int n = (int)lPImpulceCharacteristicNNumericUpDown.Value;
                double threshold = (double)lPImpulceCharacteristicThresholdNumericUpDown.Value;

                double[] filteredData = FiniteImpulseResponse.FirFilter(signal.Data, signal.Hz, n, threshold, FirFilterType.LowPass, windowType);

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

                double[] filteredData = FiniteImpulseResponse.FirFilter(signal.Data, signal.Hz, n, threshold, FirFilterType.HighPass);

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
                int n = (int)bPImpulceCharacteristicNNumericUpDown.Value;
                double threshold0 = (double)bPImpulceCharacteristicThreshold0NumericUpDown.Value;
                double threshold1 = (double)bPImpulceCharacteristicThreshold1NumericUpDown.Value;

                double[] filteredData = FiniteImpulseResponse.FirFilter(signal.Data, signal.Hz, n, threshold0, threshold1, FirFilterType.BandPass);

                if (saveToFileCheckBox.Checked)
                {
                    WriteDataToFile(filteredData);
                }

                var form = new ShowChartForm(filteredData, filePath + "Полосовый фильтр", signal.Type, signal.Hz);
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
                int n = (int)notchImpulceCharacteristicNNumericUpDown.Value;
                double threshold0 = (double)notchImpulceCharacteristicThreshold0NumericUpDown.Value;
                double threshold1 = (double)notchImpulceCharacteristicThreshold1NumericUpDown.Value;

                double[] filteredData = FiniteImpulseResponse.FirFilter(signal.Data, signal.Hz, n, threshold0, threshold1, FirFilterType.NotchPass);

                if (saveToFileCheckBox.Checked)
                {
                    WriteDataToFile(filteredData);
                }

                var form = new ShowChartForm(filteredData, filePath + "Режекторный фильтр", signal.Type, signal.Hz);
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

        private FirWindowType GetFourierTransformType()
        {
            if (rectangleWindowRadioButton.Checked)
            {
                return FirWindowType.Rectangle;
            }
            else if (hammingWindowRadioButton.Checked)
            {
                return FirWindowType.Hamming;
            }
            else if (bartlettWindowRadioButton.Checked)
            {
                return FirWindowType.Bartlett;
            }
            else if (hanningWindowRadioButton.Checked)
            {
                return FirWindowType.Hanning;
            }
            else if (blackmanWindowRadioButton.Checked)
            {
                return FirWindowType.Blackman;
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
}
