using System;
using System.Collections.Specialized;
using System.Configuration;
using System.Diagnostics;
using System.IO;

namespace RoundNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            Trace.Listeners.Add(new TextWriterTraceListener(File.CreateText("log.txt")));
            Trace.AutoFlush = true;
            string count = "Count";
            string argument = "Argument";
            Console.WriteLine(format: "{0, -10} {1,0}", arg0: count, arg1: argument);
            string path = @"C:\CSV";
            Console.Write("Press R for readOnly or W for write: ");
            ConsoleKeyInfo key = Console.ReadKey();
            Console.WriteLine();
            Stream s = null;
            if (key.Key == ConsoleKey.R)
            {
                s = File.Open
                    (
                    Path.Combine(path, "file.txt"),
                    FileMode.OpenOrCreate,
                    FileAccess.Read
                    );
            }
            else
            {
                s = File.Open
                    (
                    Path.Combine(path, "file.txt"),
                    FileMode.OpenOrCreate,
                    FileAccess.Write
                    );
            }
            string message = String.Empty;
            switch (s)
            {

                case FileStream writeableFile when s.CanWrite:
                    message = "The stream is a file that I can write to.";
                    break;
                case FileStream readOnlyFile:
                    message = "The stream is a read-only file.";
                    break;
                case MemoryStream ms:
                    message = "The stream is memory address";
                    break;
                default:
                    message = "The stream is some other type";
                    break;
                case null:
                    message = "The stream is null";
                    break;
            }
            Console.WriteLine(message);
            double dNumber1 = 9.45;
            double dNumber2 = 9.50;
            double dNumber3 = 9.51;
            double dNumber4 = 10.45;
            double dNumber5 = 10.50;
            double dNumber6 = 10.51;
            int a = Convert.ToInt32(dNumber1);
            int b = Convert.ToInt32(dNumber2);
            int c = Convert.ToInt32(dNumber3);
            int d = Convert.ToInt32(dNumber4);
            int f = Convert.ToInt32(dNumber5);
            int g = Convert.ToInt32(dNumber6);
            Console.WriteLine("Convert");
            Console.ReadKey(true);
            Console.WriteLine($"{dNumber1} => {a}");
            Console.ReadKey(true);
            Console.WriteLine($"{dNumber2} => {b}");
            Console.ReadKey(true);
            Console.WriteLine($"{dNumber3} => {c}");
            Console.ReadKey(true);
            Console.WriteLine($"{dNumber4} => {d}");
            Console.ReadKey(true);
            Console.WriteLine($"{dNumber5} => {f}");
            Console.ReadKey(true);
            Console.WriteLine($"{dNumber6} => {g}");
            Console.WriteLine("Round");
            Console.ReadKey(true);
            Console.WriteLine($"{dNumber1} => {Math.Round(dNumber1, 0, MidpointRounding.AwayFromZero)}");
            Console.ReadKey(true);
            Console.WriteLine($"{dNumber2} => {Math.Round(dNumber2, 0, MidpointRounding.AwayFromZero)}");
            Console.ReadKey(true);
            Console.WriteLine($"{dNumber3} => {Math.Round(dNumber3, 0, MidpointRounding.AwayFromZero)}");
            Console.ReadKey(true);
            Console.WriteLine($"{dNumber4} => {Math.Round(dNumber4, 0, MidpointRounding.AwayFromZero)}");
            Console.ReadKey(true);
            Console.WriteLine($"{dNumber5} => {Math.Round(dNumber5, 0, MidpointRounding.AwayFromZero)}");
            Console.ReadKey(true);
            Console.WriteLine($"{dNumber6} => {Math.Round(dNumber6, 0, MidpointRounding.AwayFromZero)}");
            Debug.WriteLine("Debug, says, I'm watching");
            Trace.WriteLine("Trace, says, I'm watching");
            NameValueCollection items = ConfigurationManager.AppSettings;
            foreach (string name in items.Keys)
            {
                Console.WriteLine($"{name} - {items[name]}");
            }
        
        }
    }
}
