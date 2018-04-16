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
    public class CategoriaController : Controller
    {
        private readonly ICategoriaRepository _repositorio;

        public CategoriaController(ICategoriaRepository repositorio)
        {
            _repositorio = repositorio;
        }

        [HttpGet]
        public IEnumerable<Categoria> GetAll()
        {
            return _repositorio.GetAll();
        }

        [HttpGet("{id}", Name = "GetCategoria")]
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
        public IActionResult Create([FromBody] Categoria categoria)
        {
            if (categoria == null)
            {
                return BadRequest();
            }

            _repositorio.Add(categoria);

            return CreatedAtRoute("GetCategoria", new { id = categoria.Id }, categoria);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Categoria item)
        {
            if (item == null || item.Id != id)
            {
                return BadRequest();
            }

            var categoria = _repositorio.Find(id);
            if (categoria == null)
            {
                return NotFound();
            }

            categoria.Descricao = item.Descricao;
            categoria.valor = item.valor;

            _repositorio.Update(categoria);
            return new NoContentResult();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var categoria = _repositorio.Find(id);
            if (categoria == null)
            {
                return NotFound();
            }

            _repositorio.Remove(id);
            return new NoContentResult();
        }



    }
}
