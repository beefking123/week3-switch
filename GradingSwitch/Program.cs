﻿using System;

namespace GradingSwitch
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
            //kui kasutaja sisestab midagi muud, siis konsool kuvab "val

            Console.WriteLine("Sisesta oma tulemus:");
            //char - character
            char userResult = Convert.ToChar(Console.ReadLine().ToUpper());

            switch (userResult)
            {
                case 'A':
                    Console.WriteLine("Suurep2rane!");
                    break;
                case 'B':
                    Console.WriteLine("V2ga hea!");
                    break;
                case 'C':
                    Console.WriteLine("Hea!");
                    break;
                case 'D':
                    Console.WriteLine("Rahuldav");
                    break;
                case 'E':
                    Console.WriteLine("Kasin");
                    break;
                case 'F':
                    Console.WriteLine("Puudulik");
                    break;
                default:
                    Console.WriteLine("Puudulik");
                    break;
            }
        }
    }
}