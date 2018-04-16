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
    public class CheckinCheckoutController : Controller
    {
        private readonly ICheckinCheckoutRepository _repositorio;

        public CheckinCheckoutController(ICheckinCheckoutRepository repositorio)
        {
            _repositorio = repositorio;
        }

        [HttpGet]
        public IEnumerable<CheckinCheckout> GetAll()
        {
            return _repositorio.GetAll();
        }

        [HttpGet("{id}", Name = "GetCheckinCheckout")]
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
        public IActionResult Create([FromBody] CheckinCheckout checkinCheckout)
        {
            if (checkinCheckout == null)
            {
                return BadRequest();
            }

            _repositorio.Add(checkinCheckout);

            return CreatedAtRoute("GetCheckinCheckout", new { id = checkinCheckout.Id }, checkinCheckout);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] CheckinCheckout item)
        {
            if (item == null || item.Id != id)
            {
                return BadRequest();
            }

            var checkinCheckout = _repositorio.Find(id);
            if (checkinCheckout == null)
            {
                return NotFound();
            }

            checkinCheckout.DataHoraCheckin = item.DataHoraCheckin;
            checkinCheckout.DataHoraCheckout = item.DataHoraCheckout;
            checkinCheckout.TotalPagar = item.TotalPagar;
            checkinCheckout.FuncionarioId = item.FuncionarioId;
            checkinCheckout.ReservaId = item.ReservaId;

            _repositorio.Update(checkinCheckout);
            return new NoContentResult();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var checkinCheckout = _repositorio.Find(id);
            if (checkinCheckout == null)
            {
                return NotFound();
            }

            _repositorio.Remove(id);
            return new NoContentResult();
        }
    }
}
