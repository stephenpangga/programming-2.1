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
        }

        Person ReadPerson()
        {
            

        }

        void PrintPerson(Person p)
        {

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
