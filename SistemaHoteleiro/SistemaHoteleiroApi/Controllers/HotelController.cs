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
    public class HotelController : Controller
    {
        private readonly IHotelRepository _repositorio;

        public HotelController(IHotelRepository repositorio)
        {
            _repositorio = repositorio;
        }

        [HttpGet]
        public IEnumerable<Hotel> GetAll()
        {
            return _repositorio.GetAll();
        }

        [HttpGet("{id}", Name = "GetHotel")]
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
        public IActionResult Create([FromBody] Hotel hotel)
        {
            if (hotel == null)
            {
                return BadRequest();
            }

            _repositorio.Add(hotel);

            return CreatedAtRoute("GetHotel", new { id = hotel.Id }, hotel);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Hotel item)
        {
            if (item == null || item.Id != id)
            {
                return BadRequest();
            }

            var hotel = _repositorio.Find(id);
            if (hotel == null)
            {
                return NotFound();
            }

            hotel.Nome = item.Nome;
            hotel.Rua = item.Rua;
            hotel.Bairro = item.Bairro;
            hotel.Cidade = item.Cidade;

            _repositorio.Update(hotel);
            return new NoContentResult();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var hotel = _repositorio.Find(id);
            if (hotel == null)
            {
                return NotFound();
            }

            _repositorio.Remove(id);
            return new NoContentResult();
        }
    }
}