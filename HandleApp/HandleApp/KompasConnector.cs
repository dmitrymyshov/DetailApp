using System;
using Kompas6API5;


namespace HandleApp
{
    /// <summary>
    /// Класс для подключения к Компасу
    /// </summary>
    public class KompasConnector
    {
        /// <summary>
        /// Запуск компаса
        /// </summary>
        public void StartKompas()
        {
            if (Kompas == null)
            {
                var type = Type.GetTypeFromProgID("KOMPAS.Application.5");
                Kompas = (KompasObject)Activator.CreateInstance(type);
            }

            if (Kompas != null)
            {
                Kompas.Visible = true;
                Kompas.ActivateControllerAPI();
            }
        }

        /// <summary>
        /// Закрытие Компаса
        /// </summary>
        public void CloseKompas3D()
        {
            try
            {
                Kompas.Quit();
                Kompas = null;
            }
            catch
            {
                Kompas = null;
            }
        }

        /// <summary>
        /// Метод выбора режима отображения детали
        /// </summary>
        /// <param name="selectedMode">Режим отображения</param>
        public void SelectDisplayMode(int selectedMode)
        {
            var doc3D = (ksDocument3D)Kompas.ActiveDocument3D();
            doc3D.drawMode = selectedMode;
        }

        /// <summary>
        /// Интерфейс API Компас
        /// </summary>
        public KompasObject Kompas { get; set; }
    }
}
