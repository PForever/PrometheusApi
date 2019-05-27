using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PrometheusData;
using PrometheusData.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PrometheusApi.Controllers
{
    [Route("api/[controller]")]
    public class PersonController : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Person> Get(PrometeusContext context)
        {
            return context.People;
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public Person Get(int id, PrometeusContext context)
        {
            return context.People.Find(id);
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]Person value, PrometeusContext context)
        {
            context.People.Add(value);
            context.SaveChanges();
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Person value, PrometeusContext context)
        {
            context.People.Update(value);
            context.SaveChanges();
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id, PrometeusContext context)
        {
            var person = context.People.Find(id);
            context.People.Remove(person);
            context.SaveChanges();
        }
    }
}
