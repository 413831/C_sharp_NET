using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace IO
{
    [Serializable]
    public class PuntoDat : Archivo, IArchivos<PuntoDat>
    {
        private string contenido;

        public string Contenido
        {
            get
            {
                return this.contenido;
            }
            set
            {
                this.contenido = value;
            }
        }

        public bool Guardar(string ruta, PuntoDat objeto) //REVISAR
        {
            FileStream archivo;
            BinaryFormatter serializador;
            
            if(this.ValidarArchivo(ruta,true))
            {
                archivo = new FileStream(ruta, FileMode.Open); // Abro archivo existente
                serializador = new BinaryFormatter();

                serializador.Serialize(archivo, objeto);
                archivo.Close();
                return true;
            }
            return false;
        }

        public bool GuardarComo(string ruta, PuntoDat objeto)
        {
            FileStream archivo;
            BinaryFormatter serializador;

            archivo = new FileStream(ruta, FileMode.Create); // Creo nuevo archivo
            serializador = new BinaryFormatter();

            serializador.Serialize(archivo, objeto);
            archivo.Close();

            return true;
        }

        public PuntoDat Leer(string ruta)
        {
            FileStream archivo;
            BinaryFormatter serializador;
            PuntoDat objeto;

            try
            {
                archivo = new FileStream(ruta, FileMode.Open); // Abro archivo
                serializador = new BinaryFormatter();

                objeto = (PuntoDat)serializador.Deserialize(archivo); //REVISAR
                archivo.Close();

                return objeto;
            }
            catch(FileNotFoundException exception)
            {
                throw new ArchivoIncorrectoException("Archivo inexistente", exception); //REVISAR
            }
        }

        protected override bool ValidarArchivo(string ruta, bool validaExistencia)
        {
            try
            {
                if (base.ValidarArchivo(ruta, validaExistencia))
                {
                    if(Path.GetExtension(ruta) == ".dat")
                    {
                        return true;
                    }
                    else
                    {
                        throw new ArchivoIncorrectoException("El archivo no es un .dat");
                    }
                }
                return false;
            }
            catch(FileNotFoundException exception)
            {
                throw new ArchivoIncorrectoException("El archivo no es correcto.", exception);
            }
        }
    }
}
