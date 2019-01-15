using System;
using NUnit.Framework;

namespace HandleApp.UnitTest
{
    [TestFixture]
    public class HandleParametersTest
    {
        private HandleParameters _parameters;

        [SetUp]
        public void Test()
        {
            _parameters = new HandleParameters(3.2, 3.2, 3.2, 1.2, 3);
        }

        [Test(Description = "Позитивный тест коструктора класса HandleParameters")]
        public void TestHandleParametersConstructor_CorrectValue()
        {
            var expectedParameters = new HandleParameters(3.2, 3.2, 3.2, 1.2, 3);
            var actual = _parameters;

            Assert.AreEqual
                (expectedParameters.BackDiameter, actual.BackDiameter, 
                "Неправильное значение в поле BackDiameter");
            Assert.AreEqual
                (expectedParameters.BackLenght, actual.BackLenght, 
                "Неправильное значение в поле BackLenght");
            Assert.AreEqual
                (expectedParameters.FrontLenght, actual.FrontLenght, 
                "Неправильное значение в поле FrontLenght");
            Assert.AreEqual
                (expectedParameters.HoleDiameter, actual.HoleDiameter, 
                "Неправильное значение в поле HoleDiameter");
            Assert.AreEqual
                (expectedParameters.NotchCount, actual.NotchCount, 
                "Неправильное значение в поле NotchCount");
        }

        [TestCase(double.NaN, 3.2, 3.2, 1.2, "backDiameter",
            TestName = "Негативный тест на Nan поля backDiameter")]
        [TestCase(3.2, double.NaN, 3.2, 1.2, "backLenght",
            TestName = "Негативный тест на Nan поля backLenght")]
        [TestCase(3.2, 3.2, double.NaN, 1.2, "frontLenght",
            TestName = "Негативный тест на Nan поля frontLenght")]
        [TestCase(3.2, 3.2, 3.2, double.NaN, "holeDiameter",
            TestName = "Негативный тест на Nan поля holeDiameter")]
        public void TestHandleParametersConstructor_NanValue
            (double backDiameter, double backLenght, double frontLenght, 
            double holeDiameter, string attr)
        {
            Assert.Throws<FormatException>(
                () => { var parameters = new HandleParameters
                    (backDiameter, backLenght, frontLenght, holeDiameter, 3); }, 
                "Должно возникнуть исключение если в поле "+attr+"значение double.Nan");
        }

        [TestCase(double.NegativeInfinity, 3.2, 3.2, 1.2, "backDiameter",
            TestName = "Негативный тест на бесконечность поля backDiameter")]
        [TestCase(3.2, double.NegativeInfinity, 3.2, 1.2, "backLenght",
            TestName = "Негативный тест на бесконечность поля backLenght")]
        [TestCase(3.2, 3.2, double.NegativeInfinity, 1.2, "frontLenght",
            TestName = "Негативный тест на бесконечность поля frontLenght")]
        [TestCase(3.2, 3.2, 3.2, double.NegativeInfinity, "holeDiameter",
            TestName = "Негативный тест на бесконечность поля holeDiameter")]
        [TestCase(double.PositiveInfinity, 3.2, 3.2, 1.2, "backDiameter",
            TestName = "Негативный тест на бесконечность поля backDiameter")]
        [TestCase(3.2, double.PositiveInfinity, 3.2, 1.2, "backLenght",
            TestName = "Негативный тест на бесконечность поля backLenght")]
        [TestCase(3.2, 3.2, double.PositiveInfinity, 1.2, "frontLenght",
            TestName = "Негативный тест на бесконечность поля frontLenght")]
        [TestCase(3.2, 3.2, 3.2, double.PositiveInfinity, "holeDiameter",
            TestName = "Негативный тест на бесконечность поля holeDiameter")]
        public void TestHandleParametersConstructor_InfValue
        (double backDiameter, double backLenght, double frontLenght,
            double holeDiameter, string attr)
        {
            Assert.Throws<FormatException>(
                () => {
                    var parameters = new HandleParameters
                        (backDiameter, backLenght, frontLenght, holeDiameter, 3);
                },
                "Должно возникнуть исключение если поле " + attr + "равно бесконечности");
        }

        [TestCase(4.1, 3.2, 3.2, 1.2, 3, "backDiameter",
            TestName = "Негативный тест поля backDiameter если > 4")]
        [TestCase(3.2, 4.1, 3.2, 1.2, 3, "backLenght",
            TestName = "Негативный тест поля backLenght если > 4")]
        [TestCase(3.2, 3.2, 4.1, 1.2, 3, "frontLenght",
            TestName = "Негативный тест поля frontLenght если > 4")]
        [TestCase(3.2, 3.2, 3.2, 2.1, 3, "holeDiameter",
            TestName = "Негативный тест поля holeDiameter если > 2")]
        [TestCase(3.2, 3.2, 3.2, 2, 6, "notchCount",
            TestName = "Негативный тест поля notchCount если > 5")]
        [TestCase(2.9, 3.2, 3.2, 1.2, 3, "backDiameter",
            TestName = "Негативный тест поля backDiameter если < 3")]
        [TestCase(3.2, 1.9, 3.2, 1.2, 3, "backLenght",
            TestName = "Негативный тест поля backLenght если < 2")]
        [TestCase(3.2, 3.2, 1.9, 1.2, 3, "frontLenght",
            TestName = "Негативный тест поля frontLenght если < 2")]
        [TestCase(3.2, 3.2, 3.2, 0.9, 3, "holeDiameter",
            TestName = "Негативный тест поля holeDiameter если < 1")]
        [TestCase(3.2, 3.2, 3.2, 2, 1, "notchCount",
            TestName = "Негативный тест поля notchCount если < 2")]
        public void TestHandleParametersConstructor_ArgumentValue
        (double backDiameter, double backLenght, double frontLenght,
            double holeDiameter, int notchCount, string attr)
        {
            Assert.Throws<ArgumentException>(
                () => {
                    var parameters = new HandleParameters
                        (backDiameter, backLenght, frontLenght, holeDiameter, notchCount);
                },
                "Должно возникнуть исключение если значение поля " 
                + attr + "выходит за диапозон доп-х значений");
        }
    }
}
