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
            Person[] person = new Person[3];
            for(int i=0; i<person.Length; i++)
            {
                person[i]= ReadPerson();
                Console.WriteLine();
            }
            // to show
            for(int j=0; j<person.Length; j++)
            {
                PrintPerson(person[j]);
            }


            Console.WriteLine("Birthday");
            CelebrateBirthday(ref person[0]);
            PrintPerson(person[0]);
        }

        Person ReadPerson()
        {   
            Person p = new Person();
            p.FirstName = ReadString("Enter First name: ");
            p.LastName = ReadString("Enter Last name: ");
            p.gender = ReadGender("Enter gender (m/f): ");
            p.age = ReadInt("Enter Age: ");
            p.city = ReadString("Enter city: ");

            return p;
        }

        void PrintPerson(Person p)
        {
            Console.Write($"{p.FirstName} {p.LastName}");
            PrintGender(p.gender);
            Console.WriteLine();
            Console.WriteLine($" {p.age}, {p.city}");
            Console.WriteLine();//spacing
        }

        GenderType ReadGender(string question)
        {
            Console.Write(question);
            string input = Console.ReadLine();
            GenderType gender = GenderType.Male;
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
        void CelebrateBirthday(ref Person p)
        {
            p.age = p.age + 1;
        }

        void PrintGender(GenderType gender)
        {
            if(gender == GenderType.Male)
            {
                Console.Write("(m)");
            }
            else if(gender == GenderType.Female)
            {
                Console.Write("(f)");
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
