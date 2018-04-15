using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaHoteleiro.Models
{
    public class CheckinCheckout : IEntidade
    {
        public int Id { get; set; }
        public DateTime DataHoraCheckin { get; set; }
        public DateTime DataHoraCheckout { get; set; }
        public decimal TotalPagar { get; set; }
        public int FuncionarioId { get; set; }
        public int ReservaId { get; set; }

        public virtual Funcionario Funcionario { get; set; }
        public virtual Reserva Reserva { get; set; }
    }
}
