using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaHoteleiro.Models
{
    public class Funcionario : IEntidade
    {
        public Funcionario()
        {
            CheckinsCheckouts = new List<CheckinCheckout>();
        }

        public int Id { get; set; }
        public decimal Salario { get; set; }
        public int PessoaId { get; set; }
        public int HotelId { get; set; }

        public virtual Pessoa Pessoa { get; set; }
        public virtual Hotel Hotel { get; set; }

        public virtual ICollection<CheckinCheckout> CheckinsCheckouts { get; set; }
    }
}
