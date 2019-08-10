using System;
using System.Globalization;
namespace CursoProg
{
    class Program
    {
        static void Main(string[] args) //Main
        {
            int[] vetor = { 20, 35, 18, 8, 14, 41, 3, 39 };
            insertionSort(vetor);
            for (int i = 0; i < vetor.Length - 1; i++)
                Console.Write(vetor[i]+", ");
        }
        static int[] insertionSort(int[] vetor)
        {
            int aux;
            int p;
            for (int i = 1; i < vetor.Length; i++)
            {
                aux = vetor[i];
                p = i;
                while (p > 0 && vetor[p - 1] > aux)
                {
                    vetor[p] = vetor[p - 1];
                    p--;
                }
                vetor[p] = aux;
            }
            return vetor;
        }



    }


}
