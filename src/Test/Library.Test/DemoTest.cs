using NUnit.Framework;

namespace Library.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            // Insertá tu código de inicialización aquí
        }

        [Test]
        public void DemoTest() // Cambiá el nombre para indicar qué estás probando
        {
            int a = 1;
            int b = 2;

            Assert.AreEqual(a + b, 3);
        }
    }
}