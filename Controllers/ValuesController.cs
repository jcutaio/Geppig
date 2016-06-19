using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Geppig.ResponseBuilders;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace Geppig.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(string id, [FromBody] string text)
        {
            return text;
        }

        // POST api/values/5
        [HttpPost("{id}")]
        public string Post(string id, [FromBody] JToken jsonText)
        {
            return PostResponseBuilder.BuildJsonResponse(id, jsonText.ToString());
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
