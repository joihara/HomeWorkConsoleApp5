using System;


namespace HomeWorkConsoleApp5
{
    class Program
    {
        
        
        private static readonly Library library = new();
        static void Main(string[] args)
        {
            //Задание 1. Создание методов, которые производят вычисления с матрицами
            Work1();
            //Задание 2. Создание методов, которые принимают текст и возвращают слова
            Work2();
            //Задание 3. Создание метода, принимающего строку и возвращающего новую строку, в которой удалены все рядом стоящие повторяющиеся символы
            Work3();
            //Задание 4. Написание метода, определяющего, является ли последовательность чисел прогрессией
            Work4();
            //Задание 5. Написание функции Аккермана с применением рекурсии
            Work5();

            var t = library.TextToWords("привет мир во всей красе");

            foreach (var item in t)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        private static void Work5()
        {
            Console.WriteLine($"Заданию №5");

            Console.ReadLine();
        }

        private static void Work4()
        {
            Console.WriteLine($"Заданию №4");

            Console.ReadLine();
        }

        private static void Work3()
        {
            Console.WriteLine($"Заданию №3");

            Console.ReadLine();
        }

        private static void Work2()
        {
            Console.WriteLine($"Заданию №2");

            Console.ReadLine();
        }

        private static void Work1() {
            Console.WriteLine($"Заданию №1");
            //Генерация матриц
            var Matrix1 = library.MatrixRandom(4, 4, 0, 99);
            var Matrix2 = library.MatrixRandom(4, 4, 0, 99);
            Console.WriteLine($"1-я матрица");
            library.PrintMatrix(Matrix1);
            Console.WriteLine($"2-я матрица");
            library.PrintMatrix(Matrix2);
            var okSizeMatrix = library.EqualsSizeMatrix(Matrix1, Matrix2);
            var matrixMultiplicationByNumber = library.MatrixMultiplicationByNumber(Matrix1, 7);
            Console.WriteLine($"Умножение 1-й матрицы на число 7");
            library.PrintMatrix(matrixMultiplicationByNumber);

            if (okSizeMatrix)//Проверка если матрицы разных размеров
            {
                Console.WriteLine($"Сложение матриц");
                var matrixOperationAddition = library.MatrixOperation(Matrix1, Matrix2, EnumTypeOperation.Addition);
                library.PrintMatrix(matrixOperationAddition);
                Console.WriteLine($"Вычитание матриц");
                var matrixOperationSubtraction = library.MatrixOperation(Matrix1, Matrix2, EnumTypeOperation.Subtraction);
                library.PrintMatrix(matrixOperationSubtraction);
                Console.WriteLine($"Умножение двух матриц");
                var matrixOperationMultiplication = library.MatrixOperation(Matrix1, Matrix2, EnumTypeOperation.Multiplication);
                library.PrintMatrix(matrixOperationMultiplication);

            }
            else
            {
                Console.WriteLine($"Матрицы имеют разные размеры");
            }
            Console.ReadLine();
        }
    }
}
