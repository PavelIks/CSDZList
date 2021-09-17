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
            List<C_Text> c_text1 = new List<C_Text>();
            c_text1.Add(new C_Text() { text = txt });
            foreach (C_Text t in c_text1)
            {
                Console.WriteLine(t.text);
            }
        }
    }

    class C_Text
    {
        public C_Text()
        {

        }
        public C_Text(string text_)
        {
            text = text_;
        }
        public string text;
        public int CompareTo(C_Text text)
        {
            return this.text.CompareTo(text.text);
        }
    }
}