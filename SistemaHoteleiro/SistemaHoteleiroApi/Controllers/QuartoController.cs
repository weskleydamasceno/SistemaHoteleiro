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
    public class QuartoController : Controller
    {
        private readonly IQuartoRepository _repositorio;

        public QuartoController(IQuartoRepository repositorio)
        {
            _repositorio = repositorio;
        }

        [HttpGet]
        public IEnumerable<Quarto> GetAll()
        {
            return _repositorio.GetAll();
        }

        [HttpGet("{id}", Name = "GetQuarto")]
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
        public IActionResult Create([FromBody] Quarto quarto)
        {
            if (quarto == null)
            {
                return BadRequest();
            }

            _repositorio.Add(quarto);

            return CreatedAtRoute("GetQuarto", new { id = quarto.Id }, quarto);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Quarto item)
        {
            if (item == null || item.Id != id)
            {
                return BadRequest();
            }

            var quarto = _repositorio.Find(id);
            if (quarto == null)
            {
                return NotFound();
            }

            quarto.Descricao = item.Descricao;
            quarto.MaxPessoas = item.MaxPessoas;
            quarto.Disponibilidade = item.Disponibilidade;
            quarto.HotelId = item.HotelId;
            quarto.CategoriaId = item.CategoriaId;

            _repositorio.Update(quarto);
            return new NoContentResult();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var quarto = _repositorio.Find(id);
            if (quarto == null)
            {
                return NotFound();
            }

            _repositorio.Remove(id);
            return new NoContentResult();
        }
    }
}