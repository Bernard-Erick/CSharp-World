using System;
using System.Globalization;
namespace CursoProg
{
    class Program //Main
    {

        static void Main(string[] args)
        {
            Retangulo r = new Retangulo(); //instaciar o objeto r

            Console.WriteLine("Entre com a largura e altura do retângulo:");
            r.Altura = double.Parse(Console.ReadLine()); //dando valor ao atributo altura
            r.Largura = double.Parse(Console.ReadLine()); //dando valor ao atributo largura
            Console.WriteLine("ÁREA: "+ r.Area()); //chamando seu método de Área
            Console.WriteLine("PERÍMETRO: "+r.Perimetro()); //chamando seu método de Perímetro
            Console.WriteLine("DIAGONAL: "+r.Diagonal());//chamando seu método de Diagonal
        }

    }
    class Retangulo //Tipo Retangulo
    {
        public double Largura; //atributos sem valor
        public double Altura; //atributos sem valor
        public double Area() //Função área
        {
            return Largura * Altura;
        }
        public double Perimetro() //Função Perímetro
        {
            return 2*(Largura  + Altura);
        }
        public double Diagonal() //Função Diagonal
        {
            return Math.Sqrt(Math.Pow(Largura, 2) + Math.Pow(Altura, 2));
        }
    }

}
