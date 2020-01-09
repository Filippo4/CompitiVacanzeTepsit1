using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework.Internal;

namespace TestCompiti
{
    [TestClass]
    public class TestMetodo
    {
            [TestMethod]
        public void Metodo1Test()
        {
            double media = 3.5;
            double risposta = Metodi.Metodo1();
            Assert.AreEqual(media, risposta);
        }

        [TestMethod]
        public void Metodo2Test()
        {
            double media = 3.5;
            double risposta = Metodi.Metodo2();
            Assert.AreEqual(media, risposta);
        }

        [TestMethod]
        public void Metodo3Test()
        {
            double media = 7;
            double risposta = Metodi.Metodo3();
            Assert.AreEqual(media, risposta);
        }
    }
    }
}
