using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace practice_01.controllers
{
    public class CalculatorController1 : Controller
    {
        // GET: /<controller>/
        [Route("{firstNumber:int}/{secondNumber:int}")]
        public IActionResult Sum(int firstNumber, int secondNumber)
        {
            ViewData["action"] = RouteData.Values["action"].ToString();
            ViewData["mark"] = '+';
            ViewData["firstNumber"] = firstNumber;
            ViewData["secondNumber"] = secondNumber;
            ViewData["result"] = firstNumber + secondNumber;

            return View("Result");
        }

        [Route("{firstNumber:int}/{secondNumber:int}")]
        public IActionResult Divide(int firstNumber, int secondNumber)
        {
            ViewData["action"] = RouteData.Values["action"].ToString();
            ViewData["mark"] = '/';
            ViewData["firstNumber"] = firstNumber;
            ViewData["secondNumber"] = secondNumber;
            ViewData["result"] = firstNumber / secondNumber;

            return View("Result");
        }
    }
}
