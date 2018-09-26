using Microsoft.AspNetCore.Mvc;
using MyWebApp.AcessoDados;
using MyWebApp.Entidades;
using System;
using System.Collections.Generic;

namespace MyWebApp.Controllers
{
    [Route("api/[Controller]")]
    public class EmpresaController : Controller
    {
        private readonly IEmpresaRepository _empresaRepository;

        public EmpresaController(IEmpresaRepository empresaRepository)
        {
            _empresaRepository = empresaRepository;

        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_empresaRepository.ListarEmpresas());

            }catch(Exception ex)
            {
                return BadRequest("Error:"+ ex.Message);
            }
            
        }

        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var empresa = _empresaRepository.ListarEmpresaById(id);
                return Ok(empresa.Nome);
            }
            catch (Exception ex)
            {
                return BadRequest("Error:" + ex.Message);
            }

        }

        [HttpPost]
        public IActionResult Post([FromBody]Empresa empresa)
        {
            try
            {
                _empresaRepository.Salvar(empresa);
                return Created("/api/empresa",empresa);
            }catch(Exception ex)
            {
                return BadRequest("Error:" + ex.Message);
            }
        }
    }
}
