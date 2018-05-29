using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using API.DTO;
using API.Models;
using API.Repositorys;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Produces("application/json")]
    [Route("api/water")]
    public class WaterController : Controller
    {
        private IRepository<Water> _repository;
        private WaterMapper mapper = new WaterMapper();

        public WaterController(IRepository<Water> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult GetAll() => Ok(_repository.GetAll());

        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {
            var item = _repository.Get(id);

            if (item == null)
                return NotFound();
            return Ok(item);
        }

        [HttpPost]
        public IActionResult Add([FromBody]WaterDTO command)
        {
            var item = new Water();;
            mapper.MapToModel(command, item);

            _repository.Insert(item);
            return Created(String.Empty, item);
        }

        [HttpPut]
        public IActionResult Update([FromBody]WaterDTO command)
        {
            var item = _repository.Get(command.Id);
            
            mapper.MapToModel(command, item);

            _repository.Update(item);

            return Ok();
        }
    }
}