using Microsoft.EntityFrameworkCore;
using SistemaHoteleiro.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaHoteleiro.Repositories
{
    public class QuartoRepository : RepositoryBase<Quarto>, IQuartoRepository
    {
        public QuartoRepository(SistemaHoteleiroContexto contexto) : base(contexto)
        {
            contexto.Quartos.Include(q => q.Categoria);
        }
    }
}
