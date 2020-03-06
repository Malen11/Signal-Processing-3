using Signal_Processing_3.Filters;
using Signal_Processing_3.Signals;
using Signal_Processing_3.Signals.Readers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Signal_Processing_3.Forms
{
    public partial class MainForm : Form
    {
        private SimpleSignal signal;
        private string filePath;

        /// <summary>
        /// Конструктор
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            signal = null;
            filePath = null;

            fileNameLabel.Text = "Файл не выбран";
        }

        /// <summary>
        /// Выбрать файл
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void selectFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    DataType type;

                    var button = (Button)sender;
                    switch (button.Name)
                    {
                        case "selectFileButton":
                            type = DataType.Test;
                            break;

                        case "selectCardioFileButton":
                            type = DataType.Cardio;
                            break;

                        case "selectReoFileButton":
                            type = DataType.Reo;
                            break;

                        case "selectVeloFileButton":
                            type = DataType.Velo;
                            break;

                        case "selectSpiroFileButton":
                            type = DataType.Spiro;
                            break;

                        case "selectAudioFileButton":
                            type = DataType.Audio;
                            break;

                        default:
                            throw new ArgumentException("Необрабатываемое нажатие клавиши");
                    }

                    SignalReader signalReader = new SignalReader();

                    if(type == DataType.Audio)
                    {
                        signal = signalReader.ReadAudioSignalFromFile(filePath);
                    }
                    else
                    {
                        signal = signalReader.ReadSimpleSignalFromFile(filePath, type, 360.0);
                    }

                    fileNameLabel.Text = filePath;

                    MessageBox.Show("Данные успешно загружены", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                signal = null;
                filePath = null;
                fileNameLabel.Text = "Файл не загружен";

                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Построить по данным график и показать его
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showBaseSignalButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (signal == null)
                {
                    throw new NullReferenceException("Данные не были загруженны!");
                }

                ShowChartForm form = new ShowChartForm(signal.Data, filePath.Split('/').Last(), signal.Type, signal.Hz);

                form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Амплитудный спектр (БПФ)"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showAmplitudeSpectrumButton_Click(object sender, EventArgs e)
        {
            Stopwatch watch = new Stopwatch();

            try
            {
                FilterType type;
                double[] preparedData;
                string label; 

                var button = (Button)sender;
                switch (button.Name)
                {
                    case "showAmplitudeSpectrumBFTButton":
                        type = FilterType.FourierBase;
                        label = "Амплитудный спектр ПФ";
                        break;

                    case "showAmplitudeSpectrumFFTButton":
                        type = FilterType.FourierFast;
                        label = "Амплитудный спектр БПФ";
                        break;

                    case "showAmplitudeSpectrumFTSButton":
                        type = FilterType.FourierSpeed;
                        label = "Амплитудный спектр ПФУ";
                        break;

                    default:
                        throw new ArgumentException();
                }

                preparedData = FiltersUtils.PrepareDataToFilter(signal.Data, type);

                watch.Start();
                double[] amplSpec = FourierTransform.AmplitudeSpectrum(preparedData, type);
                watch.Stop();

                var form0 = new showSpectrumForm(amplSpec, label, SpectrumType.Amplitude, signal.Hz, watch.ElapsedMilliseconds);
                form0.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Фильтрация"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void filterButton_Click(object sender, EventArgs e)
        {
            try
            {
                var form = new FilterForm(signal, filePath);
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
