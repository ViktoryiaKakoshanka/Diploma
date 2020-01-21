using System.Collections.Generic;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using VestaTV.Cabel.Core.Models;
using VestaTV.Cable.BLL;
using VestaTV.Cable.BLL.Interfaces;

namespace VestaTV.Cabel.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [EnableCors]
    public class MasterController : ControllerBase
    {
        private readonly IMasterServis _masterService;

        public MasterController()
        {
            _masterService = new FacadeBll().MasterServis;
        }

        // GET: api/Master
        [HttpGet]
        public IEnumerable<Master> Get()
        {
            return _masterService.GetMasters();            
        }

        // GET: api/Master/5
        [HttpGet("{id}", Name = "Get")]
        public Master Get(int id)
        {
            return _masterService.GetMaster(id);
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
