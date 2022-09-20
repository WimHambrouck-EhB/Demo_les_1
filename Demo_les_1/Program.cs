using Demo1.Lib;
using System;

namespace Demo_les_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Console.Write("Naam? ");
            person.Voornaam = Console.ReadLine();

            PrintName(person);
        }

        private static void PrintName(Person p)
        {
            Console.WriteLine($"{p.Voornaam}");

        }
    }
}
