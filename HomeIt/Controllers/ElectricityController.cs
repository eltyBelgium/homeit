using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using API.DTO;
using HomeIt.Db;
using HomeIt.Models;
using HomeIt.Repositorys;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Produces("application/json")]
    [Route("api/electricity")]
    public class ElectricityController : Controller
    {
        private IRepository<Electricity> _repository;
        private ElectricityMapper mapper = new ElectricityMapper();

        public ElectricityController(IRepository<Electricity> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult GetAllGas() => Ok(_repository.GetAll());

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetElectricity(int id)
        {
            if (id == 0 )
             return NotFound();
            var electricity = _repository.Get(id);
            return Ok(electricity);
        }

        [HttpPost]
        public IActionResult AddElectricity([FromBody]ElectricityDTO command)
        {
            var electricity = new Electricity();;
            mapper.MapToModel(command, electricity);

            _repository.Insert(electricity);
            return Created(String.Empty, electricity);
        }

        [HttpPut]
        public IActionResult UpdateElectricity([FromBody]ElectricityDTO command)
        {
            var electricity = _repository.Get(command.Id);
            
            mapper.MapToModel(command, electricity);

            _repository.Update(electricity);

            return Ok();
        }
    }
}