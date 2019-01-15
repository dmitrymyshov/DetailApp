namespace HandleAppUI
{
    partial class HandleForm
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
            this.StartKompasButton = new System.Windows.Forms.Button();
            this.CloseKompasButton = new System.Windows.Forms.Button();
            this.CreateDetailButton = new System.Windows.Forms.Button();
            this.BackLenghtTextBox = new System.Windows.Forms.TextBox();
            this.BackDiameterTextBox = new System.Windows.Forms.TextBox();
            this.FrontLenghtTextBox = new System.Windows.Forms.TextBox();
            this.HoleDiameterTextBox = new System.Windows.Forms.TextBox();
            this.NotchCountTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DisplayModeСomboBox = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TeacherTB = new System.Windows.Forms.TextBox();
            this.DeveloperTB = new System.Windows.Forms.TextBox();
            this.StampDesignationTB = new System.Windows.Forms.TextBox();
            this.StampNameTB = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.GostTB = new System.Windows.Forms.MaskedTextBox();
            this.DetailDesignationTB = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.DeatilCountTB = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DetailNameTB = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.DocDesignationTB = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DocNameTB = new System.Windows.Forms.TextBox();
            this.CreateSpecButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeatilCountTB)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartKompasButton
            // 
            this.StartKompasButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.StartKompasButton.Location = new System.Drawing.Point(46, 19);
            this.StartKompasButton.MaximumSize = new System.Drawing.Size(75, 23);
            this.StartKompasButton.MinimumSize = new System.Drawing.Size(75, 23);
            this.StartKompasButton.Name = "StartKompasButton";
            this.StartKompasButton.Size = new System.Drawing.Size(75, 23);
            this.StartKompasButton.TabIndex = 0;
            this.StartKompasButton.Text = "Запуск";
            this.StartKompasButton.UseVisualStyleBackColor = true;
            this.StartKompasButton.Click += new System.EventHandler(this.StartKompasButton_Click);
            // 
            // CloseKompasButton
            // 
            this.CloseKompasButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CloseKompasButton.Enabled = false;
            this.CloseKompasButton.Location = new System.Drawing.Point(155, 19);
            this.CloseKompasButton.MaximumSize = new System.Drawing.Size(75, 23);
            this.CloseKompasButton.MinimumSize = new System.Drawing.Size(75, 23);
            this.CloseKompasButton.Name = "CloseKompasButton";
            this.CloseKompasButton.Size = new System.Drawing.Size(75, 23);
            this.CloseKompasButton.TabIndex = 1;
            this.CloseKompasButton.Text = "Закрыть";
            this.CloseKompasButton.UseVisualStyleBackColor = true;
            this.CloseKompasButton.Click += new System.EventHandler(this.CloseKompasButton_Click);
            // 
            // CreateDetailButton
            // 
            this.CreateDetailButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CreateDetailButton.Enabled = false;
            this.CreateDetailButton.Location = new System.Drawing.Point(102, 202);
            this.CreateDetailButton.Name = "CreateDetailButton";
            this.CreateDetailButton.Size = new System.Drawing.Size(75, 23);
            this.CreateDetailButton.TabIndex = 2;
            this.CreateDetailButton.Text = "Построить";
            this.CreateDetailButton.UseVisualStyleBackColor = true;
            this.CreateDetailButton.Click += new System.EventHandler(this.CreateDetailButton_Click);
            // 
            // BackLenghtTextBox
            // 
            this.BackLenghtTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BackLenghtTextBox.Location = new System.Drawing.Point(181, 69);
            this.BackLenghtTextBox.Name = "BackLenghtTextBox";
            this.BackLenghtTextBox.Size = new System.Drawing.Size(79, 20);
            this.BackLenghtTextBox.TabIndex = 3;
            this.BackLenghtTextBox.Text = "3,25";
            this.BackLenghtTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDoubleTextBoxs_KeyPress);
            // 
            // BackDiameterTextBox
            // 
            this.BackDiameterTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BackDiameterTextBox.Location = new System.Drawing.Point(181, 39);
            this.BackDiameterTextBox.Name = "BackDiameterTextBox";
            this.BackDiameterTextBox.Size = new System.Drawing.Size(79, 20);
            this.BackDiameterTextBox.TabIndex = 4;
            this.BackDiameterTextBox.Text = "3,25";
            this.BackDiameterTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDoubleTextBoxs_KeyPress);
            // 
            // FrontLenghtTextBox
            // 
            this.FrontLenghtTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.FrontLenghtTextBox.Location = new System.Drawing.Point(181, 99);
            this.FrontLenghtTextBox.Name = "FrontLenghtTextBox";
            this.FrontLenghtTextBox.Size = new System.Drawing.Size(79, 20);
            this.FrontLenghtTextBox.TabIndex = 5;
            this.FrontLenghtTextBox.Text = "3,25";
            this.FrontLenghtTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDoubleTextBoxs_KeyPress);
            // 
            // HoleDiameterTextBox
            // 
            this.HoleDiameterTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.HoleDiameterTextBox.Location = new System.Drawing.Point(181, 129);
            this.HoleDiameterTextBox.Name = "HoleDiameterTextBox";
            this.HoleDiameterTextBox.Size = new System.Drawing.Size(79, 20);
            this.HoleDiameterTextBox.TabIndex = 6;
            this.HoleDiameterTextBox.Text = "1,85";
            this.HoleDiameterTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDoubleTextBoxs_KeyPress);
            // 
            // NotchCountTextBox
            // 
            this.NotchCountTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NotchCountTextBox.Location = new System.Drawing.Point(181, 159);
            this.NotchCountTextBox.Name = "NotchCountTextBox";
            this.NotchCountTextBox.Size = new System.Drawing.Size(79, 20);
            this.NotchCountTextBox.TabIndex = 7;
            this.NotchCountTextBox.Text = "5";
            this.NotchCountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateIntTextBoxs_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.CloseKompasButton);
            this.groupBox1.Controls.Add(this.StartKompasButton);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 55);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Компас - 3D";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.CreateDetailButton);
            this.groupBox2.Controls.Add(this.NotchCountTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.HoleDiameterTextBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.FrontLenghtTextBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.BackDiameterTextBox);
            this.groupBox2.Controls.Add(this.BackLenghtTextBox);
            this.groupBox2.Location = new System.Drawing.Point(6, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(288, 236);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Построение ручки для крана";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Количество вырезов:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Диаметр отверстия:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Длина передней части:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Длина задней части:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Диаметр задней части:";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(308, 403);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(300, 377);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Деталь";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DisplayModeСomboBox);
            this.groupBox3.Location = new System.Drawing.Point(6, 312);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(361, 62);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Режимы отображения детали";
            // 
            // DisplayModeСomboBox
            // 
            this.DisplayModeСomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DisplayModeСomboBox.Enabled = false;
            this.DisplayModeСomboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DisplayModeСomboBox.FormattingEnabled = true;
            this.DisplayModeСomboBox.Location = new System.Drawing.Point(6, 24);
            this.DisplayModeСomboBox.Name = "DisplayModeСomboBox";
            this.DisplayModeСomboBox.Size = new System.Drawing.Size(207, 21);
            this.DisplayModeСomboBox.TabIndex = 0;
            this.DisplayModeСomboBox.SelectedIndexChanged += new System.EventHandler(this.DisplayModeСomboBox_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.CreateSpecButton);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(300, 377);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Спецификация";
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.TeacherTB);
            this.groupBox6.Controls.Add(this.DeveloperTB);
            this.groupBox6.Controls.Add(this.StampDesignationTB);
            this.groupBox6.Controls.Add(this.StampNameTB);
            this.groupBox6.Location = new System.Drawing.Point(13, 201);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(280, 131);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Штамп";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 100);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "Проверил:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Разработал:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(134, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Обозначение документа:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Название изделия:";
            // 
            // TeacherTB
            // 
            this.TeacherTB.Location = new System.Drawing.Point(148, 97);
            this.TeacherTB.Name = "TeacherTB";
            this.TeacherTB.Size = new System.Drawing.Size(126, 20);
            this.TeacherTB.TabIndex = 8;
            // 
            // DeveloperTB
            // 
            this.DeveloperTB.Location = new System.Drawing.Point(148, 71);
            this.DeveloperTB.Name = "DeveloperTB";
            this.DeveloperTB.Size = new System.Drawing.Size(126, 20);
            this.DeveloperTB.TabIndex = 7;
            // 
            // StampDesignationTB
            // 
            this.StampDesignationTB.Location = new System.Drawing.Point(148, 45);
            this.StampDesignationTB.Name = "StampDesignationTB";
            this.StampDesignationTB.Size = new System.Drawing.Size(126, 20);
            this.StampDesignationTB.TabIndex = 6;
            // 
            // StampNameTB
            // 
            this.StampNameTB.Location = new System.Drawing.Point(148, 19);
            this.StampNameTB.Name = "StampNameTB";
            this.StampNameTB.Size = new System.Drawing.Size(126, 20);
            this.StampNameTB.TabIndex = 5;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.GostTB);
            this.groupBox5.Controls.Add(this.DetailDesignationTB);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.DeatilCountTB);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.DetailNameTB);
            this.groupBox5.Location = new System.Drawing.Point(6, 94);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(288, 101);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Деталь";
            // 
            // GostTB
            // 
            this.GostTB.Location = new System.Drawing.Point(216, 71);
            this.GostTB.Mask = "999-99";
            this.GostTB.Name = "GostTB";
            this.GostTB.Size = new System.Drawing.Size(66, 20);
            this.GostTB.TabIndex = 9;
            // 
            // DetailDesignationTB
            // 
            this.DetailDesignationTB.Location = new System.Drawing.Point(107, 19);
            this.DetailDesignationTB.Mask = "99-99-99-99-99-99";
            this.DetailDesignationTB.Name = "DetailDesignationTB";
            this.DetailDesignationTB.Size = new System.Drawing.Size(175, 20);
            this.DetailDesignationTB.TabIndex = 8;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(158, 74);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "ГОСТ №:";
            // 
            // DeatilCountTB
            // 
            this.DeatilCountTB.Location = new System.Drawing.Point(107, 71);
            this.DeatilCountTB.Name = "DeatilCountTB";
            this.DeatilCountTB.Size = new System.Drawing.Size(45, 20);
            this.DeatilCountTB.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Количество:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Наименование:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Обозначение:";
            // 
            // DetailNameTB
            // 
            this.DetailNameTB.Location = new System.Drawing.Point(107, 45);
            this.DetailNameTB.Name = "DetailNameTB";
            this.DetailNameTB.Size = new System.Drawing.Size(175, 20);
            this.DetailNameTB.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.DocDesignationTB);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.DocNameTB);
            this.groupBox4.Location = new System.Drawing.Point(6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(288, 82);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Документация";
            // 
            // DocDesignationTB
            // 
            this.DocDesignationTB.Location = new System.Drawing.Point(107, 22);
            this.DocDesignationTB.Mask = "99-99-99-99-99-99-LL";
            this.DocDesignationTB.Name = "DocDesignationTB";
            this.DocDesignationTB.Size = new System.Drawing.Size(175, 20);
            this.DocDesignationTB.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Обозначение:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Наименование:";
            // 
            // DocNameTB
            // 
            this.DocNameTB.Location = new System.Drawing.Point(107, 48);
            this.DocNameTB.Name = "DocNameTB";
            this.DocNameTB.Size = new System.Drawing.Size(175, 20);
            this.DocNameTB.TabIndex = 1;
            // 
            // CreateSpecButton
            // 
            this.CreateSpecButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CreateSpecButton.Enabled = false;
            this.CreateSpecButton.Location = new System.Drawing.Point(109, 339);
            this.CreateSpecButton.MaximumSize = new System.Drawing.Size(75, 23);
            this.CreateSpecButton.MinimumSize = new System.Drawing.Size(75, 23);
            this.CreateSpecButton.Name = "CreateSpecButton";
            this.CreateSpecButton.Size = new System.Drawing.Size(75, 23);
            this.CreateSpecButton.TabIndex = 0;
            this.CreateSpecButton.Text = "Создать";
            this.CreateSpecButton.UseVisualStyleBackColor = true;
            this.CreateSpecButton.Click += new System.EventHandler(this.CreateSpecButton_Click);
            // 
            // HandleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 427);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimumSize = new System.Drawing.Size(320, 330);
            this.Name = "HandleForm";
            this.Text = "HandleApp";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeatilCountTB)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartKompasButton;
        private System.Windows.Forms.Button CloseKompasButton;
        private System.Windows.Forms.Button CreateDetailButton;
        private System.Windows.Forms.TextBox BackLenghtTextBox;
        private System.Windows.Forms.TextBox BackDiameterTextBox;
        private System.Windows.Forms.TextBox FrontLenghtTextBox;
        private System.Windows.Forms.TextBox HoleDiameterTextBox;
        private System.Windows.Forms.TextBox NotchCountTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button CreateSpecButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox DisplayModeСomboBox;
        private System.Windows.Forms.TextBox StampNameTB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox DetailNameTB;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DocNameTB;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TeacherTB;
        private System.Windows.Forms.TextBox DeveloperTB;
        private System.Windows.Forms.TextBox StampDesignationTB;
        private System.Windows.Forms.NumericUpDown DeatilCountTB;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MaskedTextBox DocDesignationTB;
        private System.Windows.Forms.MaskedTextBox DetailDesignationTB;
        private System.Windows.Forms.MaskedTextBox GostTB;
    }
}

