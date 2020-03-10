namespace Signal_Processing_3.Forms
{
    partial class FirFilterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.fTSRadioButton = new System.Windows.Forms.RadioButton();
            this.fFTRadioButton = new System.Windows.Forms.RadioButton();
            this.bFTRadioButton = new System.Windows.Forms.RadioButton();
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.saveToFileCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.notchNumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.notchButton = new System.Windows.Forms.Button();
            this.notchNumericUpDown0 = new System.Windows.Forms.NumericUpDown();
            this.notchComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bPFilterNumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.bPFilterButton = new System.Windows.Forms.Button();
            this.bPFilterNnumericUpDown0 = new System.Windows.Forms.NumericUpDown();
            this.bPFilterComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.hPFilterButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lPImpulceCharacteristicThresholdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.lPImpulceCharacteristicNNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.lPFilterButton = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.showFrequencyResponseDButton = new System.Windows.Forms.Button();
            this.showPhaseResponseButton = new System.Windows.Forms.Button();
            this.showFrequencyResponseButton = new System.Windows.Forms.Button();
            this.impulceCharacteristicThresholdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.impulceCharacteristicNNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.showImpulceCharacteristicButton = new System.Windows.Forms.Button();
            this.hPImpulceCharacteristicThresholdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.hPImpulceCharacteristicNNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notchNumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notchNumericUpDown0)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bPFilterNumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bPFilterNnumericUpDown0)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lPImpulceCharacteristicThresholdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lPImpulceCharacteristicNNumericUpDown)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.impulceCharacteristicThresholdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.impulceCharacteristicNNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hPImpulceCharacteristicThresholdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hPImpulceCharacteristicNNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.fTSRadioButton);
            this.groupBox5.Controls.Add(this.fFTRadioButton);
            this.groupBox5.Controls.Add(this.bFTRadioButton);
            this.groupBox5.Location = new System.Drawing.Point(440, 187);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(167, 298);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Фильтр";
            // 
            // fTSRadioButton
            // 
            this.fTSRadioButton.AutoSize = true;
            this.fTSRadioButton.Location = new System.Drawing.Point(6, 65);
            this.fTSRadioButton.Name = "fTSRadioButton";
            this.fTSRadioButton.Size = new System.Drawing.Size(52, 17);
            this.fTSRadioButton.TabIndex = 2;
            this.fTSRadioButton.TabStop = true;
            this.fTSRadioButton.Text = "ПФУ";
            this.fTSRadioButton.UseVisualStyleBackColor = true;
            // 
            // fFTRadioButton
            // 
            this.fFTRadioButton.AutoSize = true;
            this.fFTRadioButton.Location = new System.Drawing.Point(6, 42);
            this.fFTRadioButton.Name = "fFTRadioButton";
            this.fFTRadioButton.Size = new System.Drawing.Size(51, 17);
            this.fFTRadioButton.TabIndex = 1;
            this.fFTRadioButton.TabStop = true;
            this.fFTRadioButton.Text = "БПФ";
            this.fFTRadioButton.UseVisualStyleBackColor = true;
            // 
            // bFTRadioButton
            // 
            this.bFTRadioButton.AutoSize = true;
            this.bFTRadioButton.Location = new System.Drawing.Point(6, 19);
            this.bFTRadioButton.Name = "bFTRadioButton";
            this.bFTRadioButton.Size = new System.Drawing.Size(59, 17);
            this.bFTRadioButton.TabIndex = 0;
            this.bFTRadioButton.TabStop = true;
            this.bFTRadioButton.Text = "Фурье";
            this.bFTRadioButton.UseVisualStyleBackColor = true;
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.Enabled = false;
            this.filePathTextBox.Location = new System.Drawing.Point(190, 465);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.Size = new System.Drawing.Size(244, 20);
            this.filePathTextBox.TabIndex = 21;
            // 
            // saveToFileCheckBox
            // 
            this.saveToFileCheckBox.AutoSize = true;
            this.saveToFileCheckBox.Location = new System.Drawing.Point(13, 467);
            this.saveToFileCheckBox.Name = "saveToFileCheckBox";
            this.saveToFileCheckBox.Size = new System.Drawing.Size(171, 17);
            this.saveToFileCheckBox.TabIndex = 20;
            this.saveToFileCheckBox.Text = "Сохранить результат в файл";
            this.saveToFileCheckBox.UseVisualStyleBackColor = true;
            this.saveToFileCheckBox.CheckedChanged += new System.EventHandler(this.saveToFileCheckBox_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.notchNumericUpDown1);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.notchButton);
            this.groupBox4.Controls.Add(this.notchNumericUpDown0);
            this.groupBox4.Controls.Add(this.notchComboBox);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(228, 321);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(206, 124);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Режекторный фильтр";
            // 
            // notchNumericUpDown1
            // 
            this.notchNumericUpDown1.Location = new System.Drawing.Point(62, 53);
            this.notchNumericUpDown1.Name = "notchNumericUpDown1";
            this.notchNumericUpDown1.Size = new System.Drawing.Size(50, 20);
            this.notchNumericUpDown1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Порог 2:";
            // 
            // notchButton
            // 
            this.notchButton.Location = new System.Drawing.Point(62, 79);
            this.notchButton.Name = "notchButton";
            this.notchButton.Size = new System.Drawing.Size(88, 37);
            this.notchButton.TabIndex = 6;
            this.notchButton.Text = "Показать";
            this.notchButton.UseVisualStyleBackColor = true;
            // 
            // notchNumericUpDown0
            // 
            this.notchNumericUpDown0.Location = new System.Drawing.Point(62, 27);
            this.notchNumericUpDown0.Name = "notchNumericUpDown0";
            this.notchNumericUpDown0.Size = new System.Drawing.Size(50, 20);
            this.notchNumericUpDown0.TabIndex = 11;
            // 
            // notchComboBox
            // 
            this.notchComboBox.FormattingEnabled = true;
            this.notchComboBox.Items.AddRange(new object[] {
            "Гц",
            "Отсчётов"});
            this.notchComboBox.Location = new System.Drawing.Point(118, 38);
            this.notchComboBox.Name = "notchComboBox";
            this.notchComboBox.Size = new System.Drawing.Size(80, 21);
            this.notchComboBox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Порог 1:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bPFilterNumericUpDown1);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.bPFilterButton);
            this.groupBox3.Controls.Add(this.bPFilterNnumericUpDown0);
            this.groupBox3.Controls.Add(this.bPFilterComboBox);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(228, 187);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(206, 124);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Полосовой фильтр";
            // 
            // bPFilterNumericUpDown1
            // 
            this.bPFilterNumericUpDown1.Location = new System.Drawing.Point(62, 53);
            this.bPFilterNumericUpDown1.Name = "bPFilterNumericUpDown1";
            this.bPFilterNumericUpDown1.Size = new System.Drawing.Size(50, 20);
            this.bPFilterNumericUpDown1.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Порог 2:";
            // 
            // bPFilterButton
            // 
            this.bPFilterButton.Location = new System.Drawing.Point(62, 79);
            this.bPFilterButton.Name = "bPFilterButton";
            this.bPFilterButton.Size = new System.Drawing.Size(88, 37);
            this.bPFilterButton.TabIndex = 6;
            this.bPFilterButton.Text = "Показать";
            this.bPFilterButton.UseVisualStyleBackColor = true;
            // 
            // bPFilterNnumericUpDown0
            // 
            this.bPFilterNnumericUpDown0.Location = new System.Drawing.Point(62, 27);
            this.bPFilterNnumericUpDown0.Name = "bPFilterNnumericUpDown0";
            this.bPFilterNnumericUpDown0.Size = new System.Drawing.Size(50, 20);
            this.bPFilterNnumericUpDown0.TabIndex = 11;
            // 
            // bPFilterComboBox
            // 
            this.bPFilterComboBox.FormattingEnabled = true;
            this.bPFilterComboBox.Items.AddRange(new object[] {
            "Гц",
            "Отсчётов"});
            this.bPFilterComboBox.Location = new System.Drawing.Point(118, 38);
            this.bPFilterComboBox.Name = "bPFilterComboBox";
            this.bPFilterComboBox.Size = new System.Drawing.Size(80, 21);
            this.bPFilterComboBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Порог 1:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.hPImpulceCharacteristicThresholdNumericUpDown);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.hPImpulceCharacteristicNNumericUpDown);
            this.groupBox2.Controls.Add(this.hPFilterButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 321);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(198, 124);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ВЧ фильтр";
            // 
            // hPFilterButton
            // 
            this.hPFilterButton.Location = new System.Drawing.Point(53, 79);
            this.hPFilterButton.Name = "hPFilterButton";
            this.hPFilterButton.Size = new System.Drawing.Size(88, 37);
            this.hPFilterButton.TabIndex = 6;
            this.hPFilterButton.Text = "Показать";
            this.hPFilterButton.UseVisualStyleBackColor = true;
            this.hPFilterButton.Click += new System.EventHandler(this.hPFilterButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lPImpulceCharacteristicThresholdNumericUpDown);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lPImpulceCharacteristicNNumericUpDown);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lPFilterButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 187);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(198, 124);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "НЧ фильтр";
            // 
            // lPImpulceCharacteristicThresholdNumericUpDown
            // 
            this.lPImpulceCharacteristicThresholdNumericUpDown.Location = new System.Drawing.Point(133, 19);
            this.lPImpulceCharacteristicThresholdNumericUpDown.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.lPImpulceCharacteristicThresholdNumericUpDown.Name = "lPImpulceCharacteristicThresholdNumericUpDown";
            this.lPImpulceCharacteristicThresholdNumericUpDown.Size = new System.Drawing.Size(50, 20);
            this.lPImpulceCharacteristicThresholdNumericUpDown.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(86, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Порог:";
            // 
            // lPImpulceCharacteristicNNumericUpDown
            // 
            this.lPImpulceCharacteristicNNumericUpDown.Location = new System.Drawing.Point(30, 19);
            this.lPImpulceCharacteristicNNumericUpDown.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.lPImpulceCharacteristicNNumericUpDown.Name = "lPImpulceCharacteristicNNumericUpDown";
            this.lPImpulceCharacteristicNNumericUpDown.Size = new System.Drawing.Size(50, 20);
            this.lPImpulceCharacteristicNNumericUpDown.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "N:";
            // 
            // lPFilterButton
            // 
            this.lPFilterButton.Location = new System.Drawing.Point(53, 79);
            this.lPFilterButton.Name = "lPFilterButton";
            this.lPFilterButton.Size = new System.Drawing.Size(88, 37);
            this.lPFilterButton.TabIndex = 6;
            this.lPFilterButton.Text = "Показать";
            this.lPFilterButton.UseVisualStyleBackColor = true;
            this.lPFilterButton.Click += new System.EventHandler(this.lPFilterButton_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.showFrequencyResponseDButton);
            this.groupBox6.Controls.Add(this.showPhaseResponseButton);
            this.groupBox6.Controls.Add(this.showFrequencyResponseButton);
            this.groupBox6.Controls.Add(this.impulceCharacteristicThresholdNumericUpDown);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.impulceCharacteristicNNumericUpDown);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.showImpulceCharacteristicButton);
            this.groupBox6.Location = new System.Drawing.Point(12, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(385, 101);
            this.groupBox6.TabIndex = 16;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Импульсная характеристика";
            // 
            // showFrequencyResponseDButton
            // 
            this.showFrequencyResponseDButton.Location = new System.Drawing.Point(292, 17);
            this.showFrequencyResponseDButton.Name = "showFrequencyResponseDButton";
            this.showFrequencyResponseDButton.Size = new System.Drawing.Size(88, 37);
            this.showFrequencyResponseDButton.TabIndex = 13;
            this.showFrequencyResponseDButton.Text = "АЧХ (Децибелы)";
            this.showFrequencyResponseDButton.UseVisualStyleBackColor = true;
            this.showFrequencyResponseDButton.Click += new System.EventHandler(this.showFrequencyResponseDButton_Click);
            // 
            // showPhaseResponseButton
            // 
            this.showPhaseResponseButton.Location = new System.Drawing.Point(198, 58);
            this.showPhaseResponseButton.Name = "showPhaseResponseButton";
            this.showPhaseResponseButton.Size = new System.Drawing.Size(88, 37);
            this.showPhaseResponseButton.TabIndex = 12;
            this.showPhaseResponseButton.Text = "ФЧХ";
            this.showPhaseResponseButton.UseVisualStyleBackColor = true;
            this.showPhaseResponseButton.Click += new System.EventHandler(this.showPhaseResponseButton_Click);
            // 
            // showFrequencyResponseButton
            // 
            this.showFrequencyResponseButton.Location = new System.Drawing.Point(198, 17);
            this.showFrequencyResponseButton.Name = "showFrequencyResponseButton";
            this.showFrequencyResponseButton.Size = new System.Drawing.Size(88, 37);
            this.showFrequencyResponseButton.TabIndex = 11;
            this.showFrequencyResponseButton.Text = "АЧХ";
            this.showFrequencyResponseButton.UseVisualStyleBackColor = true;
            this.showFrequencyResponseButton.Click += new System.EventHandler(this.showFrequencyResponseButton_Click);
            // 
            // impulceCharacteristicThresholdNumericUpDown
            // 
            this.impulceCharacteristicThresholdNumericUpDown.Location = new System.Drawing.Point(133, 27);
            this.impulceCharacteristicThresholdNumericUpDown.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.impulceCharacteristicThresholdNumericUpDown.Name = "impulceCharacteristicThresholdNumericUpDown";
            this.impulceCharacteristicThresholdNumericUpDown.Size = new System.Drawing.Size(50, 20);
            this.impulceCharacteristicThresholdNumericUpDown.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(86, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Порог:";
            // 
            // impulceCharacteristicNNumericUpDown
            // 
            this.impulceCharacteristicNNumericUpDown.Location = new System.Drawing.Point(30, 27);
            this.impulceCharacteristicNNumericUpDown.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.impulceCharacteristicNNumericUpDown.Name = "impulceCharacteristicNNumericUpDown";
            this.impulceCharacteristicNNumericUpDown.Size = new System.Drawing.Size(50, 20);
            this.impulceCharacteristicNNumericUpDown.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "N:";
            // 
            // showImpulceCharacteristicButton
            // 
            this.showImpulceCharacteristicButton.Location = new System.Drawing.Point(39, 58);
            this.showImpulceCharacteristicButton.Name = "showImpulceCharacteristicButton";
            this.showImpulceCharacteristicButton.Size = new System.Drawing.Size(88, 37);
            this.showImpulceCharacteristicButton.TabIndex = 6;
            this.showImpulceCharacteristicButton.Text = "Показать";
            this.showImpulceCharacteristicButton.UseVisualStyleBackColor = true;
            this.showImpulceCharacteristicButton.Click += new System.EventHandler(this.showImpulceCharacteristicButton_Click);
            // 
            // hPImpulceCharacteristicThresholdNumericUpDown
            // 
            this.hPImpulceCharacteristicThresholdNumericUpDown.Location = new System.Drawing.Point(133, 22);
            this.hPImpulceCharacteristicThresholdNumericUpDown.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.hPImpulceCharacteristicThresholdNumericUpDown.Name = "hPImpulceCharacteristicThresholdNumericUpDown";
            this.hPImpulceCharacteristicThresholdNumericUpDown.Size = new System.Drawing.Size(50, 20);
            this.hPImpulceCharacteristicThresholdNumericUpDown.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Порог:";
            // 
            // hPImpulceCharacteristicNNumericUpDown
            // 
            this.hPImpulceCharacteristicNNumericUpDown.Location = new System.Drawing.Point(30, 22);
            this.hPImpulceCharacteristicNNumericUpDown.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.hPImpulceCharacteristicNNumericUpDown.Name = "hPImpulceCharacteristicNNumericUpDown";
            this.hPImpulceCharacteristicNNumericUpDown.Size = new System.Drawing.Size(50, 20);
            this.hPImpulceCharacteristicNNumericUpDown.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "N:";
            // 
            // FirFilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 497);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.filePathTextBox);
            this.Controls.Add(this.saveToFileCheckBox);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FirFilterForm";
            this.Text = "Фильтры";
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notchNumericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notchNumericUpDown0)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bPFilterNumericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bPFilterNnumericUpDown0)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lPImpulceCharacteristicThresholdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lPImpulceCharacteristicNNumericUpDown)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.impulceCharacteristicThresholdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.impulceCharacteristicNNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hPImpulceCharacteristicThresholdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hPImpulceCharacteristicNNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton fTSRadioButton;
        private System.Windows.Forms.RadioButton fFTRadioButton;
        private System.Windows.Forms.RadioButton bFTRadioButton;
        private System.Windows.Forms.TextBox filePathTextBox;
        private System.Windows.Forms.CheckBox saveToFileCheckBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown notchNumericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button notchButton;
        private System.Windows.Forms.NumericUpDown notchNumericUpDown0;
        private System.Windows.Forms.ComboBox notchComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown bPFilterNumericUpDown1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bPFilterButton;
        private System.Windows.Forms.NumericUpDown bPFilterNnumericUpDown0;
        private System.Windows.Forms.ComboBox bPFilterComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button hPFilterButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button lPFilterButton;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.NumericUpDown impulceCharacteristicNNumericUpDown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button showImpulceCharacteristicButton;
        private System.Windows.Forms.NumericUpDown impulceCharacteristicThresholdNumericUpDown;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button showPhaseResponseButton;
        private System.Windows.Forms.Button showFrequencyResponseButton;
        private System.Windows.Forms.Button showFrequencyResponseDButton;
        private System.Windows.Forms.NumericUpDown lPImpulceCharacteristicThresholdNumericUpDown;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown lPImpulceCharacteristicNNumericUpDown;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown hPImpulceCharacteristicThresholdNumericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown hPImpulceCharacteristicNNumericUpDown;
    }
}