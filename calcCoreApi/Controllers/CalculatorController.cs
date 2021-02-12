using System;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace calcCoreApi
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : Controller
    {
        private readonly ICalculator _calc;

        public CalculatorController(ICalculator calculator)
        {
            _calc = calculator;
        }

        [HttpGet]
        public ActionResult<int> GetAll()
        {
            try
            {
                return Ok(_calc.GetValue());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
            
        }
        
        
        
    }
}