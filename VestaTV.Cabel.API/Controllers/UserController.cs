using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using VestaTV.Cabel.DAL;
using VestaTV.Cabel.DAL.Entities;

namespace VestaTV.Cabel.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        // GET: api/User
        [HttpGet]
        public IEnumerable<User> Get()
        {
            var db = new UnitOfWork();
            var users = db.Users.GetAll();
            

            return users;
        }

        // GET: api/User/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/User
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/User/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
