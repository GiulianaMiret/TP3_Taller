using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ej4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorPrestamo.Tests
{
    [TestClass()]
    public class EncriptadoresTests
    {
        [TestMethod()]
        public void AESEncriptarTest()
        {
            EncriptadorAES encrip = new EncriptadorAES("AES");
            Assert.AreEqual("SABvAGwAYQA=", encrip.Encriptar("Hola"));
        }

        [TestMethod()]
        public void AESDesencriptarTest()
        {
            EncriptadorAES encrip = new EncriptadorAES("AES");
            Assert.AreEqual("Hola", encrip.Desencriptar("SABvAGwAYQA="));
        }

        [TestMethod()]
        public void CesarEncriptarTest()
        {
            EncriptadorCesar encrip = new EncriptadorCesar("Cesar", 2);
            Assert.AreEqual("Jqñc", encrip.Encriptar("Hola"));
        }

        [TestMethod()]
        public void CesarDesencriptarTest()
        {
            EncriptadorCesar encrip = new EncriptadorCesar("Cesar", 2);
            Assert.AreEqual("Hola", encrip.Desencriptar("Jqñc"));
        }
    }
}
