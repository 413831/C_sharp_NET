using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace IO
{
    public class PuntoTxt : Archivo, IArchivos<string>
    {
        public bool Guardar(string ruta, string objeto)
        {
            StreamWriter archivo;

            if(this.ValidarArchivo(ruta,true))
            {
                archivo = new StreamWriter(ruta);
                archivo.Write(objeto);
                archivo.Close();
                return true;
            }
            return false;
        }

        public bool GuardarComo(string ruta, string objeto)
        {
            StreamWriter archivo;

            archivo = new StreamWriter(ruta);
            archivo.Write(objeto);
            archivo.Close();
            return true;
        }

        public string Leer(string ruta)
        {
            StreamReader archivo;
            String texto;

            try
            {
                archivo = new StreamReader(ruta); //Abro
                texto = archivo.ReadToEnd();
                archivo.Close();
                return texto; 
            }
            catch(FileNotFoundException exception)
            {
                throw new ArchivoIncorrectoException("Archivo inexistente", exception);
            }
        }

        protected override bool ValidarArchivo(string ruta, bool validaExistencia)
        {
            try // REVISAR
            {
                if (base.ValidarArchivo(ruta, validaExistencia))
                {
                    if (Path.GetExtension(ruta) == ".txt")
                    {
                        return true;
                    }
                    else
                    {
                        throw new ArchivoIncorrectoException("El archivo no es un .txt");
                    }
                }
                return false;
            }
            catch (FileNotFoundException exception)
            {
                throw new ArchivoIncorrectoException("El archivo no es correcto.", exception);
            }
        }
    }
}
