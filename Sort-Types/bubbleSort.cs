using System;
using System.Globalization;
namespace CursoProg
{
    class Program
    {
        static void Main(string[] args) //Main
        {
            int[] numbers = { 60, 35, 18, 8, 14, 41, 3, 60, 80, 90, 20, 51, 60, 30, 5, 63, 2, 30, 5 };
            bubbleSort(numbers);

            for (int i = 0; i < numbers.Length; i++)
                Console.WriteLine(numbers[i]);

        }
        public static int[] bubbleSort(int[] vetor)
        {
            int aux;
            for (int i = 0; i < vetor.Length-1; i++)
            {

                for (int j = 0; j < vetor.Length-1-i; j++)
                {
                    if (vetor[j] > vetor[j + 1])
                    {
                        aux = vetor[j];
                        vetor[j] = vetor[j + 1];
                        vetor[j + 1] = aux;
                    }
                }
            }
            return vetor;
        }


    }


}
