using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace sprocket_dotnet.Controllers
{
    [Route("api/[controller]")]
    public class MathController : Controller
    {
        private const string Template = "Math, {0}";
    
        // GET api/sum
        [HttpGet(template: "/api/sum/{number_one}/{number_2}")]
        public string sum(int number_one, int number_two)
        {
            Math math = new Math(number_one, number_two);
            return string.Format(MathController.Template, math.Sum().ToString());
        }

        // GET api/multiply
        [HttpGet(template: "/api/multiply/{number_one}/{number_two}")]
        public string multiply(int number_one, int number_two)
        {
            Math math = new Math(number_one, number_two);
            return string.Format(MathController.Template, math.Product().ToString());
        }
    }
}
