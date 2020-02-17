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

            return p;
        }

        void PrintPerson(Person p)
        {
            Console.WriteLine($"{p.FirstName}, {p.LastName}, {p.age}, {p.city}");
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
