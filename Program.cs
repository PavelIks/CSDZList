using System;
using System.Collections.Generic;

namespace dzshka
{
    class Program
    {
        static void Main(string[] args)
        {
            string str_txt = "";
            while (str_txt != "СТОП")
            {
                Console.Write("Введите слово: ");
                str_txt = Console.ReadLine();
            }
            List<C_Text> list_txt = new List<C_Text>();
            list_txt.Add(new C_Text(){ text = str_txt });
            foreach (C_Text t in list_txt)
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
    }
}