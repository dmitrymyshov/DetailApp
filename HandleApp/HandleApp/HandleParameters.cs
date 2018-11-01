using System;

namespace HandleApp
{
    public class HandleParameters
    {
        private double _backDiameter;

        private double _backLenght;

        private double _frontLenght;

        private double _holeDiameter;

        private int _notchCount;

        public double BackDiameter
        {
            get { return _backDiameter; }

            private set {; }
        }

        public double BackLenght
        {
            get { return _backLenght; }

            private set {; }
        }

        public double FrontLenght
        {
            get { return _frontLenght; }

            private set {; }
        }

        public double HoleDiameter
        {
            get { return _holeDiameter; }

            private set {; }
        }

        public int NotchCount
        {
            get { return _notchCount; }

            private set {; }
        }

        public HandleParameters(double backDiameter, double backLenght, double frontLenght, double holeDiameter, int notchCount)
        {
            _backDiameter = backDiameter;
            _backLenght = backLenght;
            _frontLenght = frontLenght;
            _holeDiameter = holeDiameter;
            _notchCount = notchCount;
        }

        public bool Validate()
        {
            if ((BackDiameter < 3 || BackDiameter > 4) || (BackLenght < 2 || BackLenght > 4) 
             || (FrontLenght < 2 || FrontLenght > 4) || (HoleDiameter < 1 || HoleDiameter > 2) 
             || (NotchCount < 2 || NotchCount > 5))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
