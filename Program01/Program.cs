﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program01
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
            Console.ReadKey();
        }
        void Start()
        {
            PrintMonths();
            Console.WriteLine();

            //calling the method and passing on the question
            Month Monthnumber = ReadMonth("Enter a month number: ");


            Console.Write($"{(int)Monthnumber} => ");
            PrintMonth(Monthnumber);
        }
        void PrintMonth(Month month)
        {
            Console.WriteLine(month);
        }
        void PrintMonths()
        {
            int numb = 1;
            for(Month i = Month.January; i<=Month.December; i++)
            {
                Console.Write($"{numb}.");
                numb++;
                PrintMonth(i);
            }
        }
        Month ReadMonth(string question)
        {
            bool whichMonth = false;

            int number = 0;
            while(whichMonth == false)
            {
                Console.Write(question);
                number = int.Parse(Console.ReadLine());

                if(Enum.IsDefined(typeof(Month), number))
                {
                    whichMonth = true;
                }
                else
                {
                    Console.WriteLine($"{number} is not a valid value.");
                }
            }
            
            return (Month)number;
        }
    }
}
