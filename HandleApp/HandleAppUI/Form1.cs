using System;
using System.Windows.Forms;
using HandleApp;

namespace HandleAppUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            _connector = new KompasConnector();
        }

        private KompasConnector _connector;

        private void StartKompasButton_Click(object sender, EventArgs e)
        {
            _connector.StartKompas();

            CreateDetailButton.Enabled = true;

            CloseKompasButton.Enabled = true;

            StartKompasButton.Enabled = false;
        }

        private void CloseKompasButton_Click(object sender, EventArgs e)
        {
            _connector.CloseKompas3D();

            StartKompasButton.Enabled = true;

            CreateDetailButton.Enabled = false;

            CloseKompasButton.Enabled = false;
        }

        private void CreateDetailButton_Click(object sender, EventArgs e)
        {
            double backDiameter;
            double backLenght;
            double frontLenght;
            double holeDiameter;
            int notchCount;

            try
            {
                backDiameter = double.Parse(BackDiameterTextBox.Text);
                backLenght = double.Parse(BackLenghtTextBox.Text);
                frontLenght = double.Parse(FrontLenghtTextBox.Text);
                holeDiameter = double.Parse(HoleDiameterTextBox.Text);
                notchCount = int.Parse(NotchCountTextBox.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Данные введены некоректно \nВозможно есть пустые поля или лишнии запятые",
                    "Предупреждение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            var parameters = new HandleParameters(backDiameter, backLenght, frontLenght, holeDiameter, notchCount);

            if (!parameters.Validate())
            {
                MessageBox.Show("Параметры введены неправильно \n " +
                                "Диаметр задней части ручки должен быть от 3см до 4см\n " +
                                "Длина задней части должна быть от 2см до 4см\n " +
                                "Длина передней части должна быть от 2см до 4см\n " +
                                "Диаметр отверстия должен быть от 1см до 2см\n " +
                                "Количество вырезов должно быть от 2 до 5\n ",
                    "Предупреждение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var builder = new HandleBuilder(_connector.Kompas);

                builder.CreateDetail(parameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Невозможно построить деталь так как Компас закрыт",
                    "Предупреждение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                StartKompasButton.Enabled = true;

                CreateDetailButton.Enabled = false;

                CloseKompasButton.Enabled = false;

                return;
            }

        }

        private void ValidateDoubleTextBoxs_KeyPress(object sender, KeyPressEventArgs e)
        {
            var symbol = e.KeyChar;
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            e.Handled = !(char.IsDigit(symbol) || symbol == '.' || symbol == ',' || symbol == '\b');
        }

        private void ValidateIntTextBoxs_KeyPress(object sender, KeyPressEventArgs e)
        {
            var symbol = e.KeyChar;

            e.Handled = !(char.IsDigit(symbol) || symbol == '\b');
        }
    }
}
