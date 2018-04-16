using Microsoft.AspNetCore.Mvc;
using SistemaHoteleiro.Models;
using SistemaHoteleiro.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaHoteleiroApi.Controllers
{
    [Route("api/[controller]")]
    public class ServicoController : Controller
    {
        private readonly IServicoRepository _repositorio;

        public ServicoController(IServicoRepository repositorio)
        {
            _repositorio = repositorio;
        }

        [HttpGet]
        public IEnumerable<Servico> GetAll()
        {
            return _repositorio.GetAll();
        }

        [HttpGet("{id}", Name = "GetServico")]
        public IActionResult GetById(int id)
        {
            var item = _repositorio.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Servico servico)
        {
            if (servico == null)
            {
                return BadRequest();
            }

            _repositorio.Add(servico);

            return CreatedAtRoute("GetServico", new { id = servico.Id }, servico);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Servico item)
        {
            if (item == null || item.Id != id)
            {
                return BadRequest();
            }

            var servico = _repositorio.Find(id);
            if (servico == null)
            {
                return NotFound();
            }

            servico.Descricao = item.Descricao;
            servico.Valor = item.Valor;

            _repositorio.Update(servico);
            return new NoContentResult();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var servico = _repositorio.Find(id);
            if (servico == null)
            {
                return NotFound();
            }

            _repositorio.Remove(id);
            return new NoContentResult();
        }
    }
}