using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaHoteleiro.Models
{
    public class TipoReserva : IEntidade
    {
        public TipoReserva()
        {
            Reservas = new List<Reserva>();
        }

        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }

        public virtual ICollection<Reserva> Reservas { get; set; }
    }
}
