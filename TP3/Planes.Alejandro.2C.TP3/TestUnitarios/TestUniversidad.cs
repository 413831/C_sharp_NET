using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EntidadesAbstractas;
using Clases_Instanciables;
using Archivos;
using Excepciones;

namespace TestUnitarios
{
    [TestClass]
    public class TestUniversidad
    {
        [TestMethod]
        [ExpectedException(typeof(AlumnoRepetidoException))]
        public void TestAlumnoRepetidoException()
        {
            //Arrange
            Alumno alumnoUno;
            Alumno alumnoDos;
            Universidad universidad;

            //Act
            alumnoUno = new Alumno(2, "Juan", "Perez", "33333333", Persona.ENacionalidad.Argentino, Universidad.EClases.Programacion);
            alumnoDos = new Alumno(2, "Pepito", "Pereyra", "12341234", Persona.ENacionalidad.Argentino, Universidad.EClases.Legislacion);
            universidad = new Universidad();


            universidad += alumnoUno;
            universidad += alumnoDos;
            //Assert
        }

        [TestMethod]
        [ExpectedException(typeof(NacionalidadInvalidaException))]
        public void TestDniInvalidoException()
        {
            //Arrange
            Alumno alumno;

            //Act
            alumno = new Alumno(1, "Nachito", "Gómez", "91119999",
                                Persona.ENacionalidad.Argentino,
                                Universidad.EClases.Legislacion,
                                Alumno.EEstadoCuenta.AlDia);
            //Assert
        }

        [TestMethod]
        [ExpectedException(typeof(DniInvalidoException))]
        public void TestNumeroDni()
        {
            //Arrange
            Profesor profesor;

            //Act
            profesor = new Profesor(1,"Patricio","Giménez","0",Persona.ENacionalidad.Extranjero);

            //Assert
            Assert.AreNotEqual(0, profesor.Dni);
        }

        [TestMethod]
        public void TestListadoAlumnosNulo()
        {
            //Arrange
            Universidad universidad;

            //Act
            universidad = new Universidad();

            //Assert
            Assert.IsNotNull(universidad.Alumnos);
        }
    }
}
