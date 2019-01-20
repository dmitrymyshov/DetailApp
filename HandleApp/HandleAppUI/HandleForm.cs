using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using HandleApp;
using System.Text.RegularExpressions;

namespace HandleAppUI
{
    public partial class HandleForm : Form
    {
        public HandleForm()
        {
            InitializeComponent();

            var displayMode = new List<string>()
                {"Каркас", "Без невидимых линий",
                    "Невидимые линии тонкие", "Полутоновой"};

            foreach (var element in displayMode)
            {
                DisplayModeСomboBox.Items.Add(element);
            }

            _connector = new KompasConnector();
        }

        /// <summary>
        /// Взаимодействие с Компас-3D
        /// </summary>
        private KompasConnector _connector;

        private void StartKompasButton_Click(object sender, EventArgs e)
        {
            _connector.StartKompas();

            SetFormView(false, true, true, false, true);
        }

        private void CloseKompasButton_Click(object sender, EventArgs e)
        {
            _connector.CloseKompas3D();

            SetFormView(true, false, false, false, false);
        }

        private void CreateDetailButton_Click(object sender, EventArgs e)
        {
            var errorMessage = new List<string>();
            var dict = new Dictionary<TextBox, string>
            {
                {BackDiameterTextBox, "Диаметр задней части ручки введен некорректно"},
                {BackLenghtTextBox, "Длина задней части ручки введена некорректно"},
                {FrontLenghtTextBox, "Длина передней части ручки введена некорректно"},
                {HoleDiameterTextBox, "Диаметр отверстия ручки введен некорректно"},
            };
            var valueParams = new List<double>();
            foreach (var keyValuePair in dict)
            {
                var curentParameter = 0.0;
                if (!double.TryParse(keyValuePair.Key.Text, out curentParameter))
                {
                    errorMessage.Add(keyValuePair.Value);
                }

                valueParams.Add(curentParameter);
            }

            if (!int.TryParse(NotchCountTextBox.Text, out int notchCount))
            {
                errorMessage.Add("Количество вырезов ручки введено некорректно");
            }

            if (errorMessage.Count > 0)
            {
                ShowMessage(string.Join("\n", errorMessage));
                return;
            }

            try
            {
                var parameters = new HandleParameters(valueParams[0], 
                    valueParams[1], valueParams[2], valueParams[3], notchCount);
                var builder = new HandleBuilder(_connector.Kompas);

                builder.CreateDetail(parameters);
                SetFormView(false, true, true, true, true);
            }
            catch (FormatException ex)
            {
                ShowMessage(ex.Message);
                return;
            }
            catch (ArgumentException ex)
            {
                ShowMessage(ex.Message);
                return;
            }
            catch (COMException)
            {
                ShowMessage("Невозможно построить деталь так как Компас закрыт");
                SetFormView(true, false, false, false, true);
                return;
            }
        }

        private void ValidateDoubleTextBoxs_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Regex.IsMatch(e.KeyChar.ToString(), @"[\d\b,]");
        }

        private void ValidateIntTextBoxs_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Regex.IsMatch(e.KeyChar.ToString(), @"[\d\b]");
        }

        /// <summary>
        /// Вывод сообщение об ошибке
        /// </summary>
        /// <param name="message">сообщение об ошибке</param>
        private void ShowMessage(string message)
        {
            MessageBox.Show(message,
                "Предупреждение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }

        private void CreateSpecButton_Click(object sender, EventArgs e)
        {
            var spec = new SpecificationCreator(_connector.Kompas);
            var specParameters = new List<string>()
            {
                DocDesignationTB.Text,
                DocNameTB.Text,
                DetailDesignationTB.Text,
                DetailNameTB.Text,
                DeatilCountTB.Text,
                GostTB.Text,
                StampNameTB.Text,
                StampDesignationTB.Text,
                DeveloperTB.Text,
                TeacherTB.Text
            };
            spec.CreateSpec(specParameters);
        }

        private void DisplayModeСomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DisplayModeСomboBox.SelectedIndex == -1)
            {
                return;
            }
            _connector.SelectDisplayMode(DisplayModeСomboBox.SelectedIndex);
        }

        /// <summary>
        /// Метод, задающий возможность взаимодействия элементов
        /// </summary>
        /// <param name="starButton">Кнопка "Запуск"</param>
        /// <param name="createButton">Кнопка "Построить"</param>
        /// <param name="closeButton">Кнопка "Закрыть"</param>
        /// <param name="comboBox">Выпадающий список</param>
        /// <param name="createSpecButton">Кнопка "Создать"</param>
        private void SetFormView(bool starButton, bool createButton, bool closeButton, bool comboBox, bool createSpecButton)
        {
            StartKompasButton.Enabled = starButton;
            CreateDetailButton.Enabled = createButton;
            CloseKompasButton.Enabled = closeButton;
            DisplayModeСomboBox.Enabled = comboBox;
            CreateSpecButton.Enabled = createSpecButton;
            DisplayModeСomboBox.SelectedIndex = -1;
        }
    }
}
