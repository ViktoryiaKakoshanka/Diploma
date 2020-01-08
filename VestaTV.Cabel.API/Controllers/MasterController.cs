using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using VestaTV.Cabel.Core.Models;
using VestaTV.Cabel.DAL;
using VestaTV.Cabel.DAL.Interfaces;

namespace VestaTV.Cabel.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MasterController : ControllerBase
    {
        private IUnitOfWork _db;

        public MasterController()
        {
            _db = new UnitOfWork();
        }

        // GET: api/Master
        [HttpGet]
        public IEnumerable<Master> Get()
        {
            var users = _db.Masters.GetAll();            
            return users;
        }

        // GET: api/Master/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Master
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Master/5
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
