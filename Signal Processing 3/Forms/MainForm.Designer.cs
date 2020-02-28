﻿namespace Signal_Processing_3
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.selectAudioFileButton = new System.Windows.Forms.Button();
            this.selectCardioFileButton = new System.Windows.Forms.Button();
            this.selectReoFileButton = new System.Windows.Forms.Button();
            this.selectVeloFileButton = new System.Windows.Forms.Button();
            this.selectSpiroFileButton = new System.Windows.Forms.Button();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.selectFileButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.showAmplitudeSpectrumFTSButton = new System.Windows.Forms.Button();
            this.showAmplitudeSpectrumFFTButton = new System.Windows.Forms.Button();
            this.showBaseSignalButton = new System.Windows.Forms.Button();
            this.showPhaseSpectrumButton = new System.Windows.Forms.Button();
            this.filterButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.showAmplitudeSpectrumTestButton = new System.Windows.Forms.Button();
            this.maxNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.minNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.minValueLabel = new System.Windows.Forms.Label();
            this.showTestAmplitudeSpectrumButton = new System.Windows.Forms.Button();
            this.maxValueLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.selectAudioFileButton);
            this.groupBox1.Controls.Add(this.selectCardioFileButton);
            this.groupBox1.Controls.Add(this.selectReoFileButton);
            this.groupBox1.Controls.Add(this.selectVeloFileButton);
            this.groupBox1.Controls.Add(this.selectSpiroFileButton);
            this.groupBox1.Controls.Add(this.fileNameLabel);
            this.groupBox1.Controls.Add(this.selectFileButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 266);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Загрузить данные";
            // 
            // selectAudioFileButton
            // 
            this.selectAudioFileButton.Location = new System.Drawing.Point(6, 157);
            this.selectAudioFileButton.Name = "selectAudioFileButton";
            this.selectAudioFileButton.Size = new System.Drawing.Size(120, 40);
            this.selectAudioFileButton.TabIndex = 11;
            this.selectAudioFileButton.Text = "Выбрать аудиофайл...";
            this.selectAudioFileButton.UseVisualStyleBackColor = true;
            this.selectAudioFileButton.Click += new System.EventHandler(this.selectFileButton_Click);
            // 
            // selectCardioFileButton
            // 
            this.selectCardioFileButton.Location = new System.Drawing.Point(6, 65);
            this.selectCardioFileButton.Name = "selectCardioFileButton";
            this.selectCardioFileButton.Size = new System.Drawing.Size(120, 40);
            this.selectCardioFileButton.TabIndex = 7;
            this.selectCardioFileButton.Text = "Выбрать кардиофайл...";
            this.selectCardioFileButton.UseVisualStyleBackColor = true;
            this.selectCardioFileButton.Click += new System.EventHandler(this.selectFileButton_Click);
            // 
            // selectReoFileButton
            // 
            this.selectReoFileButton.Location = new System.Drawing.Point(132, 65);
            this.selectReoFileButton.Name = "selectReoFileButton";
            this.selectReoFileButton.Size = new System.Drawing.Size(120, 40);
            this.selectReoFileButton.TabIndex = 8;
            this.selectReoFileButton.Text = "Выбрать реофайл...";
            this.selectReoFileButton.UseVisualStyleBackColor = true;
            this.selectReoFileButton.Click += new System.EventHandler(this.selectFileButton_Click);
            // 
            // selectVeloFileButton
            // 
            this.selectVeloFileButton.Location = new System.Drawing.Point(6, 111);
            this.selectVeloFileButton.Name = "selectVeloFileButton";
            this.selectVeloFileButton.Size = new System.Drawing.Size(120, 40);
            this.selectVeloFileButton.TabIndex = 9;
            this.selectVeloFileButton.Text = "Выбрать велофайл...";
            this.selectVeloFileButton.UseVisualStyleBackColor = true;
            this.selectVeloFileButton.Click += new System.EventHandler(this.selectFileButton_Click);
            // 
            // selectSpiroFileButton
            // 
            this.selectSpiroFileButton.Location = new System.Drawing.Point(132, 111);
            this.selectSpiroFileButton.Name = "selectSpiroFileButton";
            this.selectSpiroFileButton.Size = new System.Drawing.Size(120, 40);
            this.selectSpiroFileButton.TabIndex = 10;
            this.selectSpiroFileButton.Text = "Выбрать спирофайл...";
            this.selectSpiroFileButton.UseVisualStyleBackColor = true;
            this.selectSpiroFileButton.Click += new System.EventHandler(this.selectFileButton_Click);
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoEllipsis = true;
            this.fileNameLabel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.fileNameLabel.Location = new System.Drawing.Point(6, 200);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(250, 60);
            this.fileNameLabel.TabIndex = 4;
            this.fileNameLabel.Text = "Путь до файла";
            // 
            // selectFileButton
            // 
            this.selectFileButton.Location = new System.Drawing.Point(6, 19);
            this.selectFileButton.Name = "selectFileButton";
            this.selectFileButton.Size = new System.Drawing.Size(120, 40);
            this.selectFileButton.TabIndex = 1;
            this.selectFileButton.Text = "Выбрать файл...";
            this.selectFileButton.UseVisualStyleBackColor = true;
            this.selectFileButton.Click += new System.EventHandler(this.selectFileButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.showAmplitudeSpectrumFTSButton);
            this.groupBox3.Controls.Add(this.showAmplitudeSpectrumFFTButton);
            this.groupBox3.Controls.Add(this.showBaseSignalButton);
            this.groupBox3.Controls.Add(this.showPhaseSpectrumButton);
            this.groupBox3.Controls.Add(this.filterButton);
            this.groupBox3.Location = new System.Drawing.Point(280, 14);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(492, 415);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Основные операции";
            // 
            // showAmplitudeSpectrumFTSButton
            // 
            this.showAmplitudeSpectrumFTSButton.Location = new System.Drawing.Point(132, 72);
            this.showAmplitudeSpectrumFTSButton.Name = "showAmplitudeSpectrumFTSButton";
            this.showAmplitudeSpectrumFTSButton.Size = new System.Drawing.Size(120, 40);
            this.showAmplitudeSpectrumFTSButton.TabIndex = 16;
            this.showAmplitudeSpectrumFTSButton.Text = "Амплитудный спектр (ДПФу)";
            this.showAmplitudeSpectrumFTSButton.UseVisualStyleBackColor = true;
            this.showAmplitudeSpectrumFTSButton.Click += new System.EventHandler(this.showAmplitudeSpectrumFTSButton_Click);
            // 
            // showAmplitudeSpectrumFFTButton
            // 
            this.showAmplitudeSpectrumFFTButton.Location = new System.Drawing.Point(6, 72);
            this.showAmplitudeSpectrumFFTButton.Name = "showAmplitudeSpectrumFFTButton";
            this.showAmplitudeSpectrumFFTButton.Size = new System.Drawing.Size(120, 40);
            this.showAmplitudeSpectrumFFTButton.TabIndex = 15;
            this.showAmplitudeSpectrumFFTButton.Text = "Амплитудный спектр (БПФ)";
            this.showAmplitudeSpectrumFFTButton.UseVisualStyleBackColor = true;
            this.showAmplitudeSpectrumFFTButton.Click += new System.EventHandler(this.showAmplitudeSpectrumFFTButton_Click);
            // 
            // showBaseSignalButton
            // 
            this.showBaseSignalButton.Location = new System.Drawing.Point(6, 26);
            this.showBaseSignalButton.Name = "showBaseSignalButton";
            this.showBaseSignalButton.Size = new System.Drawing.Size(120, 40);
            this.showBaseSignalButton.TabIndex = 1;
            this.showBaseSignalButton.Text = "Показать сигнал";
            this.showBaseSignalButton.UseVisualStyleBackColor = true;
            this.showBaseSignalButton.Click += new System.EventHandler(this.showBaseSignalButton_Click);
            // 
            // showPhaseSpectrumButton
            // 
            this.showPhaseSpectrumButton.Location = new System.Drawing.Point(6, 118);
            this.showPhaseSpectrumButton.Name = "showPhaseSpectrumButton";
            this.showPhaseSpectrumButton.Size = new System.Drawing.Size(120, 40);
            this.showPhaseSpectrumButton.TabIndex = 8;
            this.showPhaseSpectrumButton.Text = "Фазовый спектр";
            this.showPhaseSpectrumButton.UseVisualStyleBackColor = true;
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(6, 164);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(120, 40);
            this.filterButton.TabIndex = 10;
            this.filterButton.Text = "Фильтрация";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.showAmplitudeSpectrumTestButton);
            this.groupBox2.Controls.Add(this.maxNumericUpDown);
            this.groupBox2.Controls.Add(this.minNumericUpDown);
            this.groupBox2.Controls.Add(this.minValueLabel);
            this.groupBox2.Controls.Add(this.showTestAmplitudeSpectrumButton);
            this.groupBox2.Controls.Add(this.maxValueLabel);
            this.groupBox2.Location = new System.Drawing.Point(12, 284);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 145);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Тестирование";
            // 
            // showAmplitudeSpectrumTestButton
            // 
            this.showAmplitudeSpectrumTestButton.Location = new System.Drawing.Point(6, 87);
            this.showAmplitudeSpectrumTestButton.Name = "showAmplitudeSpectrumTestButton";
            this.showAmplitudeSpectrumTestButton.Size = new System.Drawing.Size(120, 40);
            this.showAmplitudeSpectrumTestButton.TabIndex = 48;
            this.showAmplitudeSpectrumTestButton.Text = "Отсчёты амплитудного спектра";
            this.showAmplitudeSpectrumTestButton.UseVisualStyleBackColor = true;
            // 
            // maxNumericUpDown
            // 
            this.maxNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maxNumericUpDown.Location = new System.Drawing.Point(203, 44);
            this.maxNumericUpDown.Name = "maxNumericUpDown";
            this.maxNumericUpDown.Size = new System.Drawing.Size(49, 20);
            this.maxNumericUpDown.TabIndex = 47;
            this.maxNumericUpDown.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // minNumericUpDown
            // 
            this.minNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minNumericUpDown.Location = new System.Drawing.Point(203, 19);
            this.minNumericUpDown.Name = "minNumericUpDown";
            this.minNumericUpDown.Size = new System.Drawing.Size(49, 20);
            this.minNumericUpDown.TabIndex = 46;
            // 
            // minValueLabel
            // 
            this.minValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minValueLabel.AutoSize = true;
            this.minValueLabel.Location = new System.Drawing.Point(63, 21);
            this.minValueLabel.Name = "minValueLabel";
            this.minValueLabel.Size = new System.Drawing.Size(128, 13);
            this.minValueLabel.TabIndex = 44;
            this.minValueLabel.Text = "Минимальное значение";
            // 
            // showTestAmplitudeSpectrumButton
            // 
            this.showTestAmplitudeSpectrumButton.Location = new System.Drawing.Point(132, 87);
            this.showTestAmplitudeSpectrumButton.Name = "showTestAmplitudeSpectrumButton";
            this.showTestAmplitudeSpectrumButton.Size = new System.Drawing.Size(120, 40);
            this.showTestAmplitudeSpectrumButton.TabIndex = 9;
            this.showTestAmplitudeSpectrumButton.Text = "Тестовые ампл. спектры";
            this.showTestAmplitudeSpectrumButton.UseVisualStyleBackColor = true;
            // 
            // maxValueLabel
            // 
            this.maxValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maxValueLabel.AutoSize = true;
            this.maxValueLabel.Location = new System.Drawing.Point(63, 46);
            this.maxValueLabel.Name = "maxValueLabel";
            this.maxValueLabel.Size = new System.Drawing.Size(134, 13);
            this.maxValueLabel.TabIndex = 45;
            this.maxValueLabel.Text = "Максимальное значение";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 480);
            this.Name = "MainForm";
            this.Text = "Обработка сигналов 3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button selectFileButton;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button showBaseSignalButton;
        private System.Windows.Forms.Button showPhaseSpectrumButton;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.Button showAmplitudeSpectrumFTSButton;
        private System.Windows.Forms.Button showAmplitudeSpectrumFFTButton;
        private System.Windows.Forms.Button selectAudioFileButton;
        private System.Windows.Forms.Button selectCardioFileButton;
        private System.Windows.Forms.Button selectReoFileButton;
        private System.Windows.Forms.Button selectVeloFileButton;
        private System.Windows.Forms.Button selectSpiroFileButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button showAmplitudeSpectrumTestButton;
        private System.Windows.Forms.NumericUpDown maxNumericUpDown;
        private System.Windows.Forms.NumericUpDown minNumericUpDown;
        private System.Windows.Forms.Label minValueLabel;
        private System.Windows.Forms.Button showTestAmplitudeSpectrumButton;
        private System.Windows.Forms.Label maxValueLabel;
    }
}

