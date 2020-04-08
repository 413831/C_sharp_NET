using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace TestPaquetes
{
    [TestClass]
    public class TestUnitario
    {
        [TestMethod]
        public void TestListaPaquetes()
        {
            //arrange
            Correo correo;

            //act
            correo = new Correo();

            //assert
            Assert.IsNotNull(correo.Paquetes);
        }

        [TestMethod]
        [ExpectedException(typeof(TrackingIdRepetidoException))]
        public void TestTrackingIdRepetido()
        {
            //arrange
            Correo correo;
            Paquete paqueteUno;
            Paquete paqueteDos;

            //act
            correo = new Correo();
            paqueteUno = new Paquete("Direccion 1", "111");
            paqueteDos = new Paquete("Direccion 2", "111");

            correo += paqueteUno; // Agrego paquete uno
            correo += paqueteDos; // Intento agregar paquete dos
            //assert
            
            Assert.IsFalse(correo.Paquetes.Contains(paqueteDos)); // Verifico si el segundo paquete con tracking ID repetido se ingresó
        }
    }
}
