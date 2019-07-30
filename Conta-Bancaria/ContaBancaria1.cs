using System;
using System.Globalization;
namespace CursoProg
{
    class Program
    {
        
        static void Main(string[] args)
        {
            ContaBancaria p = new ContaBancaria();
            double valor;
            Console.Write("Entre com o número da conta: ");
            int num = int.Parse(Console.ReadLine());
            p.SetNumero(num);
            Console.Write("Entre o titular da conta: ");
            p.Titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            string resposta = Console.ReadLine();
            if (resposta == "s")
            {
                Console.Write("Entre o valor de depósito inicial:");
                valor = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                p.AdicionarDeposito(valor);
            }
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(p);
            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            valor = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            p.AdicionarDeposito(valor);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(p);
            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            valor = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            p.RealizarSaque(valor);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(p);

        }

    }
    class ContaBancaria
    {
        private double _saldo = 0.0;
        private int _numeroDaConta;
        public string Titular;

        public void SetNumero(int num)
        {
            _numeroDaConta = num;
        }
        public void AdicionarDeposito(double dep)
        {
            _saldo += dep;
        }
        public void RealizarSaque(double dep)
        {
            _saldo = _saldo - dep - 5;
        }
        public override string ToString()
        {
            return "Conta " + _numeroDaConta + ", Titular: " + Titular + ", Saldo: $" + _saldo.ToString("F2",CultureInfo.InvariantCulture); 
        }
    }


}
