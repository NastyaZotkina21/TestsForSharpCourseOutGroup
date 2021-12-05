namespace Lab1.HomeWorks
{
    /// <summary>
    /// Метод калькулятор
    /// Исходные условия: Метод принимает два числа и знак операции.
    /// </summary>
    public class HomeWork3
    {
        /// <summary>
        /// Метод калькулятора
        /// </summary>
        /// <param name="x">Первый операнд</param>
        /// <param name="y">Второй операнд</param>
        /// <param name="mathOperation">Знак операции</param>
        /// <returns>Результат вычисления</returns>
        public static double Calculator(double x, double y, char mathOperation = '+')
        {
            double Result=0;
            double Operand1;
            double Operand2;
            char Operation;

            Operand1 = x;
            Operand2 = y;

            Operation = mathOperation;

            
                switch (Operation)
                {
                    case '+':
                        Result = Operand1 + Operand2;
                        break;

                    case '-':
                        Result = Operand1 - Operand2;
                        break;

                    case '*':
                        Result = Operand1 * Operand2;
                        break;

                    case '/':
                        Result = Operand1 / Operand2;
                        break;

                }
                                
            
                if (Operand2 == 0 && Operation == '/')
                {
                    throw new System.Exception();
                }

                if ( Operation ==')')
                {
                    throw new System.Exception();
                }
                                       
             


            return Result;
            }
    }
}