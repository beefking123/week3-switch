using System;

namespace PersonalityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kysib kasutajal sisestada tema lemmik v2rv;
            //kui kasutaja sisestab "punane", konsool kuvab "oled romantiline";
            //kui kasutaja sisestab "sinine", konsool kuvab "oled t66kas";
            //kui kasutaja sisestab "roheline", konsool kuvab "oled looduse s6ber";
            //kui kasutaja sisestab midagi muud, konsool kuvab "oled {usercolor} ykssarvik";

            Console.WriteLine("Sisesta oma lemmikv2rv");
            string usercolor = Console.ReadLine();

            if(usercolor == "punane")
            {
                Console.WriteLine("Oled romantiline");
            }
            else if(usercolor == "sinine")
            {
                Console.WriteLine("Oled t66kas");
            }
            else if(usercolor == "roheline")
            {
                Console.WriteLine("Oled looduses6ber");
            }
            else
            {
                Console.WriteLine($"Oled {usercolor} ykssarvik");
            }
            Console.WriteLine("Kena p2eva!");
        }
    }
}
