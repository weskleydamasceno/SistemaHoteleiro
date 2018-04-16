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
    public class ReservaController : Controller
    {
        private readonly IReservaRepository _repositorio;

        public ReservaController(IReservaRepository repositorio)
        {
            _repositorio = repositorio;
        }

        [HttpGet]
        public IEnumerable<Reserva> GetAll()
        {
            return _repositorio.GetAll();
        }

        [HttpGet("{id}", Name = "GetReserva")]
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
        public IActionResult Create([FromBody] Reserva reserva)
        {
            if (reserva == null)
            {
                return BadRequest();
            }

            _repositorio.Add(reserva);

            return CreatedAtRoute("GetReserva", new { id = reserva.Id }, reserva);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Reserva item)
        {
            if (item == null || item.Id != id)
            {
                return BadRequest();
            }

            var reserva = _repositorio.Find(id);
            if (reserva == null)
            {
                return NotFound();
            }

            reserva.DataHoraInicio = item.DataHoraInicio;
            reserva.DataHoraFinal = item.DataHoraFinal;
            reserva.Valor = item.Valor;
            reserva.ClienteId = item.ClienteId;
            reserva.QuartoId = item.QuartoId;
            reserva.TipoReservaId = item.TipoReservaId;

            _repositorio.Update(reserva);
            return new NoContentResult();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var reserva = _repositorio.Find(id);
            if (reserva == null)
            {
                return NotFound();
            }

            _repositorio.Remove(id);
            return new NoContentResult();
        }
    }
}