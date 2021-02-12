﻿using System;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace calcCoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DivideController : Controller
    {
        private readonly ICalculator _calc;

        public DivideController(ICalculator calculator)
        {
            _calc = calculator;
        }

        [HttpPost]
        public IActionResult Post([FromBody] double[] array)
        {
            try
            {
                return Ok(_calc.Divide(array));
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}