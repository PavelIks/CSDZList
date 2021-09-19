using System;
using System.Collections.Generic;

namespace dzshka
{
    class Program
    {
        static void Main(string[] args)
        {
            string str_txt = string.Empty;
            List<TextClass> textClasses = new();

            while (str_txt.ToUpper() != "СТОП") // стоп будет равно СТОП, Стоп, СтОп.....
            {
                Console.Write("Введите слово: ");
                str_txt = Console.ReadLine();

                // не добавляем пустые строки и строку стоп
                if (string.IsNullOrWhiteSpace(str_txt) || str_txt.ToUpper() == "СТОП")
                {
                    continue;
                }
                textClasses.Add(new TextClass(str_txt));
            }

            if (textClasses.Count == 0)  // можно использовать !textClasses.Any()
            {
                Console.WriteLine($"список пуст");
                return;
            }

            string min = textClasses[0].Text, max = textClasses[0].Text;
            foreach (var item in textClasses)
            {
                if (min.Length > item.Text.Length)
                {
                    min = item.Text;
                }
                if (max.Length < item.Text.Length)
                {
                    max = item.Text;
                }
            }

            Console.WriteLine($"Самое длинное слово - {max}\nСамое короткое слово - {min}\n");
        }
    }

    class TextClass
    {
        public TextClass(string text)
        {
            Text = text;
        }

        public string Text { get; }
    }
}