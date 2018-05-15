using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        public UtilityRepository<Gas> _Repository = new UtilityRepository<Gas>(new DataContext(new DbContextOptions<DataContext>())); 

        [HttpGet]
        public IEnumerable<Gas> Get() => _Repository.GetAll();
    }
}