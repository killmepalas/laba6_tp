using System;

namespace Calc
{
    public class Calculator
    {
        /// <summary>
        /// Получаем результат операции деления (n1 / n2)
        /// </summary>
        /// <param name="n1">Первое число</param>
        /// <param name="n2">Второе число</param>
        /// <returns>Результат</returns>
        public double Div(double n1, double n2)
        {
            return n1 / n2;
        }

        /// <summary>
        /// Получаем результат сложения чисел и их увеличения на единицу
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public double AddWithInc(double n1, double n2)
        {
            return n1 + n2 + 1;
        }
    }
}
