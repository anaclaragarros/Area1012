using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area1012
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split(' ');
            string[] valores = strings;
            double a = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double b = double.Parse(valores[1], CultureInfo.InvariantCulture);
            double c = double.Parse(valores[2], CultureInfo.InvariantCulture);

            double triangulo = (a * c) / 2.0;
            double circulo = 3.14159 * c * c;
            double trapezio = ((a + b) * c) / 2.0;
            double quadrado = b * b;
            double retangulo = a * b;

            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));

            Console.ReadKey();
        }

       
        } 
    }


///// Primeira entrada  --> 3.0 4.0 5.2 - Primeira saida --> TRIANGULO: 7.800, CIRCULO: 84.949, TRAPEZIO: 18.200, QUADRADO: 16.000, RETANGULO: 12.000
//// Segunda entrada --> 12.7 10.4 15.2 - Segunda saida --> TRIANGULO: 96.520, CIRCULO: 725.833, TRAPEZIO: 175.560, QUADRADO: 108.160, RETANGULO: 132.080














