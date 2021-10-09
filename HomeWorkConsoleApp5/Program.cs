using System;


namespace HomeWorkConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1. Метод разделения строки на слова
            Work1();
            //Задание 2. Перестановка слов в предложении
            Work2();
        }


        private static void Work2()
        {
            Console.WriteLine($"Задание №2");

            var reverse = ReversWords("Привет мир во всей красе");
            Console.WriteLine(reverse);
            Console.ReadLine();
        }

        private static void Work1() {
            Console.WriteLine($"Задание №1");
            

            var arrayWords = GetArrayOfWords("Привет мир во всей красе");

            foreach (var item in arrayWords)
            {
                Console.WriteLine(item);
            }

            

            Console.ReadLine();
        }

        static string[] GetArrayOfWords(string text)
        {
            return text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        }

        static string ReversWords(string inputPhrase)
        {
            var arrayWords = GetArrayOfWords(inputPhrase);
            Array.Reverse(arrayWords);
            var result = string.Join(" ", arrayWords);
            return result;
        }
    }
}
