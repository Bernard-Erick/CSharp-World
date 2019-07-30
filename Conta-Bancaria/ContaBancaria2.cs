using System;
using System.Globalization;
namespace CursoProg
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria p;
            double valor;
            Console.Write("Entre com o número da conta: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char resposta = char.Parse(Console.ReadLine());
            if (resposta == 's' || resposta == 'S')
            {
                Console.Write("Entre o valor de depósito inicial:");
                valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                p = new ContaBancaria(num, titular, valor);
            }
            else
            {
                p = new ContaBancaria(num, titular);
            }
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(p);
            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            valor = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            p.RealizarDeposito(valor);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(p);
            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            valor = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            p.RealizarSaque(valor);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(p);
        }

    }
    class ContaBancaria
    {

        public string Titular { get; set; }
        public int Numero { get; private set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }
        public ContaBancaria(int numero, string titular, double depositoInicial):this(numero,titular)
        {
            RealizarDeposito(depositoInicial);
        }
        public void RealizarDeposito(double qtd)
        {
            Saldo += qtd;
        }
        public void RealizarSaque(double qtd)
        {
            Saldo = Saldo - qtd - 5;
        }
        public override string ToString()
        {
            return "Conta " + Numero + ", Titular: " + Titular + ", Saldo: $" + Saldo.ToString("F2",CultureInfo.InvariantCulture); 
        }
    }


}
