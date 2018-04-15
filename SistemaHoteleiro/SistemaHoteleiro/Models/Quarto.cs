using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaHoteleiro.Models
{
    public class Quarto : IEntidade
    {
        public Quarto()
        {
            Reservas = new List<Reserva>();
        }

        public int Id { get; set; }
        public string Descricao { get; set; }
        public int MaxPessoas { get; set; }
        public bool Disponibilidade { get; set; }
        public int HotelId { get; set; }
        public int CategoriaId { get; set; }

        public virtual Hotel Hotel { get; set; }
        public virtual Categoria Categoria { get; set; }

        public virtual ICollection<Reserva> Reservas { get; set; }
    }
}
