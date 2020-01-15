
using System;
using System.Globalization;
using System.IO;
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\desktop\Desktop\myfolder";

            try
            {              
                //Listar pastas a partir de uma pasta informada
                var  folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS:");
                foreach (string s in folders) 
                {
                    Console.WriteLine(s);
                }

                //Listar arquivos a partidar de uma pasta informada
                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES:");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }
                //Criar uma pasta
                Directory.CreateDirectory(path + "\\newfolder");
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }

        }
    }
}
