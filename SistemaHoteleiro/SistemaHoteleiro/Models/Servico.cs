using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaHoteleiro.Models
{
    public class Servico : IEntidade
    {
        public Servico()
        {
            ReservaServicos = new List<ReservaServico>();
        }

        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }

        public virtual ICollection<ReservaServico> ReservaServicos { get; set; }
    }
}
