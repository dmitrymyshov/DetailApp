using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using HandleApp;
using System.Collections.Generic;

namespace HandleAppUI
{
    public partial class HandleForm : Form
    {
        public HandleForm()
        {
            InitializeComponent();

            _connector = new KompasConnector();
        }

        private KompasConnector _connector;

        private void StartKompasButton_Click(object sender, EventArgs e)
        {
            _connector.StartKompas();
            //TODO: duble
            CreateDetailButton.Enabled = true;
            CloseKompasButton.Enabled = true;
            StartKompasButton.Enabled = false;
        }

        private void CloseKompasButton_Click(object sender, EventArgs e)
        {
            _connector.CloseKompas3D();
            //TODO: duble
            StartKompasButton.Enabled = true;
            CreateDetailButton.Enabled = false;
            CloseKompasButton.Enabled = false;
        }

        private void CreateDetailButton_Click(object sender, EventArgs e)
        {
            try
            {
                 var parameters = new HandleParameters(double.Parse(BackDiameterTextBox.Text),
                     double.Parse(BackLenghtTextBox.Text),
                     double.Parse(FrontLenghtTextBox.Text),
                     double.Parse(HoleDiameterTextBox.Text),
                     int.Parse(NotchCountTextBox.Text));

                var builder = new HandleBuilder(_connector.Kompas);
                builder.CreateDetail(parameters);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Данные введены некоректно \nВозможно есть пустые поля или лишнии запятые",
                    "Предупреждение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message,
                    "Предупреждение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            catch (COMException)
            {
                MessageBox.Show("Невозможно построить деталь так как Компас закрыт",
                    "Предупреждение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                //TODO: duble
                StartKompasButton.Enabled = true;
                CreateDetailButton.Enabled = false;
                CloseKompasButton.Enabled = false;

                return;
            }
        }

        private void ValidateDoubleTextBoxs_KeyPress(object sender, KeyPressEventArgs e)
        {
            //TODO: regex
            var symbol = e.KeyChar;
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            e.Handled = !(char.IsDigit(symbol) || symbol == '.' || symbol == ',' || symbol == '\b');
        }

        private void ValidateIntTextBoxs_KeyPress(object sender, KeyPressEventArgs e)
        {
            //TODO: regex
            var symbol = e.KeyChar;

            e.Handled = !(char.IsDigit(symbol) || symbol == '\b');
        }
    }
}
