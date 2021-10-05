using System;
using System.Collections.Generic;

namespace HomeWorkConsoleApp5
{
    public class Library
    {
        #region TextMethod

        public string[] TextToWords(string text) {
            return text.Split(' ',2, StringSplitOptions.RemoveEmptyEntries);
        }

        #endregion

        #region Matrix

        public static int[][] MatrixCreate(int rows, int cols)
        {
            // Создаем матрицу, полностью инициализированную
            // значениями 0.0. Проверка входных параметров опущена.
            int[][] result = new int[rows][];
            for (int i = 0; i < rows; ++i)
                result[i] = new int[cols]; // автоинициализация в 0.0
            return result;
        }

        public static int[][] MatrixRandom(int rows, int cols, int minVal, int maxVal)
        {
            // Возвращаем матрицу со значениями
            // в диапазоне от minVal до maxVal
            Random ran = new();
            var result = MatrixCreate(rows, cols);
            for (int i = 0; i < rows; ++i)
                for (int j = 0; j < cols; ++j)
                    result[i][j] = ran.Next(minVal, maxVal);
            return result;
        }

        /// <summary>
        /// Умножение матрицы на число
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="number"></param>
        /// <returns></returns>
        public int[][] MatrixMultiplicationByNumber(int[][] matrix, int number)
        {
            List<int[]> temp = new();
            List<int> tempY = new();
            foreach (var itemX in matrix)
            {
                foreach (var itemY in itemX)
                {
                    tempY.Add(itemY * number);
                }
                temp.Add(tempY.ToArray());
                tempY.Clear();
            }
            return temp.ToArray();
        }
        /// <summary>
        /// Проверка на одинаковый размер матриц
        /// </summary>
        /// <param name="Matrix1"></param>
        /// <param name="Matrix2"></param>
        /// <returns></returns>
        public bool EqualsSizeMatrix(int[][] Matrix1, int[][] Matrix2)
        {
            int SizeMatrix1X = Matrix1.Length;
            int SizeMatrix1Y = Matrix1[0].Length;
            int SizeMatrix2X = Matrix2.Length;
            int SizeMatrix2Y = Matrix2[0].Length;
            return SizeMatrix1X == SizeMatrix2X && SizeMatrix1Y == SizeMatrix2Y;
        }
        /// <summary>
        /// Оператор работы с матрицами
        /// </summary>
        /// <param name="input">первая матрица</param>
        /// <param name="added">вторая матрица</param>
        /// <param name="EnumTypeOperation">Тип операци</param>
        /// <returns></returns>
        public int[][] MatrixOperation(int[][] input, int[][] added, EnumTypeOperation EnumTypeOperation)
        {
            int[][] temp = new int[input.Length][];
            for (int index = 0; index < input.Length; index++)
            {
                temp[index] = new int[input[index].Length];
                for (int iterator = 0; iterator < input[index].Length; iterator++)
                {
                    switch (EnumTypeOperation)
                    {
                        case EnumTypeOperation.Addition:
                            temp[index][iterator] = input[index][iterator] + added[index][iterator];
                            break;
                        case EnumTypeOperation.Subtraction:
                            temp[index][iterator] = input[index][iterator] - added[index][iterator];
                            break;
                        case EnumTypeOperation.Multiplication:
                            temp[index][iterator] = input[index][iterator] * added[index][iterator];
                            break;
                        default:
                            break;
                    }

                }
            }
            return temp;
        }

        /// <summary>
        /// Печать матриц
        /// </summary>
        /// <param name="matrix"></param>
        public static void PrintMatrix(int[][] matrix)
        {
            foreach (var itemX in matrix)
            {
                foreach (var itemY in itemX)
                {
                    Console.Write($"{itemY,5}");
                }
                Console.WriteLine();
            }
        }
        #endregion
    }
}
