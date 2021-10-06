using System;

namespace RandomNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int i = 0;
            while (i != 5)
            {
                int myRandomNumber = rnd.Next(1, 11);
                Console.WriteLine($"YOUR NUMBER IS: {myRandomNumber}");
                if (myRandomNumber == 5)
                {
                    i = myRandomNumber;
                }
            }
            Console.WriteLine("GO HOME!");
        }
    }
}
