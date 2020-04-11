using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend1.Models;
using Backend1.Services;
using Microsoft.AspNetCore.Mvc;

namespace Backend1.Controllers
{
    public class CalculatorController : Controller
    {
        private readonly IRanomNumbers random;

        private readonly ICalculation calculation;

       public CalculatorController(IRanomNumbers random , ICalculation calculation)
        {
            this.calculation = calculation;
            this.random = random;
            
        }

       /* public ActionResult Init()
        {

            calculation.number1 = random.GetNumber(calculation.number1);
            calculation.number2 = random.GetNumber(calculation.number2);

            return View();
        }*/

        public ActionResult PassUsingViewData()
        {
            var number1 = random.GetNumber(100);
            var number2 = random.GetNumber(100);

            var Addition = number1 + "+" + number2 + "=" +
                calculation.Sum(number1, number2);
            this.ViewData["add"] = Addition;

            var Substraction = number1 + "-" + number2 + "=" +
                calculation.Substraction(number1,number2);
            this.ViewData["Substraction"] = Substraction;

            var Division = number1 + "/" + number2 + "=" +
                calculation.Division(number1, number2);
            this.ViewData["Division"] = Division;

            var Multiplication = number1 + "/" + number2 + "=" +
                calculation.Multiply(number1, number2);
            this.ViewData["Multiplication"] = Multiplication;



            return View();
        }
        public ActionResult PassingUsingViewBag()
        {
            var number1 = random.GetNumber(100);
            var number2 = random.GetNumber(100);

            var Addition = number1 + "+" + number2 + "=" +
                calculation.Sum(number1, number2);
            this.ViewBag.Addition = Addition;

            var Substraction = number1 + "-" + number2 + "=" +
                calculation.Substraction(number1, number2);
            this.ViewBag.Substraction = Substraction;

            var Division = number1 + "/" + number2 + "=" +
                calculation.Division(number1, number2);
            this.ViewBag.Division = Division;

            var Multiplication = number1 + "*" + number2 + "=" +
                calculation.Multiply(number1, number2);
            this.ViewBag.Multiplication = Multiplication;

            return View();
        }


        public ActionResult PassUsingViewModel()
        {
            var number1 = random.GetNumber(100);
            var number2 = random.GetNumber(100);

            var Addition = number1 + "+" + number2 + "=" +
                calculation.Sum(number1, number2);

            var Substraction = number1 + "-" + number2 + "=" +
                calculation.Substraction(number1, number2);

            var Division = number1 + "/" + number2 + "=" +
                calculation.Division(number1, number2);

            var Multiplication = number1 + "*" + number2 + "=" +
                calculation.Multiply(number1, number2);

            var model = new CalculatorViewModel {


                Sum = Addition,
                Substraction = Substraction,
                Division = Division,
                Multiplication = Multiplication,

            };

            return View(model);
        }
        public ActionResult InjectDirectly()
        {
            return View();
        }
    }
}
