using System;

namespace Ex_Propostos_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());

            int max = 0;
            int min = 0;
            if (N2 > N)
            {
                max = N2;
                min = N;
            }
            else
            {
                max = N;
                min = N2;
            }

            if ( max%min == 0)
            {
                Console.WriteLine("Multiplos");
            }
            else
            {
                Console.WriteLine("Não multiplos");
            }
        }
    }
}
