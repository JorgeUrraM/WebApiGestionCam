﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiGestionCamionetas.Context;
using WebApiGestionCamionetas.Entities;
using WebApiGestionCamionetas.ViewModels;

namespace WebApiGestionCamionetas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly AppDbContext context;
        public UsuarioController(AppDbContext _context)
        {
            this.context = _context;
        }
        // GET: api/Usuario
        [HttpGet]
        public IEnumerable<Usuario> Get()
        {
            return context.Usuario.ToList();
        }

        // GET: api/Usuario/5
        [HttpGet("{id}", Name = "Get")]
        public Usuario Get(int id)
        {
            return context.Usuario.FirstOrDefault(u=>u.IdUsuario == id);
        }
        
        [HttpPost]
        // POST: api/Usuario
        //[HttpPost]
        public Usuario Login([FromBody] LoginCred credenciales)
        {
            return context.Usuario.FirstOrDefault(u => u.Email == credenciales.Email && u.Password == credenciales.Password);
        }

        //// PUT: api/Usuario/5
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
