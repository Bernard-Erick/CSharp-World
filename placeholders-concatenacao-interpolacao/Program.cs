using System;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";
            //PLACEHOLDER
            //declarar as posições e depois chamar as variáveis ao final da frase
            Console.WriteLine("{0} tem {1} anos e tem o saldo de {2} reais",nome,idade,saldo);

            //INTERPOLAÇÃO
            //começar usando o "$" antes da frase e dentro das frases chamar as variáveis dentro de {}
            Console.WriteLine($"{nome} tem {idade} anos e tem o saldo de {saldo} reais");

            //CONCATENAÇÃO
            //Forma padrão de se construir uma frase,consiste em "somar" as variaveis com as frases
            Console.WriteLine(nome+" tem "+idade+" anos e tem o saldo de "+saldo+" reais");
        }
    }
}
