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
            string num1 = "1";
            string esperado = "Uno";
            LetraController lit = new LetraController();


            //Act=ejecution
            string resultado = lit.numeroget(num1);

            //Assert=Verification
            Assert.AreEqual(esperado, resultado);


        }
        [Test]
        public void Letra2()
        {
            //Arrange=preparacion
            string num1 = "2";
            string esperado = "Dos";
            LetraController lit = new LetraController();


            //Act=ejecution
            string resultado = lit.numeroget(num1);

            //Assert=Verification
            Assert.AreEqual(esperado, resultado);


        }
        [Test]
        public void Letra3()
        {
            //Arrange=preparacion
            string num1 = "3";
            string esperado = "Tres";
            LetraController lit = new LetraController();


            //Act=ejecution
            string resultado = lit.numeroget(num1);

            //Assert=Verification
            Assert.AreEqual(esperado, resultado);


        }
        [Test]
        public void Letra4()
        {
            //Arrange=preparacion
            string num1 = "2";
            string esperado = "Dos";
            LetraController lit = new LetraController();


            //Act=ejecution
            string resultado = lit.numeroget(num1);

            //Assert=Verification
            Assert.AreEqual(esperado, resultado);


        }
    }
}