using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaHoteleiro.Models
{
    public class ReservaServico : IEntidade
    {
        public int Id { get; set; }
        public int Qtde { get; set; }
        public DateTime Data { get; set; }
        public int ReservaId { get; set; }
        public int ServicoId { get; set; }

        public virtual Reserva Reserva { get; set; }
        public virtual Servico Servico { get; set; }
    }
}
