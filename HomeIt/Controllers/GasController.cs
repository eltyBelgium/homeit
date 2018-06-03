using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using API.DTO;
using API.Models;
using API.Repositorys;
using AutoMapper;
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
        private IMapper _mapper;

        public GasController(IRepository<Gas> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get() => Ok(_repository.GetAll());

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
        public IActionResult Add([FromBody]GasDTO command)
        {

            var item = _mapper.Map<GasDTO,Gas>(command);

            _repository.Insert(item);

            return Created(String.Empty, item);
        }

        [HttpPut]
        
        public IActionResult Update([FromBody]GasDTO command)
        {
            var item = _repository.Get(command.Id);


            _repository.Update(item);

            return Ok();
        }
    }
}