using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace HandleApp
{
    /// <summary>
    /// Класс параметров ручки, содержащий информацию о длине задней 
    /// и передней части, диаметре отвертия и  задей части, 
    /// и о количетве вырезов 
    /// </summary>
    public class HandleParameters
    {
        /// <summary>
        /// Диаметр задней части ручки
        /// </summary>
        [Display(Name = "Диаметр задней части")]
        [Range(3d, 4d)]
        public double BackDiameter { get; private set; }

        /// <summary>
        /// Длина задней части ручки
        /// </summary>
        [Display(Name = "Длина задней части")]
        [Range(2d, 4d)]
        public double BackLenght { get; private set; }

        /// <summary>
        /// Длина передней части ручки
        /// </summary>
        [Display(Name = "Длина передней части части")]
        [Range(2d, 4d)]
        public double FrontLenght { get; private set; }

        /// <summary>
        /// Диаметр отверстия ручки
        /// </summary>
        [Display(Name = "Диаметр отверстия")]
        [Range(1d, 2d)]
        public double HoleDiameter { get; private set; }

        /// <summary>
        /// Количество вырезов на ручке
        /// </summary>
        [Display(Name = "Количество вырезов")]
        [Range(2, 5)]
        public int NotchCount { get; private set; }

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="backDiameter">Радиус задней части руки</param>
        /// <param name="backLenght">Длина задней части ручки</param>
        /// <param name="frontLenght">Длина передней асти ручки</param>
        /// <param name="holeDiameter">Радиус тверстия ручки</param>
        /// <param name="notchCount">Количество вырезов на передней части</param>
        public HandleParameters(double backDiameter, double backLenght, 
            double frontLenght, double holeDiameter, int notchCount)
        {
            BackDiameter = backDiameter;
            BackLenght = backLenght;
            FrontLenght = frontLenght;
            HoleDiameter = holeDiameter;
            NotchCount = notchCount;


            var allParameters = new Dictionary<string, dynamic>()
            {
                {nameof(BackDiameter), BackDiameter},
                {nameof(BackLenght), BackLenght},
                {nameof(FrontLenght), FrontLenght},
                {nameof(HoleDiameter), HoleDiameter},
                {nameof(NotchCount) , NotchCount},
            };

            Validate(allParameters);
        }

        /// <summary>
        /// Метод валидации параметров типа int на допустимый диапозон
        /// </summary>
        /// <param name="parameters">Параметры детали</param>
        private void Validate(Dictionary<string, dynamic> parameters)
        {
            var rangeErrorMessage = string.Empty;
            var nanErrorMessage = string.Empty;
            var infErrorMessage = string.Empty;

            foreach (var keyValuePair in parameters)
            {
                var currentProp = typeof(HandleParameters).GetProperty(keyValuePair.Key);
                var paramName = GetAttribute<DisplayAttribute>(currentProp).Name;
                var paramMaximum = GetAttribute<RangeAttribute>(currentProp).Maximum;
                var paramMinimum = GetAttribute<RangeAttribute>(currentProp).Minimum;
                var paramType = currentProp.PropertyType;

                if (paramType == typeof(double))
                {
                    nanErrorMessage += NanValidate(keyValuePair.Value, paramName);
                    infErrorMessage += InfValidate(keyValuePair.Value, paramName);
                    rangeErrorMessage += RangeValidate<double>(keyValuePair.Value, paramName, paramMinimum, paramMaximum);
                }
                else if (paramType == typeof(int))
                {
                    rangeErrorMessage += RangeValidate<int>(keyValuePair.Value, paramName, paramMinimum, paramMaximum);
                }
            }
            if (nanErrorMessage != string.Empty)
            {
                throw new FormatException(string.Join("\n", nanErrorMessage));
            }
            if (infErrorMessage != string.Empty)
            {
                throw new FormatException(string.Join("\n", infErrorMessage));
            }
            if (rangeErrorMessage != string.Empty)
            {
                throw new ArgumentException(string.Join("\n", rangeErrorMessage));
            }
        }

        /// <summary>
        /// Метод получения аттрибута
        /// </summary>
        /// <typeparam name="AttributeType">Тип возвращаемого атрибута</typeparam>
        /// <param name="currentProp">Текущее свойство класса</param>
        /// <returns></returns>
        private AttributeType GetAttribute<AttributeType>(PropertyInfo currentProp)
        {
            return currentProp.GetCustomAttributes(typeof(AttributeType), false).Cast<AttributeType>().FirstOrDefault();
        }

        /// <summary>
        /// Метод проверки параметра на допустимые значения
        /// </summary>
        /// <typeparam name="Type">Тип параметра</typeparam>
        /// <param name="parameter">Значение параметра</param>
        /// <param name="name">Название параметра</param>
        /// <param name="minimum">Минимальное значение</param>
        /// <param name="maximum">Максимальное значение</param>
        private string RangeValidate<Type>(dynamic parameter, string name, object minimum, object maximum)
        {
            if (parameter < (Type)minimum || parameter > (Type)maximum)
            {
                return ($"Значение поля {name} должно быть от {minimum} до {maximum}\t");
            }
            return string.Empty;
        }

        /// <summary>
        /// Метод проверки параметра типа double на Nan
        /// </summary>
        /// <param name="parameter">Значение параметра</param>
        /// <param name="name">Название параметра</param>
        private string NanValidate(dynamic parameter, string name)
        {
            if (double.IsNaN(parameter))
            {
                return ($"Значение поля {name} не число");
            }
            return string.Empty;
        }

        /// <summary>
        /// Метод проверки параметра типа double на бексонечность
        /// </summary>
        /// <param name="parameter">Значение параметра</param>
        /// <param name="name">Название параметра</param>
        private string InfValidate(dynamic parameter, string name)
        {
            if (double.IsInfinity(parameter))
            {
                return ($"Значение поля {name} равно бесконечности");
            }

            return string.Empty;
        }
    }
}
