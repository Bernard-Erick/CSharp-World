using System;
using System.Globalization;
using System.Collections.Generic;

namespace CursoProg
{
    class Program 
    {
        static void Main(string[] args) //Main
        {
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();
            HashSet<int> C = new HashSet<int>();
            Console.Write("O curso A possui quantos alunos?");
            int n = int.Parse(Console.ReadLine());
            int aluno;
            Console.WriteLine("Digite o código dos alunos A:");
            for (int i = 0; i < n; i++)
            {
                aluno = int.Parse(Console.ReadLine());
                A.Add(aluno);
            }
            Console.Write("O curso B possui quantos alunos?");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o código dos alunos B:");
            for (int i = 0; i < n; i++)
            {
                aluno = int.Parse(Console.ReadLine());
                B.Add(aluno);
            }
            Console.Write("O curso C possui quantos alunos?");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o código dos alunos C:");
            for (int i = 0; i < n; i++)
            {
                aluno = int.Parse(Console.ReadLine());
                C.Add(aluno);
            }
            HashSet<int> Global = new HashSet<int>();
            Global.UnionWith(A);
            Global.UnionWith(B);
            Global.UnionWith(C);
            Console.WriteLine("Total de Alunos: " + Global.Count);
            Console.WriteLine();
        }      

    }
}


