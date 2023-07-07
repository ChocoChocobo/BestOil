namespace BestOil
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gasStationGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.petrolPriceRadioButton = new System.Windows.Forms.RadioButton();
            this.petrolQuantityRadioButton = new System.Windows.Forms.RadioButton();
            this.gasStationToPayGB = new System.Windows.Forms.GroupBox();
            this.gasStationToPayLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.petrolSumPriceTextBox = new System.Windows.Forms.TextBox();
            this.petrolLitersTextBox = new System.Windows.Forms.TextBox();
            this.petrolPriceTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.petrolPriceLabel = new System.Windows.Forms.Label();
            this.petrolLitersComboBox = new System.Windows.Forms.ComboBox();
            this.petrolLabel = new System.Windows.Forms.Label();
            this.cafeGroupBox = new System.Windows.Forms.GroupBox();
            this.cokeCheckBox = new System.Windows.Forms.CheckBox();
            this.friesCheckBox = new System.Windows.Forms.CheckBox();
            this.burgerCheckBox = new System.Windows.Forms.CheckBox();
            this.hotDogCheckBox = new System.Windows.Forms.CheckBox();
            this.cafeToPayGroupBox = new System.Windows.Forms.GroupBox();
            this.cafeToPaylabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cokeQuantityTextBox = new System.Windows.Forms.TextBox();
            this.friesQuantityTextBox = new System.Windows.Forms.TextBox();
            this.burgerQuantityTextBox = new System.Windows.Forms.TextBox();
            this.hotDogQuantityTextBox = new System.Windows.Forms.TextBox();
            this.cokePriceTextBox = new System.Windows.Forms.TextBox();
            this.friesPriceTextBox = new System.Windows.Forms.TextBox();
            this.burgerPriceTextBox = new System.Windows.Forms.TextBox();
            this.hotDogPriceTextBox = new System.Windows.Forms.TextBox();
            this.toPayGroupBox = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toPayAllLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.toCalculateAllButton = new System.Windows.Forms.Button();
            this.shiftTimer = new System.Windows.Forms.Timer(this.components);
            this.gasStationGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gasStationToPayGB.SuspendLayout();
            this.cafeGroupBox.SuspendLayout();
            this.cafeToPayGroupBox.SuspendLayout();
            this.toPayGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gasStationGroupBox
            // 
            this.gasStationGroupBox.Controls.Add(this.groupBox1);
            this.gasStationGroupBox.Controls.Add(this.gasStationToPayGB);
            this.gasStationGroupBox.Controls.Add(this.petrolSumPriceTextBox);
            this.gasStationGroupBox.Controls.Add(this.petrolLitersTextBox);
            this.gasStationGroupBox.Controls.Add(this.petrolPriceTextBox);
            this.gasStationGroupBox.Controls.Add(this.label3);
            this.gasStationGroupBox.Controls.Add(this.label1);
            this.gasStationGroupBox.Controls.Add(this.label2);
            this.gasStationGroupBox.Controls.Add(this.petrolPriceLabel);
            this.gasStationGroupBox.Controls.Add(this.petrolLitersComboBox);
            this.gasStationGroupBox.Controls.Add(this.petrolLabel);
            this.gasStationGroupBox.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gasStationGroupBox.Location = new System.Drawing.Point(12, 12);
            this.gasStationGroupBox.Name = "gasStationGroupBox";
            this.gasStationGroupBox.Size = new System.Drawing.Size(247, 291);
            this.gasStationGroupBox.TabIndex = 0;
            this.gasStationGroupBox.TabStop = false;
            this.gasStationGroupBox.Text = "Автозаправка";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.petrolPriceRadioButton);
            this.groupBox1.Controls.Add(this.petrolQuantityRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(6, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(117, 72);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // petrolPriceRadioButton
            // 
            this.petrolPriceRadioButton.AutoSize = true;
            this.petrolPriceRadioButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.petrolPriceRadioButton.Location = new System.Drawing.Point(2, 43);
            this.petrolPriceRadioButton.Name = "petrolPriceRadioButton";
            this.petrolPriceRadioButton.Size = new System.Drawing.Size(73, 23);
            this.petrolPriceRadioButton.TabIndex = 0;
            this.petrolPriceRadioButton.TabStop = true;
            this.petrolPriceRadioButton.Text = "Сумма";
            this.petrolPriceRadioButton.UseVisualStyleBackColor = true;
            this.petrolPriceRadioButton.CheckedChanged += new System.EventHandler(this.petrolPriceRadioButton_CheckedChanged);
            // 
            // petrolQuantityRadioButton
            // 
            this.petrolQuantityRadioButton.AutoSize = true;
            this.petrolQuantityRadioButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.petrolQuantityRadioButton.Location = new System.Drawing.Point(2, 16);
            this.petrolQuantityRadioButton.Name = "petrolQuantityRadioButton";
            this.petrolQuantityRadioButton.Size = new System.Drawing.Size(113, 23);
            this.petrolQuantityRadioButton.TabIndex = 0;
            this.petrolQuantityRadioButton.TabStop = true;
            this.petrolQuantityRadioButton.Text = "Количество";
            this.petrolQuantityRadioButton.UseVisualStyleBackColor = true;
            this.petrolQuantityRadioButton.CheckedChanged += new System.EventHandler(this.petrolQuantityRadioButton_CheckedChanged);
            // 
            // gasStationToPayGB
            // 
            this.gasStationToPayGB.Controls.Add(this.gasStationToPayLabel);
            this.gasStationToPayGB.Controls.Add(this.label4);
            this.gasStationToPayGB.Location = new System.Drawing.Point(6, 208);
            this.gasStationToPayGB.Name = "gasStationToPayGB";
            this.gasStationToPayGB.Size = new System.Drawing.Size(235, 77);
            this.gasStationToPayGB.TabIndex = 3;
            this.gasStationToPayGB.TabStop = false;
            this.gasStationToPayGB.Text = "К оплате";
            // 
            // gasStationToPayLabel
            // 
            this.gasStationToPayLabel.AutoSize = true;
            this.gasStationToPayLabel.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gasStationToPayLabel.Location = new System.Drawing.Point(73, 28);
            this.gasStationToPayLabel.Name = "gasStationToPayLabel";
            this.gasStationToPayLabel.Size = new System.Drawing.Size(68, 33);
            this.gasStationToPayLabel.TabIndex = 0;
            this.gasStationToPayLabel.Text = "0,00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(189, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "руб.";
            // 
            // petrolSumPriceTextBox
            // 
            this.petrolSumPriceTextBox.Enabled = false;
            this.petrolSumPriceTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.petrolSumPriceTextBox.Location = new System.Drawing.Point(129, 175);
            this.petrolSumPriceTextBox.Name = "petrolSumPriceTextBox";
            this.petrolSumPriceTextBox.Size = new System.Drawing.Size(73, 27);
            this.petrolSumPriceTextBox.TabIndex = 2;
            this.petrolSumPriceTextBox.TextChanged += new System.EventHandler(this.petrolSumPriceTextBox_TextChanged);
            // 
            // petrolLitersTextBox
            // 
            this.petrolLitersTextBox.Enabled = false;
            this.petrolLitersTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.petrolLitersTextBox.Location = new System.Drawing.Point(129, 142);
            this.petrolLitersTextBox.Name = "petrolLitersTextBox";
            this.petrolLitersTextBox.Size = new System.Drawing.Size(73, 27);
            this.petrolLitersTextBox.TabIndex = 2;
            this.petrolLitersTextBox.TextChanged += new System.EventHandler(this.petrolLitersTextBox_TextChanged);
            // 
            // petrolPriceTextBox
            // 
            this.petrolPriceTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.petrolPriceTextBox.Location = new System.Drawing.Point(106, 95);
            this.petrolPriceTextBox.Name = "petrolPriceTextBox";
            this.petrolPriceTextBox.ReadOnly = true;
            this.petrolPriceTextBox.Size = new System.Drawing.Size(95, 27);
            this.petrolPriceTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(201, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "л.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(201, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "руб.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(201, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "руб.";
            // 
            // petrolPriceLabel
            // 
            this.petrolPriceLabel.AutoSize = true;
            this.petrolPriceLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.petrolPriceLabel.Location = new System.Drawing.Point(6, 98);
            this.petrolPriceLabel.Name = "petrolPriceLabel";
            this.petrolPriceLabel.Size = new System.Drawing.Size(51, 19);
            this.petrolPriceLabel.TabIndex = 0;
            this.petrolPriceLabel.Text = "Цена:";
            // 
            // petrolLitersComboBox
            // 
            this.petrolLitersComboBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.petrolLitersComboBox.FormattingEnabled = true;
            this.petrolLitersComboBox.Location = new System.Drawing.Point(106, 42);
            this.petrolLitersComboBox.Name = "petrolLitersComboBox";
            this.petrolLitersComboBox.Size = new System.Drawing.Size(121, 27);
            this.petrolLitersComboBox.TabIndex = 1;
            this.petrolLitersComboBox.SelectedIndexChanged += new System.EventHandler(this.petrolLitersComboBox_SelectedIndexChanged);
            // 
            // petrolLabel
            // 
            this.petrolLabel.AutoSize = true;
            this.petrolLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.petrolLabel.Location = new System.Drawing.Point(6, 45);
            this.petrolLabel.Name = "petrolLabel";
            this.petrolLabel.Size = new System.Drawing.Size(66, 19);
            this.petrolLabel.TabIndex = 0;
            this.petrolLabel.Text = "Бензин:";
            // 
            // cafeGroupBox
            // 
            this.cafeGroupBox.Controls.Add(this.cokeCheckBox);
            this.cafeGroupBox.Controls.Add(this.friesCheckBox);
            this.cafeGroupBox.Controls.Add(this.burgerCheckBox);
            this.cafeGroupBox.Controls.Add(this.hotDogCheckBox);
            this.cafeGroupBox.Controls.Add(this.cafeToPayGroupBox);
            this.cafeGroupBox.Controls.Add(this.label7);
            this.cafeGroupBox.Controls.Add(this.label5);
            this.cafeGroupBox.Controls.Add(this.cokeQuantityTextBox);
            this.cafeGroupBox.Controls.Add(this.friesQuantityTextBox);
            this.cafeGroupBox.Controls.Add(this.burgerQuantityTextBox);
            this.cafeGroupBox.Controls.Add(this.hotDogQuantityTextBox);
            this.cafeGroupBox.Controls.Add(this.cokePriceTextBox);
            this.cafeGroupBox.Controls.Add(this.friesPriceTextBox);
            this.cafeGroupBox.Controls.Add(this.burgerPriceTextBox);
            this.cafeGroupBox.Controls.Add(this.hotDogPriceTextBox);
            this.cafeGroupBox.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cafeGroupBox.Location = new System.Drawing.Point(295, 12);
            this.cafeGroupBox.Name = "cafeGroupBox";
            this.cafeGroupBox.Size = new System.Drawing.Size(247, 291);
            this.cafeGroupBox.TabIndex = 0;
            this.cafeGroupBox.TabStop = false;
            this.cafeGroupBox.Text = "Кафе";
            // 
            // cokeCheckBox
            // 
            this.cokeCheckBox.AutoSize = true;
            this.cokeCheckBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cokeCheckBox.Location = new System.Drawing.Point(6, 182);
            this.cokeCheckBox.Name = "cokeCheckBox";
            this.cokeCheckBox.Size = new System.Drawing.Size(63, 23);
            this.cokeCheckBox.TabIndex = 4;
            this.cokeCheckBox.Text = "Кока";
            this.cokeCheckBox.UseVisualStyleBackColor = true;
            this.cokeCheckBox.CheckedChanged += new System.EventHandler(this.cokeCheckBox_CheckedChanged_1);
            // 
            // friesCheckBox
            // 
            this.friesCheckBox.AutoSize = true;
            this.friesCheckBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.friesCheckBox.Location = new System.Drawing.Point(6, 144);
            this.friesCheckBox.Name = "friesCheckBox";
            this.friesCheckBox.Size = new System.Drawing.Size(100, 23);
            this.friesCheckBox.TabIndex = 4;
            this.friesCheckBox.Text = "Картошка";
            this.friesCheckBox.UseVisualStyleBackColor = true;
            this.friesCheckBox.CheckedChanged += new System.EventHandler(this.friesCheckBox_CheckedChanged_1);
            // 
            // burgerCheckBox
            // 
            this.burgerCheckBox.AutoSize = true;
            this.burgerCheckBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.burgerCheckBox.Location = new System.Drawing.Point(6, 102);
            this.burgerCheckBox.Name = "burgerCheckBox";
            this.burgerCheckBox.Size = new System.Drawing.Size(78, 23);
            this.burgerCheckBox.TabIndex = 4;
            this.burgerCheckBox.Text = "Бургер";
            this.burgerCheckBox.UseVisualStyleBackColor = true;
            this.burgerCheckBox.CheckedChanged += new System.EventHandler(this.burgerCheckBox_CheckedChanged_1);
            // 
            // hotDogCheckBox
            // 
            this.hotDogCheckBox.AutoSize = true;
            this.hotDogCheckBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hotDogCheckBox.Location = new System.Drawing.Point(6, 62);
            this.hotDogCheckBox.Name = "hotDogCheckBox";
            this.hotDogCheckBox.Size = new System.Drawing.Size(85, 23);
            this.hotDogCheckBox.TabIndex = 4;
            this.hotDogCheckBox.Text = "Хот-дог";
            this.hotDogCheckBox.UseVisualStyleBackColor = true;
            this.hotDogCheckBox.CheckedChanged += new System.EventHandler(this.hotDogCheckBox_CheckedChanged_1);
            // 
            // cafeToPayGroupBox
            // 
            this.cafeToPayGroupBox.Controls.Add(this.cafeToPaylabel);
            this.cafeToPayGroupBox.Controls.Add(this.label6);
            this.cafeToPayGroupBox.Location = new System.Drawing.Point(6, 208);
            this.cafeToPayGroupBox.Name = "cafeToPayGroupBox";
            this.cafeToPayGroupBox.Size = new System.Drawing.Size(235, 77);
            this.cafeToPayGroupBox.TabIndex = 3;
            this.cafeToPayGroupBox.TabStop = false;
            this.cafeToPayGroupBox.Text = "К оплате";
            // 
            // cafeToPaylabel
            // 
            this.cafeToPaylabel.AutoSize = true;
            this.cafeToPaylabel.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cafeToPaylabel.Location = new System.Drawing.Point(70, 28);
            this.cafeToPaylabel.Name = "cafeToPaylabel";
            this.cafeToPaylabel.Size = new System.Drawing.Size(68, 33);
            this.cafeToPaylabel.TabIndex = 0;
            this.cafeToPaylabel.Text = "0,00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(189, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "руб.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(175, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Кол-во";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(118, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Цена";
            // 
            // cokeQuantityTextBox
            // 
            this.cokeQuantityTextBox.Enabled = false;
            this.cokeQuantityTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cokeQuantityTextBox.Location = new System.Drawing.Point(178, 180);
            this.cokeQuantityTextBox.Name = "cokeQuantityTextBox";
            this.cokeQuantityTextBox.Size = new System.Drawing.Size(57, 27);
            this.cokeQuantityTextBox.TabIndex = 2;
            this.cokeQuantityTextBox.TextChanged += new System.EventHandler(this.cokeQuantityTextBox_TextChanged);
            // 
            // friesQuantityTextBox
            // 
            this.friesQuantityTextBox.Enabled = false;
            this.friesQuantityTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.friesQuantityTextBox.Location = new System.Drawing.Point(178, 142);
            this.friesQuantityTextBox.Name = "friesQuantityTextBox";
            this.friesQuantityTextBox.Size = new System.Drawing.Size(57, 27);
            this.friesQuantityTextBox.TabIndex = 2;
            this.friesQuantityTextBox.TextChanged += new System.EventHandler(this.friesQuantityTextBox_TextChanged);
            // 
            // burgerQuantityTextBox
            // 
            this.burgerQuantityTextBox.Enabled = false;
            this.burgerQuantityTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.burgerQuantityTextBox.Location = new System.Drawing.Point(178, 100);
            this.burgerQuantityTextBox.Name = "burgerQuantityTextBox";
            this.burgerQuantityTextBox.Size = new System.Drawing.Size(57, 27);
            this.burgerQuantityTextBox.TabIndex = 2;
            this.burgerQuantityTextBox.TextChanged += new System.EventHandler(this.burgerQuantityTextBox_TextChanged);
            // 
            // hotDogQuantityTextBox
            // 
            this.hotDogQuantityTextBox.Enabled = false;
            this.hotDogQuantityTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hotDogQuantityTextBox.Location = new System.Drawing.Point(178, 60);
            this.hotDogQuantityTextBox.Name = "hotDogQuantityTextBox";
            this.hotDogQuantityTextBox.Size = new System.Drawing.Size(57, 27);
            this.hotDogQuantityTextBox.TabIndex = 2;
            this.hotDogQuantityTextBox.TextChanged += new System.EventHandler(this.hotDogQuantityTextBox_TextChanged);
            // 
            // cokePriceTextBox
            // 
            this.cokePriceTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cokePriceTextBox.Location = new System.Drawing.Point(106, 180);
            this.cokePriceTextBox.Name = "cokePriceTextBox";
            this.cokePriceTextBox.ReadOnly = true;
            this.cokePriceTextBox.Size = new System.Drawing.Size(57, 27);
            this.cokePriceTextBox.TabIndex = 2;
            this.cokePriceTextBox.Text = "70";
            // 
            // friesPriceTextBox
            // 
            this.friesPriceTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.friesPriceTextBox.Location = new System.Drawing.Point(106, 142);
            this.friesPriceTextBox.Name = "friesPriceTextBox";
            this.friesPriceTextBox.ReadOnly = true;
            this.friesPriceTextBox.Size = new System.Drawing.Size(57, 27);
            this.friesPriceTextBox.TabIndex = 2;
            this.friesPriceTextBox.Text = "50";
            // 
            // burgerPriceTextBox
            // 
            this.burgerPriceTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.burgerPriceTextBox.Location = new System.Drawing.Point(106, 100);
            this.burgerPriceTextBox.Name = "burgerPriceTextBox";
            this.burgerPriceTextBox.ReadOnly = true;
            this.burgerPriceTextBox.Size = new System.Drawing.Size(57, 27);
            this.burgerPriceTextBox.TabIndex = 2;
            this.burgerPriceTextBox.Text = "110";
            // 
            // hotDogPriceTextBox
            // 
            this.hotDogPriceTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hotDogPriceTextBox.Location = new System.Drawing.Point(106, 60);
            this.hotDogPriceTextBox.Name = "hotDogPriceTextBox";
            this.hotDogPriceTextBox.ReadOnly = true;
            this.hotDogPriceTextBox.Size = new System.Drawing.Size(57, 27);
            this.hotDogPriceTextBox.TabIndex = 2;
            this.hotDogPriceTextBox.Text = "65";
            // 
            // toPayGroupBox
            // 
            this.toPayGroupBox.Controls.Add(this.pictureBox1);
            this.toPayGroupBox.Controls.Add(this.toPayAllLabel);
            this.toPayGroupBox.Controls.Add(this.label9);
            this.toPayGroupBox.Controls.Add(this.toCalculateAllButton);
            this.toPayGroupBox.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toPayGroupBox.Location = new System.Drawing.Point(12, 309);
            this.toPayGroupBox.Name = "toPayGroupBox";
            this.toPayGroupBox.Size = new System.Drawing.Size(530, 210);
            this.toPayGroupBox.TabIndex = 1;
            this.toPayGroupBox.TabStop = false;
            this.toPayGroupBox.Text = "Всего к оплате";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::BestOil.Properties.Resources.luckycat;
            this.pictureBox1.Location = new System.Drawing.Point(10, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // toPayAllLabel
            // 
            this.toPayAllLabel.AutoSize = true;
            this.toPayAllLabel.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toPayAllLabel.Location = new System.Drawing.Point(358, 145);
            this.toPayAllLabel.Name = "toPayAllLabel";
            this.toPayAllLabel.Size = new System.Drawing.Size(78, 39);
            this.toPayAllLabel.TabIndex = 0;
            this.toPayAllLabel.Text = "0,00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(478, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "руб.";
            // 
            // toCalculateAllButton
            // 
            this.toCalculateAllButton.BackColor = System.Drawing.Color.White;
            this.toCalculateAllButton.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toCalculateAllButton.Location = new System.Drawing.Point(175, 56);
            this.toCalculateAllButton.Name = "toCalculateAllButton";
            this.toCalculateAllButton.Size = new System.Drawing.Size(177, 128);
            this.toCalculateAllButton.TabIndex = 0;
            this.toCalculateAllButton.Text = "Рассчитать";
            this.toCalculateAllButton.UseVisualStyleBackColor = false;
            this.toCalculateAllButton.Click += new System.EventHandler(this.toCalculateAllButton_Click);
            // 
            // shiftTimer
            // 
            this.shiftTimer.Interval = 10000;
            this.shiftTimer.Tick += new System.EventHandler(this.shiftTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(554, 531);
            this.Controls.Add(this.toPayGroupBox);
            this.Controls.Add(this.cafeGroupBox);
            this.Controls.Add(this.gasStationGroupBox);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(570, 570);
            this.MinimumSize = new System.Drawing.Size(570, 570);
            this.Name = "Form1";
            this.Text = "Автозаправка";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.gasStationGroupBox.ResumeLayout(false);
            this.gasStationGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gasStationToPayGB.ResumeLayout(false);
            this.gasStationToPayGB.PerformLayout();
            this.cafeGroupBox.ResumeLayout(false);
            this.cafeGroupBox.PerformLayout();
            this.cafeToPayGroupBox.ResumeLayout(false);
            this.cafeToPayGroupBox.PerformLayout();
            this.toPayGroupBox.ResumeLayout(false);
            this.toPayGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gasStationGroupBox;
        private System.Windows.Forms.GroupBox cafeGroupBox;
        private System.Windows.Forms.GroupBox toPayGroupBox;
        private System.Windows.Forms.Label petrolLabel;
        private System.Windows.Forms.ComboBox petrolLitersComboBox;
        private System.Windows.Forms.GroupBox gasStationToPayGB;
        private System.Windows.Forms.TextBox petrolPriceTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label petrolPriceLabel;
        private System.Windows.Forms.Label gasStationToPayLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton petrolPriceRadioButton;
        private System.Windows.Forms.RadioButton petrolQuantityRadioButton;
        private System.Windows.Forms.TextBox petrolSumPriceTextBox;
        private System.Windows.Forms.TextBox petrolLitersTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox cafeToPayGroupBox;
        private System.Windows.Forms.Label cafeToPaylabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox hotDogQuantityTextBox;
        private System.Windows.Forms.TextBox hotDogPriceTextBox;
        private System.Windows.Forms.TextBox burgerPriceTextBox;
        private System.Windows.Forms.CheckBox cokeCheckBox;
        private System.Windows.Forms.CheckBox friesCheckBox;
        private System.Windows.Forms.CheckBox burgerCheckBox;
        private System.Windows.Forms.CheckBox hotDogCheckBox;
        private System.Windows.Forms.TextBox cokeQuantityTextBox;
        private System.Windows.Forms.TextBox friesQuantityTextBox;
        private System.Windows.Forms.TextBox burgerQuantityTextBox;
        private System.Windows.Forms.TextBox cokePriceTextBox;
        private System.Windows.Forms.TextBox friesPriceTextBox;
        private System.Windows.Forms.Label toPayAllLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button toCalculateAllButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer shiftTimer;
    }
}

