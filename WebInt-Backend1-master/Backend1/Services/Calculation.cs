using System;
namespace Backend1.Services
{
    public class Calculation : ICalculation
    {
        public int  number1 { get; set; }
        public int number2 { get; set; }

        public int Sum(int number1, int number2)
        {
            return (number1 + number2);
        }
        public int Substraction(int number1, int number2)
        {
            return (number1 - number2);
        }
        public int Multiply(int number1, int number2)
        {
            return (number1 * number2);
        }
        public int Division(int number1, int number2)
        {
            return (number1 / number2);
        }
    }
}
