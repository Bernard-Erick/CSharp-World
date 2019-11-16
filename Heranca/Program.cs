using System;
using CursoProg.Entities;
namespace CursoProg
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(8010,"Erick Bernardo",100.0,500.0);
            Console.WriteLine(account.Balance);
            //account.Balance = 20;
        }
    }
}
