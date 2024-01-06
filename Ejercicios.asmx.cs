using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace EjerciciosFuncionesDani
{
    /// <summary>
    /// Descripción breve de Ejercicios
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class Ejercicios : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }

        [WebMethod]

        public string SaludarConNombre(string nombre)
        {
            return "¡Hola, " + nombre + "! Bienvenido al servicio web.";
        }

        [WebMethod]

        public int Sumar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }



        [WebMethod]
        public int CalcularFactorial(int numero)
        {
            if (numero == 0 || numero == 1)
            {
                return 1;
            }
            else
            {
                return numero * CalcularFactorial(numero - 1);
            }
        }

        [WebMethod]
        public int BinarioADecimal(string binario)
        {
            int longitud = binario.Length;
            int numeroDecimal = 0;

            for (int i = 0; i < longitud; i++)
            {
                if (binario[i] == '1')
                {
                    int potencia = longitud - i - 1;
                    numeroDecimal += (int)Math.Pow(2, potencia);
                }
            }

            return numeroDecimal;
        }



        [WebMethod]
        public string DecimalABinario(int numero)
        {
            if (numero == 0)
            {
                return "0";
            }

            string binario = "";

            while (numero > 0)
            {
                int residuo = numero % 2;
                binario = residuo.ToString() + binario;
                numero = numero / 2;
            }

            return binario;
        }


        [WebMethod]

        public string DecimalAHexadecimal(int numero)
        {
            if (numero == 0)
            {
                return "0"; 
            }

            string hexadecimal = "";
            string caracteresHex = "0123456789ABCDEF";

            while (numero > 0)
            {
                int residuo = numero % 16;
                hexadecimal = caracteresHex[residuo] + hexadecimal;
                numero = numero / 16;
            }

            return hexadecimal;
        }
    }

}
