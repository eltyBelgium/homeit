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
    [Route("api/gas")]
    public class GasController : Controller
    {
        private IRepository<Gas> _repository;
        private GasMapper mapper = new GasMapper();

        public GasController(IRepository<Gas> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult GetAllGas() => Ok(_repository.GetAll());

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetGas(int id)
        {
            if (id == 0 )
             return NotFound();
            var gas = _repository.Get(id);
            return Ok(gas);
        }

        [HttpPost]
        public IActionResult AddGas([FromBody]GasDTO command)
        {
            var gas = new Gas();;
            mapper.MapToModel(command,gas);

            _repository.Insert(gas);
            return Created(String.Empty, gas);
        }

        [HttpPut]
        
        public IActionResult UpdateGas([FromBody]GasDTO command)
        {
            var gas = _repository.Get(command.Id);
            
            mapper.MapToModel(command, gas);

            _repository.Update(gas);

            return Ok();
        }
    }
}