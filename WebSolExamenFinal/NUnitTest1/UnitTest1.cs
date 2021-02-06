using NUnit.Framework;
using WebExamenFinal.Controllers;

namespace NUnitTest1
{
    public class TestLetra
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Letra()
        {
            //Arrange=preparacion
            string num1 = "5";
            string esperado = "Cinco";
            LetraController lit = new LetraController();


            //Act=ejecution
            string resultado = lit.numeroget(num1);

            //Assert=Verification
            Assert.AreEqual(esperado, resultado);


        }
        public void Letra1()
        {
            //Arrange=preparacion
            string num1 = "0";
            string esperado = "Cero";
            LetraController lit = new LetraController();


            //Act=ejecution
            string resultado = lit.numeroget(num1);

            //Assert=Verification
            Assert.AreEqual(esperado, resultado);


        }
    }
}