using System;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace WornkingWithFiles
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var inputFilePath = @"file.txt";

            string sr = File.OpenText(inputFilePath).ReadToEnd();

            Console.WriteLine(sr);


            string sr2 = new StreamReader(inputFilePath).ReadToEnd();
            




        }

    }
}
