using System;
using CursoProg.Entities;
namespace CursoProg
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001,"Alex",0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0, 500);

            //UPCASTING
            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0, 200);
            Account acc3 = new SavingsAccount(1004, "Ana", 0, 0.01);

            //DONWCASTING
            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100);
            //BusinessAccount acc5 = (BusinessAccount)acc3;
            //vai dar o erro InvalidCastException
            //---> O acc3 apesar de estar numa variavel Account...
            //ele foi instanciado como um SavingsAccount, e o compilador não consegue fazer essa diferenciação de primeira
            //portanto é necessario usar a
            //Palavra reservada 'is' 
            if (acc3 is BusinessAccount) 
            {
                //BusinessAccount acc5 = (BusinessAccount)acc3;
                BusinessAccount acc5 = acc3 as BusinessAccount; //Sintaxe alternativa
                acc5.Loan(200.0);
                Console.WriteLine("Loan!");
            }
            if (acc3 is SavingsAccount) 
            {
                //SavingsAccount acc5 = (SavingsAccount)acc3;
                SavingsAccount acc5 = acc3 as SavingsAccount; //Sintaxe alternativa
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }

        }
    }
}
