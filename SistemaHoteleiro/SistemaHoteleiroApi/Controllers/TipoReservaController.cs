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
    public class TipoReservaController : Controller
    {
        private readonly ITipoReservaRepository _repositorio;

        public TipoReservaController(ITipoReservaRepository repositorio)
        {
            _repositorio = repositorio;
        }

        [HttpGet]
        public IEnumerable<TipoReserva> GetAll()
        {
            return _repositorio.GetAll();
        }

        [HttpGet("{id}", Name = "GetTipoReserva")]
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
        public IActionResult Create([FromBody] TipoReserva tipoReserva)
        {
            if (tipoReserva == null)
            {
                return BadRequest();
            }

            _repositorio.Add(tipoReserva);

            return CreatedAtRoute("GetTipoReserva", new { id = tipoReserva.Id }, tipoReserva);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] TipoReserva item)
        {
            if (item == null || item.Id != id)
            {
                return BadRequest();
            }

            var tipoReserva = _repositorio.Find(id);
            if (tipoReserva == null)
            {
                return NotFound();
            }

            tipoReserva.Descricao = item.Descricao;
            tipoReserva.Valor = item.Valor;

            _repositorio.Update(tipoReserva);
            return new NoContentResult();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var tipoReserva = _repositorio.Find(id);
            if (tipoReserva == null)
            {
                return NotFound();
            }

            _repositorio.Remove(id);
            return new NoContentResult();
        }
    }
}