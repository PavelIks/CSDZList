using System;
using System.Collections.Generic;

namespace dzshka
{
    class Program
    {
        static void Main()
        {
            List<string> list = new List<string>();

            string str = String.Empty;
            while (!list.Contains("СТОП"))
            {
                //list.Add(Console.ReadLine());
                list.Add(Console.ReadLine());
            }
            list.RemoveAt(list.Count - 1);
            string min = list[0], max = list[0];
            foreach (var item in list)
            {
                if (min.Length > item.Length)
                {
                    min = item;
                }
                if (max.Length < item.Length)
                {
                    max = item;
                }
            }
            Console.WriteLine($"Самое длинное слово - {max}, самое короткое - {min}");
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