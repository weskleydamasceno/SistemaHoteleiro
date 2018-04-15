using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaHoteleiro.Models
{
    public class Reserva : IEntidade
    {
        public Reserva()
        {
            CheckinsCheckouts = new List<CheckinCheckout>();
            ReservaServicos = new List<ReservaServico>();
        }

        public int Id { get; set; }
        public DateTime DataHoraInicio { get; set; }
        public DateTime DataHoraFinal { get; set; }
        public decimal Valor { get; set; }
        public int ClienteId { get; set; }
        public int QuartoId { get; set; }
        public int TipoReservaId { get; set; }

        public virtual Cliente Cliente{ get; set; }
        public virtual Quarto Quarto { get; set; }
        public virtual TipoReserva TipoReserva { get; set; }

        public virtual ICollection<CheckinCheckout> CheckinsCheckouts { get; set; }
        public virtual ICollection<ReservaServico> ReservaServicos { get; set; }
    }
}
