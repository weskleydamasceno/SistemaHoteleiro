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
    public class ReservaServicoController : Controller
    {
        private readonly IReservaServicoRepository _repositorio;

        public ReservaServicoController(IReservaServicoRepository repositorio)
        {
            _repositorio = repositorio;
        }

        [HttpGet]
        public IEnumerable<ReservaServico> GetAll()
        {
            return _repositorio.GetAll();
        }

        [HttpGet("{id}", Name = "GetReservaServico")]
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
        public IActionResult Create([FromBody] ReservaServico reservaServico)
        {
            if (reservaServico == null)
            {
                return BadRequest();
            }

            _repositorio.Add(reservaServico);

            return CreatedAtRoute("GetReservaServico", new { id = reservaServico.Id }, reservaServico);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] ReservaServico item)
        {
            if (item == null || item.Id != id)
            {
                return BadRequest();
            }

            var reservaServico = _repositorio.Find(id);
            if (reservaServico == null)
            {
                return NotFound();
            }

            reservaServico.Qtde = item.Qtde;
            reservaServico.Data = item.Data;
            reservaServico.ReservaId = item.ReservaId;
            reservaServico.ServicoId = item.ServicoId;

            _repositorio.Update(reservaServico);
            return new NoContentResult();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var reservaServico = _repositorio.Find(id);
            if (reservaServico == null)
            {
                return NotFound();
            }

            _repositorio.Remove(id);
            return new NoContentResult();
        }
    }
}