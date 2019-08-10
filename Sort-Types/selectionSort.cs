using System;
using System.Globalization;
namespace CursoProg
{
    class Program
    {
        static void Main(string[] args) //Main
        {
            int[] vetor = { 20, 35, 18, 8, 14, 41, 3, 39 };
            selectionSort(vetor);
            for (int i = 0; i < vetor.Length - 1; i++)
                Console.Write(vetor[i]+", ");
        }
        static int[] selectionSort(int[] vetor)
        {
            for (int i = 0; i < vetor.Length - 1; i++)
            {
                int menor = vetor[i];
                int posicaoMenor = i;
                for (int z = i + 1; z < vetor.Length; z++)
                {
                    if (vetor[z] < menor)
                    {
                        menor = vetor[z];
                        posicaoMenor = z;
                    }

                }
                vetor[posicaoMenor] = vetor[i];
                vetor[i] = menor;
            }
            
            return vetor;
        }



    }


}
