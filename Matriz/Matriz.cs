using System;
using System.Globalization;
using System.Collections.Generic;

namespace CursoProg
{
    class Program 
    {
        static void Main(string[] args) //Main
        {
            Console.Write("valor do N: ");
            int n = int.Parse(Console.ReadLine());
            int[,] matriz = new int[n, n];
            int neg = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int z = 0; z < matriz.GetLength(1); z++)
                {
                    matriz[i, z] = int.Parse(values[z]);                
                }               
            }
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int z = 0; z < matriz.GetLength(1); z++)
                {
                    if (matriz[i, z] < 0)
                    {
                        neg++;
                    }
                    Console.Write(matriz[i,z]+"   ");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Números negativos: "+neg);

            Console.WriteLine("------------------");
            Console.WriteLine("Diagonal principal:");

            for (int i = 0; i < matriz.GetLength(0); i++) //linhas
            {
                 Console.Write(matriz[i, i] + " ");
            }
        }      

    }
}


