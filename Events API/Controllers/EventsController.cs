using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Events_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {

        private static Events[] event1 = new Events[10];
       
        public static int empty = 0;


        // GET: api/<EventsController>
        [HttpGet]
        public IEnumerable<Events> Get()
        {
            return event1;
        }

        //// GET api/<EventsController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<EventsController>
        [HttpPost]
        public void Post([FromBody] Events e)
        {
            event1[empty] = new Events(e.Id, e.Title);
        }

        // PUT api/<EventsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Events e)
        {
            for (int i = 0; i < event1.Length; i++)
                if (event1[i].Id == id)
                {
                    event1 [i].Title = e.Title;
                }

        }

        // DELETE api/<EventsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            for (int i = 0; i < event1.Length; i++)
                if (event1[i].Id == id)
                {
                    event1[i] = null;
                }
        }
    }
}
