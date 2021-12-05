namespace Lab1.HomeWorks
{
    /// <summary>
    /// Методы обработки массива.
    /// Исходные условия: Метод принимает исходный массив, и возвращает результат обработки
    /// </summary>
    public static class HomeWork1
    {
        /// <summary>
        /// В массиве целых чисел поменять местами максимальный отрицательный элемент и минимальный положительный.
        /// </summary>
        /// <param name="temp">Исходный массив</param>
        /// <returns>Массив в котором поменяны местами максимальный отрицательный элемент и минимальный положительный</returns>
        public static int[] Variant1(int[] temp)
        {
            int[] LocalArray;

            LocalArray = temp;

            int MinNeg = int.MaxValue;
            int MaxPos = int.MaxValue;

            foreach (int a in LocalArray)
            {
                if (a < 0 && a < MinNeg)
                {
                    MinNeg = a;
                }
                else if (a > 0 && a < MaxPos)
                {
                    MaxPos = a;
                }
            }

            for (int i = 0; i < LocalArray.Length; i++)
            {
                if (LocalArray[i] == MinNeg && MinNeg != int.MaxValue && MaxPos != int.MaxValue)
                {
                    LocalArray[i] = MaxPos;
                }
                else if (LocalArray[i] == MaxPos && MinNeg != int.MaxValue && MaxPos != int.MaxValue)
                {
                    LocalArray[i] = MinNeg;
                }
            }

            temp = LocalArray;

            return temp;

        }

        /// <summary>
        /// В массиве целых чисел определить сумму элементов, состоящих на чётных позициях
        /// </summary>
        /// <param name="temp">Исходный массив</param>
        /// <returns>Сумма элементов, состоящих на чётных позициях массива</returns>
        public static int Variant2(int[] temp)
        {

          int SumOfEvenIndexElems=0;
          int[] LocalArray;

          LocalArray = temp;

            for (int i = 0; i < LocalArray.Length; i++)
            {
                if (i % 2 == 0)
                {
                    SumOfEvenIndexElems = SumOfEvenIndexElems + LocalArray[i];
                }
            }

            return SumOfEvenIndexElems;
        }

        /// <summary>
        /// В массиве целых чисел заменить нулями отрицательные элементы.
        /// </summary>
        /// <param name="temp">Исходный массив</param>
        /// <returns>Массив в котором поменяны отрицательные элементы на нули</returns>
        public static int[] Variant3(int[] temp)
        {
            int[] LocalArray;

            LocalArray = temp;

            for (int i = 0; i < LocalArray.Length; i++)
            {
                if (LocalArray[i] < 0)
                {
                    LocalArray[i] = 0;
                }
            }

            temp = LocalArray;

            return temp;

        }

        /// <summary>
        /// В массиве целых чисел утроить каждый положительный элемент, который стоит перед отрицательным.
        /// </summary>
        /// <param name="temp">Исходный массив</param>
        /// <returns>Массив в котором *3 каждый положительный элемент, который стоит перед отрицательным</returns>
        public static int[] Variant4(int[] temp)
        {
            int[] LocalArray;

            LocalArray = temp;

            for (int i = 0; i < LocalArray.Length; i++)
            {
                if (LocalArray[i] < 0 && LocalArray[i-1] > 0)
                {
                    LocalArray[i-1] = LocalArray[i-1] * 3;
                }
            }

            temp = LocalArray;

            return temp;
        }

        /// <summary>
        /// В массиве целых чисел найти разницу между средним арифметическим и значение минимального элемента.
        /// </summary>
        /// <param name="temp">Исходный массив</param>
        /// <returns>Разница между средним арифметическим и значение минимального элемента</returns>
        public static double Variant5(int[] temp)
        {
            int[] LocalArray;

            LocalArray = temp;

            double SumOfArrayElements = 0;
            double AvgOfArrayElements;
            int MinElemOfArray = 0;
            double Result;

            for (int i = 0; i < LocalArray.Length; i++)
            {
                SumOfArrayElements = SumOfArrayElements + LocalArray[i];
            }

            AvgOfArrayElements = SumOfArrayElements / LocalArray.Length;

            foreach (int a in LocalArray)
            {
                if (a <= MinElemOfArray)
                {
                    MinElemOfArray = a;
                }
                else
                {
                    if (a > 0 && MinElemOfArray == 0)
                    {
                        MinElemOfArray = a;
                    }
                }
             
            }

            Result = AvgOfArrayElements - MinElemOfArray;

            return Result;

        }
    }
}