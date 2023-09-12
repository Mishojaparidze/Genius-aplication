using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Xml;

namespace Xml_Json
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // task1();
            //task2(10);
            //task3("abcdefgh12", 5);
            DateTime x = new DateTime(2023,09,15);
            task4(x);


        }
        static void task1()
        {
            string path = @"C:\Users\misho\source\repos\test\Xml-Json\file.txt";

            if (!File.Exists(path))
            {
                using (File.Create(path))
                {
                    Console.WriteLine("File is created!");
                }

                File.AppendAllText(path, "Text 1" + Environment.NewLine);
                File.AppendAllText(path, "Text 2" + Environment.NewLine);
                File.AppendAllText(path, "Text 3" + Environment.NewLine);
                File.AppendAllText(path, "Text 4" + Environment.NewLine);
                File.AppendAllText(path, "Text 5");

            }
            else
            {
                Console.WriteLine("File already exists!");
            }


            int x;
            Console.WriteLine("Enter number from range 1-5:");
            var check = int.TryParse(Console.ReadLine(), out x);

            if (check)
            {
                if (x > 5 || x < 1)
                {
                    Console.WriteLine("Please enter number from range 1-5");
                }
                else
                {
                    using (StreamReader sr = new StreamReader(path))
                    {
                        string line;
                        int i = 1;
                        while ((line = sr.ReadLine()) != null)
                        {

                            if (i == x)
                            {
                                Console.WriteLine(line);
                                break;
                            }

                            i++;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Please enter integer number");
            }
        }
        static void task2(int n)
        {

            string path = @"C:\Users\misho\source\repos\test\Xml-Json\task2.txt";

            for (int i = 1; i < n; i++)
            {
                File.AppendAllText(path, $"{i} * {n} = {i * n} \n");
            }
        }
        static void task3(string text, int parts)
        {
            int textLength = text.Length; // Giorgi -> 

            List<string> stringList = new List<string>();

            string con = "";
            int i = 0;

            if (text.Length % parts != 0)
            {
                Console.WriteLine("Ar ikofa");
            }
            else
            {
                int partsForText = textLength / parts; // Giorgi 3 -> "Gi" "or" "gi"
                foreach (char n in text)
                {
                    con += n;
                    i++;
                    if (i % partsForText == 0)
                    {
                        stringList.Add(con);
                        con = "";
                    }

                }
            }

            XmlDocument xmlDoc = new XmlDocument();
            XmlElement rootElement = xmlDoc.CreateElement("Root");
            xmlDoc.AppendChild(rootElement);

            for (i = 0; i < stringList.Count; i++)
            {
                XmlElement itemElement = xmlDoc.CreateElement(stringList[i]);
                itemElement.InnerText = $"Value for number: {i + 1}";
                rootElement.AppendChild(itemElement);
            }



            xmlDoc.Save(@"C:\Users\misho\source\repos\test\Xml-Json\XMLfile.xml");




        }
        static void task4(DateTime birthDate)
        {
            DateTime todayDate = DateTime.Today;
            var answer =(birthDate-todayDate).Days;
            Console.WriteLine(answer);

            string jsonData = JsonSerializer.Serialize(answer);
            string filePath = @"C:\Users\misho\source\repos\test\Xml-Json\JsonFile.json";
            File.WriteAllText(filePath, jsonData);


        }
    }
}
