using System;

namespace GaMEKolmKorda
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);
            int i = 0;
            while (i <= 2)
            {
                Console.WriteLine("NUmber on...");
                int userNUM = Convert.ToInt32(Console.ReadLine());

                if (cpuNumber == userNUM)
                {
                    Console.WriteLine("WE HAVE A WINNER!!!");
                    break;
                }
                else
                {

                    i++;
                    Console.WriteLine($"PRooVi UuEStI");

                }

            }


            Console.WriteLine("U R LOOSER!!!");



        }
    }
}
