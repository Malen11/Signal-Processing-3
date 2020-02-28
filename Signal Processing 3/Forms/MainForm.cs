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

namespace Signal_Processing_3
{
    public partial class MainForm : Form
    {
        private DataSet dataSet;

        /// <summary>
        /// Конструктор
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            dataSet = null;

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
                    String filePath = openFileDialog.FileName;
                    DataType type;

                    var button = (Button)sender;
                    switch (button.Name)
                    {
                        case "selectTestFileButton":
                            //writeFile();
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

                    var fileData = DataReader.GetDataFromFile(filePath, type);

                    header = fileData.header;
                    data = fileData.data;

                    fileNameLabel.Text = filePath;

                    MessageBox.Show("Данные успешно загружены", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                data = null;
                header = null;
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
                if (data == null)
                {
                    throw new NullReferenceException("Данные не были загруженны!");
                }

                var form = new ShowChartForm(data, header.filePath.Split('/').Last(), header.type, header);
                form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void showAmplitudeSpectrumButton_Click(object sender, EventArgs e)
        //{
        //    Stopwatch watch = new Stopwatch();

        //    try
        //    {
        //        int N = data.Count();

        //        double powerD = Math.Log(N, 2.0);

        //        int power, M, err;

        //        power = (int)powerD;

        //        double[] resizedData = ResizeData(data, (int)(Math.Pow(2, power)));

        //        (double Re, double Im)[] exponentData = resizedData.Select(x => (x, 0.0)).ToArray();

        //        watch.Start();
        //        double[] coef0 = Walsh.Transform(resizedData);
        //        double[] amplSpec0 = Walsh.AmplitudeSpectrum(coef0);
        //        watch.Stop();
        //        var form0 = new showSpectrumForm(amplSpec0, "Амплитудный спектр Уолш", SpectrumType.Amplitude, amplSpec0.Length, watch.ElapsedMilliseconds);
        //        form0.Show();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //private void showPhaseSpectrumButton_Click(object sender, EventArgs e)
        //{
        //    Stopwatch watch = new Stopwatch();

        //    try
        //    {
        //        int N = data.Count();

        //        double powerD = Math.Log(N, 2.0);

        //        int power;

        //        power = (int)powerD;

        //        double[] resizedData = ResizeData(data, (int)(Math.Pow(2, power)));

        //        (double Re, double Im)[] exponentData = resizedData.Select(x => (x, 0.0)).ToArray();

        //        watch.Start();
        //        double[] coef0 = Walsh.Transform(resizedData);
        //        double[] phaseSpec0 = Walsh.PhaseSpectrum(coef0);
        //        watch.Stop();
        //        var form0 = new showSpectrumForm(phaseSpec0, "Фазовый спектр Уолш", SpectrumType.Phase, phaseSpec0.Length, watch.ElapsedMilliseconds);
        //        form0.Show();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        /// <summary>
        /// Обработчик нажатия кнопки "Амплитудный спектр (БПФ)"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showAmplitudeSpectrumFFTButton_Click(object sender, EventArgs e)
        {
            Stopwatch watch = new Stopwatch();

            try
            {
                double powerD = Math.Log(data.Count(), 2);
                int power = (int)Math.Round(powerD);
                int newSize = (int)Math.Pow(2, power);

                double[] resizedData = Utils.ResizeData<double>(data, newSize);

                watch.Start();
                (double Ak, double Bk)[] coef0 = FourierTransform.FastFourierTransform(resizedData).Select(x => (2 * x.Re, 2 * x.Im)).ToArray();
                double[] amplSpec0 = FourierTransform.AmplitudeSpectrum(coef0);
                watch.Stop();

                var form0 = new showSpectrumForm(amplSpec0, "Амплитудный спектр БПФ", SpectrumType.Amplitude, ((WAVHeader)header).sampleRate, watch.ElapsedMilliseconds);
                form0.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void showAmplitudeSpectrumFTSButton_Click(object sender, EventArgs e)
        //{
        //    Stopwatch watch = new Stopwatch();

        //    try
        //    {
        //        int N = data.Count();

        //        double powerD = Math.Log(N, 2.0);

        //        int power, M, err;

        //        power = 1;
        //        M = 1;
        //        err = (int)(N - Math.Pow(2, power) * M);

        //        for (int selectedPower = 1, selectedM = 1, selectedErr = 0; Math.Pow(2, selectedPower) < N / 2; selectedPower++)
        //        {
        //            selectedM = (int)Math.Round((double)N / Math.Pow(2, selectedPower));
        //            selectedErr = (int)(N - Math.Pow(2, selectedPower) * selectedM);
        //            if (Math.Abs(selectedErr) <= Math.Abs(err) && selectedM < Math.Pow(2, selectedPower))
        //            {
        //                M = selectedM;
        //                power = selectedPower;
        //                err = selectedErr;
        //            }
        //        }

        //        double[] resizedData = ResizeData(data, (int)(Math.Pow(2, power) * M));

        //        (double Re, double Im)[] exponentData = resizedData.Select(x => (x, 0.0)).ToArray();

        //        watch.Start();
        //        (double Ak, double Bk)[] coef0 = FourierTransform.FourierTransformSpeed(exponentData).Select(x => (2 * x.Re, 2 * x.Im)).ToArray();
        //        double[] amplSpec0 = FourierTransform.AmplitudeSpectrum(coef0);
        //        watch.Stop();
        //        var form0 = new showSpectrumForm(amplSpec0, "Амплитудный спектр ДПФу", SpectrumType.Amplitude, 360, watch.ElapsedMilliseconds);
        //        form0.Show();

        //        watch.Start();
        //        (double Ak, double Bk)[] coef1 = FourierTransform.FourierTransformCoefficient(resizedData);
        //        double[] amplSpec1 = FourierTransform.AmplitudeSpectrum(coef1);
        //        watch.Stop();
        //        var form1 = new showSpectrumForm(amplSpec1, "Амплитудный спектр ДПФ", SpectrumType.Amplitude, 360, watch.ElapsedMilliseconds);
        //        form1.Show();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        /// <summary>
        /// Обработчик нажатия кнопки "Фильтрация"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void filterButton_Click(object sender, EventArgs e)
        {
            try
            {
                double powerD = Math.Log(data.Count(), 2);
                int power = (int)Math.Round(powerD);
                int newSize = (int)Math.Pow(2, power);

                double[] resizedData = Utils.ResizeData<double>(data, newSize);

                if (header.type == DataType.Audio)
                {
                    var form = new FilterForm(resizedData, header.filePath, header.type, header);
                    form.ShowDialog();
                }
                else
                {
                    var form = new FilterForm(resizedData, header.filePath, header.type);
                    form.ShowDialog();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
