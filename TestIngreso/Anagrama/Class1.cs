using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public static class Anagrama
    {
        public static int Solution(string a, string b)
        {
            string[] texto = a.Split(' ');
            int contadorLetras = 0;
            int contadorPalabras = 0;
            int flagCoincidencia;
        
            for (int i = 0; i < texto.Length; i++) //Este for recorre el texto
            {
                contadorLetras = 0;

                for (int j = 0; j < texto[i].Length; j++) //Este for recorre el primer string 
                {
                    flagCoincidencia = 0;

                    for (int k = 0; k < b.Length; k++) //Este for recorre el segundo string
                    {
                        if(texto[i][j] == b[k] && flagCoincidencia == 0) //Si coincide la letra se cuenta, solo 1 ocurrencia
                        {
                            contadorLetras++;
                            flagCoincidencia = 1;
                        }
                    }

                    if (contadorLetras == b.Length)
                    {
                        contadorPalabras++;
                    }
                }            
            }
            return contadorPalabras;
        }
    }
}
