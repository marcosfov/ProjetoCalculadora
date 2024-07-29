using CalculatorAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        [HttpGet("Addition")]
        public ActionResult<Calculadora> Addition(double value1, double value2)
        {
            var calc = new Calculadora(value1, value2);
            calc.Value1 = value1;
            calc.Value2 = value2;

            calc.sum();
            return Ok(calc);
        }

        [HttpGet("Subtraction")]
        public ActionResult<Calculadora> Subtraction(double value1, double value2)
        {
            var calc = new Calculadora(value1, value2);
            calc.Value1 = value1;
            calc.Value2 = value2;

            calc.subtract();
            return Ok(calc);
        }

        [HttpGet("Multiplication")]
        public ActionResult<Calculadora> Multiplication(double value1, double value2)
        {
            var calc = new Calculadora(value1, value2);
            calc.Value1 = value1;
            calc.Value2 = value2;

            calc.multiply();
            return Ok(calc);
        }

        [HttpGet("Division")]
        public ActionResult<Calculadora> Division(double value1, double value2)
        {
            var calc = new Calculadora(value1, value2);
            calc.Value1 = value1;
            calc.Value2 = value2;

            if (value2 == 0) {
                return BadRequest("It is not possible to divide by zero. Try again with another value.");
            };

            calc.divide();
            return Ok(calc);
        }
    }
}
