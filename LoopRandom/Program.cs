using System;

namespace LoopRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kasutaja sisestada pinkoodi;
            //programm v6rdleb pinkoodi arvuga 1234;
            //kui sisestatud pin on 6ige siis TT;
            //kui ei ole, siis sonsole kuvab vale pin! proovi uuesti;
            //kasutajal on kolm katset i<3;


            int i = 0;              //i- interation;




            while (i < 3)            //while-loop;
            {


                Console.WriteLine("Sisesta PIN:");
                int userPIN = Convert.ToInt32(Console.ReadLine());

                if (userPIN == 1234)
                {
                    Console.WriteLine("Tere tulemast!");
                    break;
                }
                else
                {
                    //i = i + 1;
                    i++;
                    Console.WriteLine($"VALE PIN. {3 - i} katset on j@@nud!");
                                       
                }
            }
            Console.WriteLine("KENA P@EVA!");

        }
    }
}
