using System;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
namespace Uppgift_3_Meddelande
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n ?");
            int rader = int.Parse(Console.ReadLine());
            Console.WriteLine("m ?");
            int columner = int.Parse(Console.ReadLine());
            int[,]column = { { 1, 2, 3, 4, 5 }, { 1, 2, 3, 4, 6 } };
            foreach(int i in column) {
                Console.WriteLine(i);
            }

        }
    }
}