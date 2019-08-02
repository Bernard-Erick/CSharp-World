using System;
using System.Globalization;
namespace CursoProg
{
    class Program
    {
        static void Main(string[] args)
        {
            //double x = null ====> error
            //A linguagem não aceita
            //Então..
            //Use as seguintes sintaxes
            Nullable<double> y = null; //Syntax 1
            double? z = null; //Syntax 2
            //Ambas permitiram que você atribua "null" ao tipo double
            Console.WriteLine(y.GetValueOrDefault()); //Se não tiver nada ele pega o valor Padrão do tipo
            Console.WriteLine(z.GetValueOrDefault()); //Se não tiver nada ele pega o valor Padrão do tipo
            Console.WriteLine(y.HasValue); //Se tiver algum valor ele retorna true se não false
            Console.WriteLine(z.HasValue); //Se tiver algum valor ele retorna true se não false
            //Console.WriteLine(y.Value); se o valor da variável for null esse comando quebra o código
            //Console.WriteLine(z.Value); se o valor da variável for null esse comando quebra o código
            //Então esse comando pode ser usado da seguinte forma:
            if (y.HasValue)//se tiver um valor
            {
                Console.WriteLine(y.Value);//mostre ele
            }
            else //se não
            {
                Console.WriteLine("Y is null!");//exiba essa frase
            }
            if (z.HasValue)//se tiver um valor
            {
                Console.WriteLine(z.Value);//mostre ele
            }
            else // se não
            {
                Console.WriteLine("Z is null!");//exiba essa frase
            }
            //Ultima sintaxe
            double? a = null;
            double? b = a ?? 5; //(se "a" não for "null" coloque "a" na variável "b" se não coloque 5 no lugar)
            Console.WriteLine(b);//retorna 5
        }

    }


}
