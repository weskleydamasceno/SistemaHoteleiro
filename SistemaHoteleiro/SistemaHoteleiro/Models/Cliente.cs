using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaHoteleiro.Models
{
    public class Cliente : IEntidade
    {
        public Cliente()
        {
            ClienteTelefones = new List<ClienteTelefone>();
            Reservas = new List<Reserva>();
        }

        public int Id { get; set; }
        public string Email { get; set; }
        public int PessoaId { get; set; }

        public virtual Pessoa Pessoa { get; set; }

        public virtual ICollection<ClienteTelefone> ClienteTelefones { get; set; }
        public virtual ICollection<Reserva> Reservas { get; set; }
    }
}
