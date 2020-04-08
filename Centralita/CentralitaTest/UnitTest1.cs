using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace CentralitaTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestListaLlamadas()
        {
            //arrange
            Centralita central;
            //act
            central = new Centralita("Empresa");
            //assert
            Assert.IsNotNull(central.Llamadas);
        }

        [TestMethod]
        public void TestLlamadaLocalExistente()
        {
            //arrange
            Centralita central;
            Llamada llamadaUno;
            Llamada llamadaDos;
            //act
            central = new Centralita("Emplesa");
            llamadaUno = new Local("Bernal", 30, "Rosario", 2.65f);
            llamadaDos = new Local("idxgmkfd", 45, "Rosario", 2.65f);
            try
            {
                central += llamadaUno;
                central += llamadaDos;
                Assert.Fail("No se lanzo un joraca");//Se lanza un assert exception
            }
            catch (AssertFailedException)//Se puede lanzar una excepcion para casos correctos
            {
                throw;
            }
            catch (CentralitaException exception)
            {
                //Excepcion del error buscado
                //assert
                Assert.Fail(exception.Message);
            }
        }

        [TestMethod]
        public void TestLlamadaProvincialExistente()
        {
            //arrange
            Centralita central;
            Llamada llamadaUno;
            Llamada llamadaDos;
            //act
            central = new Centralita("Emplesa");
            llamadaUno = new Provincial("Morón", Provincial.Franja.Franja_1, 21, "Bernal");
            llamadaDos = new Provincial("Morón", Provincial.Franja.Franja_1, 21, "Bernal");
            try
            {
                central += llamadaUno;
                central += llamadaDos;
                Assert.Fail("No se lanzo un poronga");//Se lanza un assert exception
            }
            catch (AssertFailedException)//Se puede lanzar una excepcion para casos correctos
            {
                throw;
            }
            catch (CentralitaException exception)
            {
                //Excepcion del error buscado
                //assert
                Assert.Fail(exception.Message);
            }
        }

    }
}


