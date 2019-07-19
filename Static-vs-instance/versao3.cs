using System;
using System.Globalization;
namespace CursoProg
{
    /*Versão 2: Classe calculadora com método estático 
    *Fazer um programa para ler um valor numérico qualquer, e daí mostrar
    *quanto seria o valor de uma circunferência e do volume de uma esfera
    *para um raio daquele valor. Informar também o valor de PI com duas
    *casas decimais.
    */

    class Program
    {
        
        static void Main(string[] args)
        {


            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);
            Console.WriteLine("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor do PI: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }

    }
    class Calculadora
    {
        public static double Pi = 3.14;
        public static double Circunferencia(double r)
        {
            return 2.0 * Pi * r;
        }
        public static double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * r * r * r;
        }
    }


}
