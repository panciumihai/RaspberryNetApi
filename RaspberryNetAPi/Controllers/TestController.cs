using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RaspberryNetAPi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public IActionResult Index()
        {
            var list = new List<string>();
            list.Add("Bine ai venit pe Pantazon!");
            list.Add("Mihai este seful");
            return Ok(list);
        }
    }
}