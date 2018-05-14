using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeIt.Db;
using HomeIt.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Produces("application/json")]
    [Route("api/gas")]
    public class GasController : Controller
    {
        public DataContext _dataContext { get; set; }
        [HttpGet]
        public IEnumerable<Gas> Get() => _dataContext.
    }
}