using System;

namespace GuessingGameIfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            bool loopActive = true;
            int cpuNumber = rnd.Next(1, 11);
            int i = 0;
            while (loopActive)
            {
                Console.WriteLine("NUmber on...");
                int userNUM = Convert.ToInt32(Console.ReadLine());

                if (cpuNumber == userNUM)
                {
                    Console.WriteLine("WE HAVE A WINNER!!!");
                    loopActive = false;
                }
                else
                {
                   
                    i++;
                    Console.WriteLine($"PRooVi UuEStI");

                }

            }

        }
    }
}
