using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ej3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorPrestamo.Tests
{
    [TestClass()]
    public class GestorPrestamosTests
    {
        [TestMethod()]
        public void EsValidaNoClienteTest()
        {   // NoCliente que cumple todo menos el monto maximo a pedir
            Empleo empleo = new Empleo(5500, new DateTime(1998,1,15));
            Cliente cliente = new Cliente("Anacleto", "Piedrabuena", new DateTime(1945,5,7), empleo);
            SolicitudPrestamo solicitud = new SolicitudPrestamo(cliente, 25000, 10);
            GestorPrestamos devuelve = new GestorPrestamos();
            Assert.IsFalse(devuelve.EsValida(solicitud));
        }

        [TestMethod()]
        public void EsValidaClienteTest()
        {   // Cliente que cumple todo
            Empleo empleo = new Empleo(5500, new DateTime(1998, 1, 15));
            Cliente cliente = new Cliente("Anacleto", "Piedrabuena", new DateTime(1945, 5, 7), empleo);
            cliente.TipoCliente = TipoCliente.Cliente;
            SolicitudPrestamo solicitud = new SolicitudPrestamo(cliente, 100000, 30);
            GestorPrestamos devuelve = new GestorPrestamos();
            Assert.IsTrue(devuelve.EsValida(solicitud));
        }

        [TestMethod()]
        public void EsValidaClienteTest1()
        {   // Cliente que NO cumple con la antigüedad
            Empleo empleo = new Empleo(5500, new DateTime(2016, 9, 15));
            Cliente cliente = new Cliente("Anacleto", "Piedrabuena", new DateTime(1945, 5, 7), empleo);
            cliente.TipoCliente = TipoCliente.Cliente;
            SolicitudPrestamo solicitud = new SolicitudPrestamo(cliente, 100000, 30);
            GestorPrestamos devuelve = new GestorPrestamos();
            Assert.IsFalse(devuelve.EsValida(solicitud));
        }

        [TestMethod()]
        public void EsValidaClienteGoldTest()
        {   // ClienteGold que NO cumple cantidad de cuotas
            Empleo empleo = new Empleo(5500, new DateTime(1998, 1, 15));
            Cliente cliente = new Cliente("Anacleto", "Piedrabuena", new DateTime(1945, 5, 7), empleo);
            cliente.TipoCliente = TipoCliente.ClienteGold;
            SolicitudPrestamo solicitud = new SolicitudPrestamo(cliente, 100000, 90);
            GestorPrestamos devuelve = new GestorPrestamos();
            Assert.IsFalse(devuelve.EsValida(solicitud));
        }

        [TestMethod()]
        public void EsValidaClienteTest2()
        {   // Cliente que NO cumple Edad (menor a 18)
            Empleo empleo = new Empleo(5500, new DateTime(2014, 1, 15));
            Cliente cliente = new Cliente("Anacleto", "Piedrabuena", new DateTime(2000, 5, 7), empleo);
            SolicitudPrestamo solicitud = new SolicitudPrestamo(cliente, 100000, 60);
            GestorPrestamos devuelve = new GestorPrestamos();
            Assert.IsFalse(devuelve.EsValida(solicitud));
        }

        [TestMethod()]
        public void EsValidaClientePremiumTest()
        {   // ClientePremium que NO cumple Edad (mayor a 75)
            Empleo empleo = new Empleo(5500, new DateTime(1945, 1, 15));
            Cliente cliente = new Cliente("Anacleto", "Piedrabuena", new DateTime(1900, 5, 7), empleo);
            cliente.TipoCliente = TipoCliente.ClientePremium;
            SolicitudPrestamo solicitud = new SolicitudPrestamo(cliente, 1025.25, 12);
            GestorPrestamos devuelve = new GestorPrestamos();
            Assert.IsFalse(devuelve.EsValida(solicitud));
        }

        [TestMethod()]
        public void EsValidaClientePremiumTest1()
        {   // ClientePremium que cumple Todo
            Empleo empleo = new Empleo(5500, new DateTime(1990, 1, 15));
            Cliente cliente = new Cliente("Anacleto", "Piedrabuena", new DateTime(1945, 5, 7), empleo);
            cliente.TipoCliente = TipoCliente.ClientePremium;
            SolicitudPrestamo solicitud = new SolicitudPrestamo(cliente, 10080, 58);
            GestorPrestamos devuelve = new GestorPrestamos();
            Assert.IsTrue(devuelve.EsValida(solicitud));
        }
    }
}