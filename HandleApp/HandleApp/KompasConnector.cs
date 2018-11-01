using System;
using Kompas6API5;


namespace HandleApp
{

    public class KompasConnector
    {
        private KompasObject _kompas;


        public void StartKompas()
        {
            if (_kompas == null)
            {
                var type = Type.GetTypeFromProgID("KOMPAS.Application.5");
                _kompas = (KompasObject)Activator.CreateInstance(type);
            }

            if (_kompas != null)
            {
                _kompas.Visible = true;
                _kompas.ActivateControllerAPI();
            }
        }


        public void CloseKompas3D()
        {
            try
            {
                _kompas.Quit();
                _kompas = null;
            }
            catch
            {
                _kompas = null;
            }

        }

        public KompasObject Kompas
        {
            get { return _kompas; }
            set { _kompas = value; }
        }
    }
}
