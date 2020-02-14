using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiGestionCamionetas.Context;
using WebApiGestionCamionetas.Entities;

namespace WebApiGestionCamionetas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DescEstadoCamionetaController : ControllerBase
    {
        private readonly AppDbContext context;
        public DescEstadoCamionetaController(AppDbContext _context)
        {
            this.context = _context;
        }
        // GET: api/DescEstadoCamioneta
        [HttpGet]
        public IEnumerable<DescEstadoCamioneta> Get()
        {
            return context.DescEstadoCamioneta.ToList();

        }

        // GET: api/DescEstadoCamioneta/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST: api/DescEstadoCamioneta
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT: api/DescEstadoCamioneta/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
