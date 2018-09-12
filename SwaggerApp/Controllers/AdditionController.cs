using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SwaggerApp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AdditionController : ControllerBase
    {
        [HttpGet("{a}/{b}")]
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}