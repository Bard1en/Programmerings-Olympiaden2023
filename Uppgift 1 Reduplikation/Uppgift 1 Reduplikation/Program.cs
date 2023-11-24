using System;
 namespace Uppgift_1_Reduplikation
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Ordet ?(max 9 bokstäver)");
             string ordet = Console.ReadLine();
           Console.WriteLine("Antal upprepningar ?(max 9 upprepningar) ");
             int upprepningar = int.Parse(Console.ReadLine());
              int[] upprepa = new int[upprepningar];
              for (int i = 0; i < upprepa.Length; i++)
              {
                Console.Write(ordet);
              }
           Console.ReadKey();
        }
    }
}