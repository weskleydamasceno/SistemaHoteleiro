using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaHoteleiro.Models
{
    public class SistemaHoteleiroContexto : DbContext
    {
        public SistemaHoteleiroContexto(DbContextOptions<SistemaHoteleiroContexto> options) : base(options)
        {

        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<CheckinCheckout> CheckinsCheckouts { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<ClienteTelefone> ClienteTelefones { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Hotel> Hoteis { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Quarto> Quartos { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<ReservaServico> ReservaServicos { get; set; }
        public DbSet<Servico> Servicos { get; set; }
        public DbSet<TipoReserva> TiposReservas { get; set; }
    }
}
