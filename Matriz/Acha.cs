using System;
using System.Globalization;
using System.Collections.Generic;

namespace CursoProg
{
    class Program 
    {
        static void Main(string[] args) //Main
        {
            Console.Write("M:");
            int m = int.Parse(Console.ReadLine());
            Console.Write("N:");
            int n = int.Parse(Console.ReadLine());
            int[,] matriz = new int[m, n];
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                String[] frase = Console.ReadLine().Split(' ');
                for (int z = 0; z < matriz.GetLength(1); z++)
                {
                    matriz[i, z] = int.Parse(frase[z]);
                }
            }
            Console.WriteLine();
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int z = 0; z < matriz.GetLength(1); z++)
                {
                    Console.Write(matriz[i,z]+ "   ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Qual número você quer procurar?");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i, j] == x)
                    {
                        Console.WriteLine("Position " + i + "," + j + ":");
                        if (j > 0)
                        {
                            Console.WriteLine("Left: " + matriz[i, j - 1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + matriz[i - 1, j]);
                        }
                        if (j < n - 1)
                        {
                            Console.WriteLine("Right: " + matriz[i, j + 1]);
                        }
                        if (i < m - 1)
                        {
                            Console.WriteLine("Down: " + matriz  [i + 1, j]);
                        }
                    }
                }
            }
        }      

    }
}


