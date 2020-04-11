using System;
namespace Backend1.Services
{
    public interface ICalculation
    {
        
        int Sum(int number1, int number2);
        int Substraction(int number1, int number2);
        int Multiply(int number1, int number2);
        int Division(int number1, int number2);
       // int number1 { get; set; }
        //int number2 { get; set; }
    }
}
