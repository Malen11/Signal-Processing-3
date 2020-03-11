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
            this.bartlettWindowRadioButton = new System.Windows.Forms.RadioButton();
            this.hammingWindowRadioButton = new System.Windows.Forms.RadioButton();
            this.rectangleWindowRadioButton = new System.Windows.Forms.RadioButton();
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.saveToFileCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.notchImpulceCharacteristicThreshold1NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.notchButton = new System.Windows.Forms.Button();
            this.notchImpulceCharacteristicThreshold0NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bPImpulceCharacteristicThreshold1NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.bPFilterButton = new System.Windows.Forms.Button();
            this.bPImpulceCharacteristicThreshold0NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.hPImpulceCharacteristicThresholdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.hPImpulceCharacteristicNNumericUpDown = new System.Windows.Forms.NumericUpDown();
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
            this.label11 = new System.Windows.Forms.Label();
            this.impulseCharacteristicTypeComboBox = new System.Windows.Forms.ComboBox();
            this.hanningWindowRadioButton = new System.Windows.Forms.RadioButton();
            this.blackmanWindowRadioButton = new System.Windows.Forms.RadioButton();
            this.bPImpulceCharacteristicNNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.notchImpulceCharacteristicNNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notchImpulceCharacteristicThreshold1NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notchImpulceCharacteristicThreshold0NumericUpDown)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bPImpulceCharacteristicThreshold1NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bPImpulceCharacteristicThreshold0NumericUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hPImpulceCharacteristicThresholdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hPImpulceCharacteristicNNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lPImpulceCharacteristicThresholdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lPImpulceCharacteristicNNumericUpDown)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.impulceCharacteristicThresholdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.impulceCharacteristicNNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bPImpulceCharacteristicNNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notchImpulceCharacteristicNNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.blackmanWindowRadioButton);
            this.groupBox5.Controls.Add(this.hanningWindowRadioButton);
            this.groupBox5.Controls.Add(this.bartlettWindowRadioButton);
            this.groupBox5.Controls.Add(this.hammingWindowRadioButton);
            this.groupBox5.Controls.Add(this.rectangleWindowRadioButton);
            this.groupBox5.Location = new System.Drawing.Point(440, 119);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(171, 282);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Окно";
            // 
            // bartlettWindowRadioButton
            // 
            this.bartlettWindowRadioButton.AutoSize = true;
            this.bartlettWindowRadioButton.Location = new System.Drawing.Point(6, 65);
            this.bartlettWindowRadioButton.Name = "bartlettWindowRadioButton";
            this.bartlettWindowRadioButton.Size = new System.Drawing.Size(66, 17);
            this.bartlettWindowRadioButton.TabIndex = 2;
            this.bartlettWindowRadioButton.Text = "Бартлет";
            this.bartlettWindowRadioButton.UseVisualStyleBackColor = true;
            // 
            // hammingWindowRadioButton
            // 
            this.hammingWindowRadioButton.AutoSize = true;
            this.hammingWindowRadioButton.Location = new System.Drawing.Point(6, 42);
            this.hammingWindowRadioButton.Name = "hammingWindowRadioButton";
            this.hammingWindowRadioButton.Size = new System.Drawing.Size(71, 17);
            this.hammingWindowRadioButton.TabIndex = 1;
            this.hammingWindowRadioButton.Text = "Хэмминг";
            this.hammingWindowRadioButton.UseVisualStyleBackColor = true;
            // 
            // rectangleWindowRadioButton
            // 
            this.rectangleWindowRadioButton.AutoSize = true;
            this.rectangleWindowRadioButton.Checked = true;
            this.rectangleWindowRadioButton.Location = new System.Drawing.Point(6, 19);
            this.rectangleWindowRadioButton.Name = "rectangleWindowRadioButton";
            this.rectangleWindowRadioButton.Size = new System.Drawing.Size(105, 17);
            this.rectangleWindowRadioButton.TabIndex = 0;
            this.rectangleWindowRadioButton.TabStop = true;
            this.rectangleWindowRadioButton.Text = "Прямоугольное";
            this.rectangleWindowRadioButton.UseVisualStyleBackColor = true;
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.Enabled = false;
            this.filePathTextBox.Location = new System.Drawing.Point(189, 381);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.Size = new System.Drawing.Size(244, 20);
            this.filePathTextBox.TabIndex = 21;
            // 
            // saveToFileCheckBox
            // 
            this.saveToFileCheckBox.AutoSize = true;
            this.saveToFileCheckBox.Location = new System.Drawing.Point(12, 383);
            this.saveToFileCheckBox.Name = "saveToFileCheckBox";
            this.saveToFileCheckBox.Size = new System.Drawing.Size(171, 17);
            this.saveToFileCheckBox.TabIndex = 20;
            this.saveToFileCheckBox.Text = "Сохранить результат в файл";
            this.saveToFileCheckBox.UseVisualStyleBackColor = true;
            this.saveToFileCheckBox.CheckedChanged += new System.EventHandler(this.saveToFileCheckBox_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.notchImpulceCharacteristicNNumericUpDown);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.notchImpulceCharacteristicThreshold1NumericUpDown);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.notchButton);
            this.groupBox4.Controls.Add(this.notchImpulceCharacteristicThreshold0NumericUpDown);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(228, 253);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(206, 124);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Режекторный фильтр";
            // 
            // notchImpulceCharacteristicThreshold1NumericUpDown
            // 
            this.notchImpulceCharacteristicThreshold1NumericUpDown.Location = new System.Drawing.Point(148, 58);
            this.notchImpulceCharacteristicThreshold1NumericUpDown.Name = "notchImpulceCharacteristicThreshold1NumericUpDown";
            this.notchImpulceCharacteristicThreshold1NumericUpDown.Size = new System.Drawing.Size(50, 20);
            this.notchImpulceCharacteristicThreshold1NumericUpDown.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 60);
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
            // notchImpulceCharacteristicThreshold0NumericUpDown
            // 
            this.notchImpulceCharacteristicThreshold0NumericUpDown.Location = new System.Drawing.Point(148, 32);
            this.notchImpulceCharacteristicThreshold0NumericUpDown.Name = "notchImpulceCharacteristicThreshold0NumericUpDown";
            this.notchImpulceCharacteristicThreshold0NumericUpDown.Size = new System.Drawing.Size(50, 20);
            this.notchImpulceCharacteristicThreshold0NumericUpDown.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(92, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Порог 1:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bPImpulceCharacteristicNNumericUpDown);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.bPImpulceCharacteristicThreshold1NumericUpDown);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.bPFilterButton);
            this.groupBox3.Controls.Add(this.bPImpulceCharacteristicThreshold0NumericUpDown);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(228, 119);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(206, 124);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Полосовой фильтр";
            // 
            // bPImpulceCharacteristicThreshold1NumericUpDown
            // 
            this.bPImpulceCharacteristicThreshold1NumericUpDown.Location = new System.Drawing.Point(148, 53);
            this.bPImpulceCharacteristicThreshold1NumericUpDown.Name = "bPImpulceCharacteristicThreshold1NumericUpDown";
            this.bPImpulceCharacteristicThreshold1NumericUpDown.Size = new System.Drawing.Size(50, 20);
            this.bPImpulceCharacteristicThreshold1NumericUpDown.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 55);
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
            this.bPFilterButton.Click += new System.EventHandler(this.bPFilterButton_Click);
            // 
            // bPImpulceCharacteristicThreshold0NumericUpDown
            // 
            this.bPImpulceCharacteristicThreshold0NumericUpDown.Location = new System.Drawing.Point(148, 27);
            this.bPImpulceCharacteristicThreshold0NumericUpDown.Name = "bPImpulceCharacteristicThreshold0NumericUpDown";
            this.bPImpulceCharacteristicThreshold0NumericUpDown.Size = new System.Drawing.Size(50, 20);
            this.bPImpulceCharacteristicThreshold0NumericUpDown.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 29);
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
            this.groupBox2.Location = new System.Drawing.Point(12, 253);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(198, 124);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ВЧ фильтр";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "N:";
            // 
            // hPImpulceCharacteristicThresholdNumericUpDown
            // 
            this.hPImpulceCharacteristicThresholdNumericUpDown.Location = new System.Drawing.Point(133, 32);
            this.hPImpulceCharacteristicThresholdNumericUpDown.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.hPImpulceCharacteristicThresholdNumericUpDown.Name = "hPImpulceCharacteristicThresholdNumericUpDown";
            this.hPImpulceCharacteristicThresholdNumericUpDown.Size = new System.Drawing.Size(50, 20);
            this.hPImpulceCharacteristicThresholdNumericUpDown.TabIndex = 17;
            this.hPImpulceCharacteristicThresholdNumericUpDown.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Порог:";
            // 
            // hPImpulceCharacteristicNNumericUpDown
            // 
            this.hPImpulceCharacteristicNNumericUpDown.Location = new System.Drawing.Point(30, 32);
            this.hPImpulceCharacteristicNNumericUpDown.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.hPImpulceCharacteristicNNumericUpDown.Name = "hPImpulceCharacteristicNNumericUpDown";
            this.hPImpulceCharacteristicNNumericUpDown.Size = new System.Drawing.Size(50, 20);
            this.hPImpulceCharacteristicNNumericUpDown.TabIndex = 15;
            this.hPImpulceCharacteristicNNumericUpDown.Value = new decimal(new int[] {
            41,
            0,
            0,
            0});
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
            this.groupBox1.Location = new System.Drawing.Point(12, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(198, 124);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "НЧ фильтр";
            // 
            // lPImpulceCharacteristicThresholdNumericUpDown
            // 
            this.lPImpulceCharacteristicThresholdNumericUpDown.Location = new System.Drawing.Point(133, 32);
            this.lPImpulceCharacteristicThresholdNumericUpDown.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.lPImpulceCharacteristicThresholdNumericUpDown.Name = "lPImpulceCharacteristicThresholdNumericUpDown";
            this.lPImpulceCharacteristicThresholdNumericUpDown.Size = new System.Drawing.Size(50, 20);
            this.lPImpulceCharacteristicThresholdNumericUpDown.TabIndex = 14;
            this.lPImpulceCharacteristicThresholdNumericUpDown.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(86, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Порог:";
            // 
            // lPImpulceCharacteristicNNumericUpDown
            // 
            this.lPImpulceCharacteristicNNumericUpDown.Location = new System.Drawing.Point(30, 32);
            this.lPImpulceCharacteristicNNumericUpDown.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.lPImpulceCharacteristicNNumericUpDown.Name = "lPImpulceCharacteristicNNumericUpDown";
            this.lPImpulceCharacteristicNNumericUpDown.Size = new System.Drawing.Size(50, 20);
            this.lPImpulceCharacteristicNNumericUpDown.TabIndex = 12;
            this.lPImpulceCharacteristicNNumericUpDown.Value = new decimal(new int[] {
            41,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 34);
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
            this.groupBox6.Controls.Add(this.impulseCharacteristicTypeComboBox);
            this.groupBox6.Controls.Add(this.label11);
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
            this.groupBox6.Size = new System.Drawing.Size(599, 101);
            this.groupBox6.TabIndex = 16;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Импульсная характеристика";
            // 
            // showFrequencyResponseDButton
            // 
            this.showFrequencyResponseDButton.Location = new System.Drawing.Point(505, 17);
            this.showFrequencyResponseDButton.Name = "showFrequencyResponseDButton";
            this.showFrequencyResponseDButton.Size = new System.Drawing.Size(88, 37);
            this.showFrequencyResponseDButton.TabIndex = 13;
            this.showFrequencyResponseDButton.Text = "АЧХ (Децибелы)";
            this.showFrequencyResponseDButton.UseVisualStyleBackColor = true;
            this.showFrequencyResponseDButton.Click += new System.EventHandler(this.showFrequencyResponseDButton_Click);
            // 
            // showPhaseResponseButton
            // 
            this.showPhaseResponseButton.Location = new System.Drawing.Point(411, 58);
            this.showPhaseResponseButton.Name = "showPhaseResponseButton";
            this.showPhaseResponseButton.Size = new System.Drawing.Size(88, 37);
            this.showPhaseResponseButton.TabIndex = 12;
            this.showPhaseResponseButton.Text = "ФЧХ";
            this.showPhaseResponseButton.UseVisualStyleBackColor = true;
            this.showPhaseResponseButton.Click += new System.EventHandler(this.showPhaseResponseButton_Click);
            // 
            // showFrequencyResponseButton
            // 
            this.showFrequencyResponseButton.Location = new System.Drawing.Point(411, 17);
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
            this.impulceCharacteristicThresholdNumericUpDown.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
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
            this.impulceCharacteristicNNumericUpDown.Value = new decimal(new int[] {
            41,
            0,
            0,
            0});
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
            this.showImpulceCharacteristicButton.Location = new System.Drawing.Point(53, 58);
            this.showImpulceCharacteristicButton.Name = "showImpulceCharacteristicButton";
            this.showImpulceCharacteristicButton.Size = new System.Drawing.Size(88, 37);
            this.showImpulceCharacteristicButton.TabIndex = 6;
            this.showImpulceCharacteristicButton.Text = "Показать";
            this.showImpulceCharacteristicButton.UseVisualStyleBackColor = true;
            this.showImpulceCharacteristicButton.Click += new System.EventHandler(this.showImpulceCharacteristicButton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(199, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Тип:";
            // 
            // impulseCharacteristicTypeComboBox
            // 
            this.impulseCharacteristicTypeComboBox.FormattingEnabled = true;
            this.impulseCharacteristicTypeComboBox.Location = new System.Drawing.Point(234, 26);
            this.impulseCharacteristicTypeComboBox.Name = "impulseCharacteristicTypeComboBox";
            this.impulseCharacteristicTypeComboBox.Size = new System.Drawing.Size(160, 21);
            this.impulseCharacteristicTypeComboBox.TabIndex = 16;
            // 
            // hanningWindowRadioButton
            // 
            this.hanningWindowRadioButton.AutoSize = true;
            this.hanningWindowRadioButton.Location = new System.Drawing.Point(6, 88);
            this.hanningWindowRadioButton.Name = "hanningWindowRadioButton";
            this.hanningWindowRadioButton.Size = new System.Drawing.Size(67, 17);
            this.hanningWindowRadioButton.TabIndex = 4;
            this.hanningWindowRadioButton.Text = "Хэннинг";
            this.hanningWindowRadioButton.UseVisualStyleBackColor = true;
            // 
            // blackmanWindowRadioButton
            // 
            this.blackmanWindowRadioButton.AutoSize = true;
            this.blackmanWindowRadioButton.Location = new System.Drawing.Point(6, 111);
            this.blackmanWindowRadioButton.Name = "blackmanWindowRadioButton";
            this.blackmanWindowRadioButton.Size = new System.Drawing.Size(70, 17);
            this.blackmanWindowRadioButton.TabIndex = 5;
            this.blackmanWindowRadioButton.Text = "Блэкмен";
            this.blackmanWindowRadioButton.UseVisualStyleBackColor = true;
            // 
            // bPImpulceCharacteristicNNumericUpDown
            // 
            this.bPImpulceCharacteristicNNumericUpDown.Location = new System.Drawing.Point(28, 27);
            this.bPImpulceCharacteristicNNumericUpDown.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.bPImpulceCharacteristicNNumericUpDown.Name = "bPImpulceCharacteristicNNumericUpDown";
            this.bPImpulceCharacteristicNNumericUpDown.Size = new System.Drawing.Size(50, 20);
            this.bPImpulceCharacteristicNNumericUpDown.TabIndex = 16;
            this.bPImpulceCharacteristicNNumericUpDown.Value = new decimal(new int[] {
            41,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "N:";
            // 
            // notchImpulceCharacteristicNNumericUpDown
            // 
            this.notchImpulceCharacteristicNNumericUpDown.Location = new System.Drawing.Point(28, 32);
            this.notchImpulceCharacteristicNNumericUpDown.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.notchImpulceCharacteristicNNumericUpDown.Name = "notchImpulceCharacteristicNNumericUpDown";
            this.notchImpulceCharacteristicNNumericUpDown.Size = new System.Drawing.Size(50, 20);
            this.notchImpulceCharacteristicNNumericUpDown.TabIndex = 18;
            this.notchImpulceCharacteristicNNumericUpDown.Value = new decimal(new int[] {
            41,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 34);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(18, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "N:";
            // 
            // FirFilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 407);
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
            ((System.ComponentModel.ISupportInitialize)(this.notchImpulceCharacteristicThreshold1NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notchImpulceCharacteristicThreshold0NumericUpDown)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bPImpulceCharacteristicThreshold1NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bPImpulceCharacteristicThreshold0NumericUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hPImpulceCharacteristicThresholdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hPImpulceCharacteristicNNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lPImpulceCharacteristicThresholdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lPImpulceCharacteristicNNumericUpDown)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.impulceCharacteristicThresholdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.impulceCharacteristicNNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bPImpulceCharacteristicNNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notchImpulceCharacteristicNNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton bartlettWindowRadioButton;
        private System.Windows.Forms.RadioButton hammingWindowRadioButton;
        private System.Windows.Forms.RadioButton rectangleWindowRadioButton;
        private System.Windows.Forms.TextBox filePathTextBox;
        private System.Windows.Forms.CheckBox saveToFileCheckBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown notchImpulceCharacteristicThreshold1NumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button notchButton;
        private System.Windows.Forms.NumericUpDown notchImpulceCharacteristicThreshold0NumericUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown bPImpulceCharacteristicThreshold1NumericUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bPFilterButton;
        private System.Windows.Forms.NumericUpDown bPImpulceCharacteristicThreshold0NumericUpDown;
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
        private System.Windows.Forms.ComboBox impulseCharacteristicTypeComboBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton hanningWindowRadioButton;
        private System.Windows.Forms.RadioButton blackmanWindowRadioButton;
        private System.Windows.Forms.NumericUpDown bPImpulceCharacteristicNNumericUpDown;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown notchImpulceCharacteristicNNumericUpDown;
        private System.Windows.Forms.Label label13;
    }
}