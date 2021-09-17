using System;
using System.Collections.Generic;

namespace dzshka
{
    class Program
    {
        static void Main(string[] args)
        {
            string txt = "";
            while (txt != "СТОП")
            {
                Console.Write("Введите слово: ");
                txt = Console.ReadLine();
            } 

            List<C_Text> c_text1 = new List<C_Text>() { };
            c_text1.Add(new C_Text() { Text = txt });

            foreach (C_Text t in c_text1)
            {
                Console.WriteLine(t.Text);
            }
        }
    }

    class C_Text
    {
        public string Text { get; set; }
    }
}