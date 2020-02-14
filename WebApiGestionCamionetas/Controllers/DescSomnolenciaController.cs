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
    public class DescSomnolenciaController : ControllerBase
    {
        private readonly AppDbContext context;
        public DescSomnolenciaController(AppDbContext _context)
        {
            this.context = _context;
        }
        // GET: api/DescSomnolencia
        [HttpGet]
        public IEnumerable<DescSomnolencia> Get()
        {
            return context.DescSomnolencia.ToList();
        }

        // GET: api/DescSomnolencia/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST: api/DescSomnolencia
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT: api/DescSomnolencia/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE: api/ApiWithActions/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
