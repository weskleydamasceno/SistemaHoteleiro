using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaHoteleiro.Models
{
    public class Hotel : IEntidade
    {
        public Hotel()
        {
            Funcionarios = new List<Funcionario>();
            Quartos = new List<Quarto>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }

        public virtual ICollection<Funcionario> Funcionarios { get; set; }
        public virtual ICollection<Quarto> Quartos { get; set; }
    }
}
