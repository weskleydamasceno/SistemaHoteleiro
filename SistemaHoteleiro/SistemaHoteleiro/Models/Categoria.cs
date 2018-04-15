using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaHoteleiro.Models
{
    public class Categoria : IEntidade
    {
        public Categoria()
        {
            Quartos = new List<Quarto>();
        }

        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal valor { get; set; }

        public virtual ICollection<Quarto> Quartos { get; set; }
    }
}
