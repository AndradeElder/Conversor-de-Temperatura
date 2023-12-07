using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Conversor_de_Temperatura
{
    internal class Program
    {
        static void Main()
        {

            Console.WriteLine("====================================");
            Console.WriteLine("===== Conversor de temperatura =====");
            Console.WriteLine("==================================== \n");

            Console.WriteLine("Digite o valor em ºC para converter: \n");
            var tempC = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Valor: " + tempC + " ºC");

            Console.WriteLine("Os Resultados da conversão são: \n");

            var tempF = ((tempC * 9) / 5) + 32;
            Console.WriteLine("Temperatura em Fahrenheit:  " + tempF + " ºF");
            var tempK = tempC + 273.15;
            Console.WriteLine("Temperatura em Kelvin:  " + tempK + " ºK \n");
            Console.WriteLine("==================================== \n");
            Console.WriteLine("Espero ter ajudado. =D \n");



            Console.ReadLine();

            
        }
    }
}
