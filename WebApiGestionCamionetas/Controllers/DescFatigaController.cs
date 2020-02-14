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
    public class DescFatigaController : ControllerBase
    {
        private readonly AppDbContext context;
        public DescFatigaController(AppDbContext _context)
        {
            this.context = _context;
        }
        // GET: api/DescFatiga
        [HttpGet]
        public IEnumerable<DescFatiga> Get()
        {
            return context.DescFatiga.ToList();

        }

        // GET: api/DescFatiga/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST: api/DescFatiga
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT: api/DescFatiga/5
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
