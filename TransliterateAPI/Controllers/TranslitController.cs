using Microsoft.AspNetCore.Mvc;

namespace TransliterateAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TranslitController : ControllerBase
    {
        // GET: api/<TranslitController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<TranslitController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TranslitController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TranslitController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TranslitController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
