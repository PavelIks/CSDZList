using System;
using System.Collections.Generic;

namespace dzshka
{
    class Program
    {
        static void Main(string[] args)
        {
            string str_txt = string.Empty;
            List<C_Text> list_txt = new();

            while (str_txt.ToUpper() != "СТОП") // стоп будет равно СТОП, Стоп, СтОп.....
            {
                Console.Write("Введите слово: ");
                str_txt = Console.ReadLine();

                // не добавляем пустые строки и строку стоп
                if (string.IsNullOrWhiteSpace(str_txt) || str_txt.ToUpper() == "СТОП")
                {
                    continue;
                }
                list_txt.Add(new C_Text(str_txt));
            }

            if (list_txt.Count == 0)  // можно использовать !list_txt.Any()
            {
                Console.WriteLine($"Список пуст.");
                return;
            }

            string min = list_txt[0].Text, max = list_txt[0].Text;
            foreach (var item in list_txt)
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

            Console.WriteLine($"Самое длинное слово - {max}.\nСамое короткое слово - {min}.\n");
        }
    }

    class C_Text
    {
        public C_Text(string text)
        {
            Text = text;
        }

        public string Text { get; }
    }
}