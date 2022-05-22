using System;

namespace GradingIF
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kysib, mis hinde kasutaja sai
            //kui kasutaja sai 'A', konsool kuvab "suurep2rane"
            //'B', konsool kuvab "v2ga hea!"
            //'C', konsool kuvab "Hea!"
            //'D', konsool kuvab "Rahuldav"
            //'E', konsool kuvab "Kasin"
            //'F', konsool kuvab "Puudulik"
            //kui kasutaja sisestab midagi muud, siis konsool kuvab "vale v22rtus"

            Console.WriteLine("Sisesta oma tulemus:");
            //char - character
            char userResult = Convert.ToChar(Console.ReadLine().ToUpper());


            if (userResult == 'A')
            {
                Console.WriteLine("Suurep2rane");
            }
            else if (userResult == 'B')
            {
                Console.WriteLine("V2ga hea!");
            }
            else if (userResult == 'C')
            {
                Console.WriteLine("Hea");
            }
            else if (userResult == 'D')
            {
                Console.WriteLine("Rahuldav");
            }
            else if (userResult == 'E')
            {
                Console.WriteLine("Kasin");
            }
            else if (userResult == 'F')
            {
                Console.WriteLine("Puudulik");
            }
            else
            {
                Console.WriteLine("vale v22rtus!");
            }
        }
    }
}
