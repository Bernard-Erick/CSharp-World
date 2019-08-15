using System;
using System.Globalization;
using System.Collections.Generic;
namespace CursoProg
{
    class Program
    {
        static void Main(string[] args) //Main
        {
            List<string> list = new List<string>();
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
            list.Insert(2, "Marco");
            foreach (string index in list)
            {
                Console.WriteLine(index);
            }
            Console.WriteLine("List count: " + list.Count);
            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("First 'A': "+s1);
            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A': "+s2);
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A': "+pos1);
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last position 'A': "+pos2);
            Console.WriteLine("------------------");
            List<string> list2 = list.FindAll(x => x.Length == 5);
            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("-----------------");
            list.Remove("Alex");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("-----------------");
            list.RemoveAll(x => x[0] == 'M');
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("----------------");
            list2.RemoveAt(1);
            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("----------------");
            list2.Add("Marquin");
            list2.Add("Pedrao");
            list2.Add("Carlao");
            list2.RemoveRange(2, 2);
            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }
        }
    }
}


