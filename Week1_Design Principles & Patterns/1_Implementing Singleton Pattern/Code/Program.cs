using System;
using SingletonPatternExample;
class Program
    {
    static void Main(string[] args)
    {
        Logger log1 = Logger.Instance();
        Console.Write("Enter a message:");
        string message = Console.ReadLine() ?? "Hello";
        log1.Logs(message);


        Logger log2 = Logger.Instance();
        Console.Write("Enter a message:");
        message = Console.ReadLine() ?? "Hello";
        log2.Logs(message);
            


            
        }
    }