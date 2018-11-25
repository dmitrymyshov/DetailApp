using NUnit.Framework;

namespace HandleApp.UnitTest
{
    [TestFixture]
    public class UnitTest1
    {
        private KompasConnector _connector;

        [SetUp]
        public void Test()
        {
            _connector = new KompasConnector();
            _connector.StartKompas();
        }

        [TestCase(3, 2, 2, 1, 2,
            TestName = "Построение ручки1")]
        [TestCase(4, 4, 4, 2, 5,
            TestName = "Построение ручки2")]
        [TestCase(3.1, 2.1, 2.1, 1.1, 3,
            TestName = "Построение ручки3")]
        [TestCase(3.33, 2.33, 2.33, 1.33, 4,
            TestName = "Построение ручки4")]
        [TestCase(3.88, 2.88, 2.88, 1.88, 5,
            TestName = "Построение ручки5")]
        public void TestTitleGetSet_CorrectValue(double backDiameter, 
            double backLenght, double frontLenght, 
            double holeDiameter,int notchCount)
        {
            var parameters = new HandleParameters(backDiameter, backLenght, frontLenght, holeDiameter, notchCount);

            var builder = new HandleBuilder(_connector.Kompas);

            builder.CreateDetail(parameters);
        }
    }
}
