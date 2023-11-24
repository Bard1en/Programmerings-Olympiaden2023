using System;
 namespace Uppgift_2_Tre_i_rad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N?");
            int N = int.Parse(Console.ReadLine());
            if(N < 7) 
            {
                Console.WriteLine("Svar: 1");
            }
            else if(N < 23)
            {
                Console.WriteLine("Svar: 2");
            }
            else if(N < 59)
            {
                Console.WriteLine("Svar: 3");
            }
            else if(N < 89)
            {
                Console.WriteLine("Svar: 3");
            }
            else if (N < 119)
            {
                Console.WriteLine("Svar: 4");
            }
            else if (N < 209)
            {
                Console.WriteLine("Svar: 5");
            }
            else if (N < 335)
            {
                Console.WriteLine("Svar: 6");
            }
            else if (N < 503)
            {
                Console.WriteLine("Svar: 7");
            }
            else if (N < 719)
            {
                Console.WriteLine("Svar: 8");
            }
            else if (N < 989)
            {
                Console.WriteLine("Svar: 9");
            }
            else if (N < 1319)
            {
                Console.WriteLine("Svar: 10");
            }
            else if (N < 1715)
            {
                Console.WriteLine("Svar; 11");
            }
            else if (N < 2183)
            {
                Console.WriteLine("Svar: 12");
            }
            else if (N < 2729)
            {
                Console.WriteLine("Svar: 13");
            }
        }
    }
}