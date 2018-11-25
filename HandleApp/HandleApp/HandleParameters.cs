using System;
using System.Collections.Generic;

namespace HandleApp
{
    /// <summary>
    /// Класс параметров ручки, содержащий информацию о длине задней 
    /// и передней части, диаметре отвертия и  задей части, 
    /// и о количетве вырезов 
    /// </summary>
    public class HandleParameters
    {
        public double BackDiameter { get; private set; }

        public double BackLenght { get; private set; }

        public double FrontLenght { get; private set; }

        public double HoleDiameter { get; private set; }

        public int NotchCount { get; private set; }

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="backDiameter">Радиус задней части руки</param>
        /// <param name="backLenght">Длина задней части ручки</param>
        /// <param name="frontLenght">Длина передней асти ручкиparam>
        /// <param name="holeDiameter">Радиус тверстия ручки</param>
        /// <param name="notchCount">Количество вырезов на передней части</param>
        public HandleParameters(double backDiameter, double backLenght, 
            double frontLenght, double holeDiameter, int notchCount)
        {
            //TODO: Проверка на NaN, Inf
            BackDiameter = backDiameter;
            BackLenght = backLenght;
            FrontLenght = frontLenght;
            HoleDiameter = holeDiameter;
            NotchCount = notchCount;

            Validating();
        }

        /// <summary>
        /// Клас валидации диапозона допустимых зачений
        /// </summary>
        private void Validating()
        {
            var errorMessage = new List<string>();

            if (BackDiameter < 3 || BackDiameter > 4)
            {
                errorMessage.Add("Диаметр задней части ручки должен быть от 3см до 4см\n ");
            }
            if (BackLenght < 2 || BackLenght > 4)
            {
                errorMessage.Add("Длина задней части должна быть от 2см до 4см\n ");
            }
            if (FrontLenght < 2 || FrontLenght > 4)
            {
                errorMessage.Add("Длина передней части должна быть от 2см до 4см\n ");
            }
            if (HoleDiameter < 1 || HoleDiameter > 2)
            {
                errorMessage.Add("Диаметр отверстия должен быть от 1см до 2см\n ");
            }
            if (NotchCount < 2 || NotchCount > 5)
            {
                errorMessage.Add("Количество вырезов должно быть от 2 до 5\n ");
            }

            if (errorMessage.Count != 0)
            {
                var error = string.Empty;

                foreach (string element in errorMessage)
                {
                    error += element;
                }
                throw new ArgumentException(error);
            }
        }
    }
}
