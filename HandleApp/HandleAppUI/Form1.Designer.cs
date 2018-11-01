namespace HandleAppUI
{
    partial class Form1
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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartKompasButton
            // 
            this.StartKompasButton.Location = new System.Drawing.Point(52, 19);
            this.StartKompasButton.Name = "StartKompasButton";
            this.StartKompasButton.Size = new System.Drawing.Size(75, 23);
            this.StartKompasButton.TabIndex = 0;
            this.StartKompasButton.Text = "Запуск";
            this.StartKompasButton.UseVisualStyleBackColor = true;
            this.StartKompasButton.Click += new System.EventHandler(this.StartKompasButton_Click);
            // 
            // CloseKompasButton
            // 
            this.CloseKompasButton.Enabled = false;
            this.CloseKompasButton.Location = new System.Drawing.Point(161, 19);
            this.CloseKompasButton.Name = "CloseKompasButton";
            this.CloseKompasButton.Size = new System.Drawing.Size(75, 23);
            this.CloseKompasButton.TabIndex = 1;
            this.CloseKompasButton.Text = "Закрыть";
            this.CloseKompasButton.UseVisualStyleBackColor = true;
            this.CloseKompasButton.Click += new System.EventHandler(this.CloseKompasButton_Click);
            // 
            // CreateDetailButton
            // 
            this.CreateDetailButton.Enabled = false;
            this.CreateDetailButton.Location = new System.Drawing.Point(108, 187);
            this.CreateDetailButton.Name = "CreateDetailButton";
            this.CreateDetailButton.Size = new System.Drawing.Size(75, 23);
            this.CreateDetailButton.TabIndex = 2;
            this.CreateDetailButton.Text = "Построить";
            this.CreateDetailButton.UseVisualStyleBackColor = true;
            this.CreateDetailButton.Click += new System.EventHandler(this.CreateDetailButton_Click);
            // 
            // BackLenghtTextBox
            // 
            this.BackLenghtTextBox.Location = new System.Drawing.Point(181, 62);
            this.BackLenghtTextBox.Name = "BackLenghtTextBox";
            this.BackLenghtTextBox.Size = new System.Drawing.Size(92, 20);
            this.BackLenghtTextBox.TabIndex = 3;
            this.BackLenghtTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDoubleTextBoxs_KeyPress);
            // 
            // BackDiameterTextBox
            // 
            this.BackDiameterTextBox.Location = new System.Drawing.Point(181, 32);
            this.BackDiameterTextBox.Name = "BackDiameterTextBox";
            this.BackDiameterTextBox.Size = new System.Drawing.Size(92, 20);
            this.BackDiameterTextBox.TabIndex = 4;
            this.BackDiameterTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDoubleTextBoxs_KeyPress);
            // 
            // FrontLenghtTextBox
            // 
            this.FrontLenghtTextBox.Location = new System.Drawing.Point(181, 92);
            this.FrontLenghtTextBox.Name = "FrontLenghtTextBox";
            this.FrontLenghtTextBox.Size = new System.Drawing.Size(92, 20);
            this.FrontLenghtTextBox.TabIndex = 5;
            this.FrontLenghtTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDoubleTextBoxs_KeyPress);
            // 
            // HoleDiameterTextBox
            // 
            this.HoleDiameterTextBox.Location = new System.Drawing.Point(181, 122);
            this.HoleDiameterTextBox.Name = "HoleDiameterTextBox";
            this.HoleDiameterTextBox.Size = new System.Drawing.Size(92, 20);
            this.HoleDiameterTextBox.TabIndex = 6;
            this.HoleDiameterTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDoubleTextBoxs_KeyPress);
            // 
            // NotchCountTextBox
            // 
            this.NotchCountTextBox.Location = new System.Drawing.Point(181, 152);
            this.NotchCountTextBox.Name = "NotchCountTextBox";
            this.NotchCountTextBox.Size = new System.Drawing.Size(92, 20);
            this.NotchCountTextBox.TabIndex = 7;
            this.NotchCountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateIntTextBoxs_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CloseKompasButton);
            this.groupBox1.Controls.Add(this.StartKompasButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 57);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Компас - 3D";
            // 
            // groupBox2
            // 
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
            this.groupBox2.Location = new System.Drawing.Point(12, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(301, 221);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Построение ручки для крана";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Количество вырезов";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Диаметр отверстия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Длина передней части";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Длина задней части";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Диаметр задней части";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 308);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "HandleApp";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
    }
}

