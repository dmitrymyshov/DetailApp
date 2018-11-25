using System;
using Kompas6API5;


namespace HandleApp
{
    /// <summary>
    /// 
    /// </summary>
    public class KompasConnector
    {
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

        public KompasObject Kompas { get; set; }
    }
}
