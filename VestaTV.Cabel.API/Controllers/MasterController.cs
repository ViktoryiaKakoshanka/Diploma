using System.Collections.Generic;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using VestaTV.Cabel.Core.Models;
using VestaTV.Cable.BLL;
using VestaTV.Cable.BLL.Interfaces;
using System;

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
            if (id == 0)
                throw new KeyNotFoundException();

            return _masterService.GetMaster(id);
        }

        // POST: api/Master
        [HttpPost]
        public void Post(Master master)
        {
            if (master == null)
                throw new ArgumentNullException();

            _masterService.AddNewMaster(master);
        }

        // PUT: api/Master
        [HttpPut]
        public IActionResult Put(Master master)
        {
            if (master == null)
                return BadRequest("Master is null");
            if (master.Id <= 0)
                return BadRequest("Master id must be positive number");

            _masterService.UpdateMaster(master);
            return Ok();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            if (id == 0)
                throw new KeyNotFoundException();

            _masterService.FireMaster(id);
        }
    }
}
