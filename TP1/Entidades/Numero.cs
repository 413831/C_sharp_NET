using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private double numero;

        /// <summary>
        /// Propiedad de solo escritura
        /// </summary>
        public double SetNumero 
        {
            set
            {   
                numero = ValidarNumero(Convert.ToString(value));
            }
        }

        /// <summary>
        /// Valida que el string recibido por parametro sea un número válido
        /// </summary>
        /// <param name="strNumero">Numero para validar</param>
        /// <returns>El número como double sino retorna 0</returns>
        public double ValidarNumero(string strNumero)
        {
            double numeroDouble;

                if (Double.TryParse(strNumero,out numeroDouble))
                {
                    return numeroDouble;
                }
                else
                {
                    return 0;
                }
        }

        //CONSTRUCTORES

        /// <summary>
        /// Constructor que setea el atributo número con el valor recibido por párametro
        /// </summary>
        /// <param name="numero">Valor para setear en atributo numero</param>
        public Numero(double numero)
        {
            this.SetNumero = numero;
        }

        public Numero(): this(0)
        {
        }

        public Numero(string strNumero): this(double.Parse(strNumero))
        {
        }

        //MÉTODOS

        /// <summary>
        /// Recibe string por parámetro para descomponer y convertir en numero decimal
        /// </summary>
        /// <param name="binario">Numero binario para convertir</param>
        /// <returns>numero decimal en formato String si es posible convertir sino retorna mensaje de error</returns>
        public string BinarioDecimal(string binario)
        {
            char[] arrayBinario;
            double numeroDecimal;

            if (binario != "Valor inválido.")
            {
                numeroDecimal = 0;
                arrayBinario = binario.ToCharArray();
                Array.Reverse(arrayBinario);

                for (int i = 0; i < arrayBinario.Length; i++)
                {
                    if(arrayBinario[i] > '1') //Verifica que sea realmente un número binario
                    {
                        return "Valor inválido.";
                    }

                    if (arrayBinario[i] == '1') 
                    {
                        numeroDecimal += (int)Math.Pow(2, i); //Se realiza el calculo de conversión a decimal
                    }
                }
                return Convert.ToString(numeroDecimal);
            }
            else
            {
                return "Valor inválido.";
            }
        }

        /// <summary>
        /// Recibe string por parámetro para descomponer y convertir en numero binario
        /// </summary>
        /// <param name="numeroDecimal">Numero decimal para convertir</param>
        /// <returns>resultado de la conversion en formato String si es posible convertir sino mensaje de error</returns>
        public string DecimalBinario(double numeroDecimal)
        {
            String resultado = "";

            if (numeroDecimal >= 0)
            {
                while (numeroDecimal >= 0)
                {
                    if(numeroDecimal == 0)
                    {
                        resultado = "0" + resultado;
                        break;
                    }
                    else if (numeroDecimal % 2 == 0) //Verifica el resto de la división
                    {
                        resultado = "0" + resultado;//Concatena el resto de la división
                    }
                    else
                    {
                        resultado = "1" + resultado;//Concatena el resto de la división
                    }
                    numeroDecimal = (int)(numeroDecimal / 2); //Sigue dividiendo
                }
            }
            else
            {
                 resultado += "Valor inválido.";
            }
            return resultado;
        }

        public string DecimalBinario(string numeroDecimal)
        {
            if (numeroDecimal != "Valor inválido.")
            {
                return DecimalBinario(double.Parse(numeroDecimal));
            }
            else
            {
                return "Valor inválido.";
            }
        }

        //OPERADORES

        /// <summary>
        /// Resta dos numeros
        /// </summary>
        /// <param name="primerNumero">Primer numero para operar</param>
        /// <param name="segundoNumero">Segundo numero para operar</param>
        /// <returns>Retorna el resultado de la operacion</returns>
        public static double operator -(Numero primerNumero, Numero segundoNumero)
        {
            return primerNumero.numero - segundoNumero.numero;
        }

        /// <summary>
        /// Suma dos numeros
        /// </summary>
        /// <param name="primerNumero">Primer numero para operar</param>
        /// <param name="segundoNumero">Segundo numero para operar</param>
        /// <returns>Retorna el resultado de la operacion</returns>
        public static double operator +(Numero primerNumero, Numero segundoNumero)
        {
            return primerNumero.numero + segundoNumero.numero;
        }

        /// <summary>
        /// Multiplica dos numeros
        /// </summary>
        /// <param name="primerNumero">Primer numero para operar</param>
        /// <param name="segundoNumero">Segundo numero para operar</param>
        /// <returns>Retorna el resultado de la operacion</returns>
        public static double operator *(Numero primerNumero, Numero segundoNumero)
        {
            return primerNumero.numero * segundoNumero.numero;
        }

        /// <summary>
        /// Divide dos numeros
        /// </summary>
        /// <param name="primerNumero">Primer numero para operar</param>
        /// <param name="segundoNumero">Segundo numero para operar</param>
        /// <returns>Retorna el resultado de la operacion si no retorna el mínimo valor de tipo Double</returns>
        public static double operator /(Numero primerNumero, Numero segundoNumero)
        {
            if(segundoNumero.numero == 0)
            {
                return double.MinValue;
            }
            return primerNumero.numero / segundoNumero.numero;
        }
    }
}

