namespace Lab1.HomeWorks
{
    /// <summary>
    /// Методы обработки строк.
    /// Исходные условия: Метод принимает исходный массив строк, и возвращает результат обработки
    /// </summary>
    public class HomeWork2
    {
        /// <summary>
        /// Найти самую короткую и самую длинную строки. Вернуть найденные строки и их длину.
        /// </summary>
        /// <param name="temp">Исходный массив строк</param>
        /// <returns>Самая длинная строка, ее длина, самая маленькая трока и ее длина. Пример вывода return ("max1", 4, "min", 3);</returns>
        public static (string max, int lengthMax, string min, int lengthMin) Variant1(string[] temp)
        {
            string[] LocalArray;

            LocalArray = temp;

            string MinLenStr;
            string MaxLenStr = "";
            int max;
            int min;

            MinLenStr = LocalArray[0];

            foreach (string a in LocalArray)
            {
                if (a.Length <= MinLenStr.Length)
                {
                    MinLenStr = a;
                }

            }

             MaxLenStr = LocalArray[0];

             foreach (string b in LocalArray)
             {
                    if (b.Length >= MaxLenStr.Length)
                {
                    MaxLenStr = b;
                }
             }

            min = MinLenStr.Length;
            max = MaxLenStr.Length;

            return (MaxLenStr, max, MinLenStr, min);

        }

        /// <summary>
        /// Найти слово, состоящее только из цифр. Если таких слов больше одного, найти второе из них
        /// </summary>
        /// <param name="temp">Исходный массив строк</param>
        /// <returns>Слово состоящее только из цифр.</returns>
        public static string Variant2(string[] temp)
        {
            string[] LocalArray;
            LocalArray = temp;
            string Result = "";
            int  TypeCheck;

            foreach (string a in LocalArray)
            {
                if (int.TryParse(a, out int result))
                {
                    Result = a;
                }

            }

           if (Result == "")
            {
                Result = null;
            } 

            return Result;

        }
    }
}