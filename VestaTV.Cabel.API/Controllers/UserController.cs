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
    public class UserController : ControllerBase
    {
        private readonly IUserServis _userService;

        public UserController()
        {
            _userService = new FacadeBll().UeserServis;
        }

        // GET: api/User
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _userService.GetUsers();
        }

        // GET: api/User/5
        [HttpGet("{id}")]
        public User Get(int id)
        {
            if (id == 0)
                throw new KeyNotFoundException();

            return _userService.GetUser(id);
        }

        // POST: api/User
        [HttpPost]
        public void Post(User User)
        {
            if (User == null)
                throw new ArgumentNullException();

            _userService.AddNewUser(User);
        }

        // PUT: api/User
        [HttpPut]
        public IActionResult Put(User User)
        {
            if (User == null)
                return BadRequest("User is null");
            if (User.Id <= 0)
                return BadRequest("User id must be positive number");

            _userService.UpdateUser(User);
            return Ok();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete]
        public void Delete(User User)
        {
            if (User.Id == 0)
                throw new KeyNotFoundException();

            _userService.DeleteUser(User.Id);
        }
    }
}
