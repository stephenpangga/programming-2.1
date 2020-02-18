using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program02
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
            Person p1 = new Person();
            p1 = ReadPerson();
            PrintPerson(p1);
        }

        Person ReadPerson()
        {
            Person p = new Person();
            p.FirstName = ReadString("What is your First name: ");
            p.LastName = ReadString("What is your Last name: ");
            p.age = ReadInt("What is your Age: ");
            p.city = ReadString("Where are you from: ");
            p.gender = ReadGender("what is your gender (m/f): ");

            return p;
        }

        void PrintPerson(Person p)
        {
            Console.WriteLine($"{p.FirstName}, {p.LastName}, {p.age}, {p.city}");
            PrintGender(p.gender);
        }

        GenderType ReadGender(string question)
        {
            Console.Write(question);
            string input = Console.ReadLine();
            GenderType gender;
            if(input == "m")
            {
                gender = GenderType.Male;
            }
            else if(input == "f")
            {
                gender = GenderType.Female;
            }

            return gender;
            //maybe need a check that the user place m or f
        }
        void PrintGender(GenderType gender)
        {
            if(gender == GenderType.Male)
            {
                Console.Write("m");
            }
            else if(gender == GenderType.Female)
            {
                Console.Write("f");
            }
        }

        int ReadInt(string question)
        {
            Console.Write(question);
            return int.Parse(Console.ReadLine());
        }
        string ReadString(string question)
        {
            Console.Write(question);
            return Console.ReadLine();
        }

    }
}
