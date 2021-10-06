using System;

namespace PINinFLooP
{
    class Program
    {
        static void Main(string[] args)
        {
            //katsete arv on piiramatu;

            bool loopActive = true; //bootlean- true/falce;
            int i = 0;
            while (loopActive)
            {
                Console.WriteLine("Sisesta PIN:");
                int userPIN = Convert.ToInt32(Console.ReadLine());

                if (userPIN == 1234)
                {
                    Console.WriteLine("Tere tulemast!");
                    loopActive = false;
                }
                else
                {
                    i++; //i =i+1;
                    Console.WriteLine($"VALE PIN.Proovi uuesti");
                    Console.WriteLine($"Oled vale PIN koodi sisestanud {i} korda");
                }
            }
            Console.WriteLine("KENA P@EVA!");


        
        }
    }
}
