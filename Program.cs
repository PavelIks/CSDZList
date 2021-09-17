using System;
using System.Collections.Generic;

namespace dzshka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите слово: ");
            string txt = Console.ReadLine();

            List<Person> people = new List<Person>() { };
            people.Add(new Person() { Text = txt });

            foreach (Person p in people)
            {
                Console.WriteLine(p.Text);
            }
        }
    }

    class Person
    {
        public string Text { get; set; }
    }
}