using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Sample.Services;

namespace Sample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ValuesService valuesService;

        public ValuesController(ValuesService valuesService) =>
            this.valuesService = valuesService;

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get() =>
            valuesService.GetAll();

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value) =>
            valuesService.Add(value);

        // DELETE api/values/foobar
        [HttpDelete("{value}")]
        public void Delete(string value) =>
            valuesService.Remove(value);
    }
}
