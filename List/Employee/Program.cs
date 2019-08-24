using System;
using System.Globalization;
using System.Collections.Generic;

namespace CursoProg
{
    class Program 
    {
        static void Main(string[] args) //Main
        {
            List<Funcionario> list = new List<Funcionario>();
            Console.Write("How many employees will be registered?");
            int num = int.Parse(Console.ReadLine()); //vai me ajudar em dois casos diferentes :-)
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine("Emplyoee #"+i+":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine());
                list.Add(new Funcionario(id, name, salary));
            }
            Console.Write("Enter the employee id that will have salary increase : ");
            num = int.Parse(Console.ReadLine()); //oia eu aqui reaproveitando ela de novo xD
            Funcionario func = list.Find(x => x.Id == num);
            if (func != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                func.incrementaSalario(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }
            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach (Funcionario index in list)
            {
                Console.WriteLine(index);
            }
        }      

    }
}


