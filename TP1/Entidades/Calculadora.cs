using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// Recibe dos valores de tipo Numero y un operador para realizar el cálculo
        /// </summary>
        /// <param name="primerNumero">Primer numero para operar</param>
        /// <param name="segundoNumero">Segundo numero para operar</param>
        /// <param name="operador">Operador para seleccionar operación</param>
        /// <returns>devuelve el resultado en formato String de lograrse la operación, sino retorna "0"</returns>
        public static double Operar(Numero primerNumero, Numero segundoNumero, string operador)
        {
            string operacion;
            double resultado = 0;

            operacion = ValidarOperador(operador);

            switch(operacion)
            {
                case "+":
                    resultado = primerNumero + segundoNumero;
                    break;
                case "-":
                    resultado = primerNumero - segundoNumero;
                    break;
                case "*":
                    resultado = primerNumero * segundoNumero;
                    break;
                case "/":
                    resultado = primerNumero / segundoNumero;
                    break;
            }
            return resultado;
        }

        /// <summary>
        /// Verifica que el string recibido sea un operador válido
        /// </summary>
        /// <param name="operador">Operador para validar</param>
        /// <returns>retorna el operador recibido de cumplir la validación, sino retorna "+"</returns>
        private static string ValidarOperador(string operador)
        {
            if(operador == "+" || operador == "-" || operador == "*" || operador == "/")
            {
                return operador;
            }
            else
            {
                return "+";
            }
        }
    }
}