using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Example.Service.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Example.Service.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        private static ValuesService _valuesService = new ValuesService();

        private readonly ILogger<ValuesController> _logger;

        public ValuesController(ILogger<ValuesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get() => Ok(_valuesService.GetValues());

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id) => Ok(_valuesService.GetValue());
    }
}
