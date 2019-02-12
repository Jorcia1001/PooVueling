using NUnit.Framework;

namespace PooVueling.NUnitV.Integration.Test
{
    [TestFixture]
    public class CalculadoraTest
    {
        ICalculadora iCalculadora = new Calculadora();

        [TestCase(4, 2, 2)]
        public void DivisionTest(int num1, int num2, int resultado)
        {
            Assert.IsTrue(iCalculadora.Division(num1, num2) == resultado);
        }

        [TestCase(4, 2, 2)]
        public void DivisionByZero(int num1, int num2, int resultado)
        {
            Assert.IsTrue(iCalculadora.Division(num1, num2) == resultado);
        }


        [TestCase(3, 3, 9)]
        public void MultiplicacionTest(int num1, int num2, int resultado)
        {
            Assert.IsTrue(iCalculadora.Multiplicacion(num1, num2) == resultado);
        }


        [TestCase(9, 9, 0)]

        public void RestaTest(int num1, int num2, int resultado)
        {
            Assert.IsTrue(iCalculadora.Resta(num1, num2) == resultado);
        }

        [TestCase(4, 4, 8)]
        public void SumaTest(int num1, int num2, int resultado)
        {
            Assert.IsTrue(iCalculadora.Suma(num1, num2) == resultado);
        }
    }
}
