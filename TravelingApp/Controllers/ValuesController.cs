using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using TravelingApp.Model;

namespace TravelingApp.Controllers
{  
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Getvalue()
        {
            return new string[] { "value1", "value2" };
        }
        [HttpGet()]
        public ActionResult<IEnumerable<Vechile>> GetVechileList()
        {
            List<Vechile> vechilelist = new List<Vechile>()
            {
                new Vechile(){ VechileId=1,VName="Maruti100",V_Model="BDD5637",V_Number="JH-6755" },
                new Vechile(){ VechileId=2,VName="Suzuki",V_Model="BDD563766",V_Number="JH-6757" },

                new Vechile(){ VechileId=3,VName="Jaguar",V_Model="BDD56344",V_Number="JH-6758" },

            };
            return vechilelist;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
