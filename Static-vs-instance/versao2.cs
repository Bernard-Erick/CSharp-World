using System;
using System.Globalization;
namespace CursoProg
{
    /*Versão 2: Classe calculadora com membros de instância. 
    *Fazer um programa para ler um valor numérico qualquer, e daí mostrar
    *quanto seria o valor de uma circunferência e do volume de uma esfera
    *para um raio daquele valor. Informar também o valor de PI com duas
    *casas decimais.
    */

    class Program
    {
        
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();

            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double circ = calc.Circunferencia(raio);
            double volume = calc.Volume(raio);
            Console.WriteLine("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor do PI: " + calc.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }

    }
    class Calculadora
    {
        public double Pi = 3.14;
        public double Circunferencia(double r)
        {
            return 2.0 * Pi * r;
        }
        public double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * r * r * r;
        }
    }


}
