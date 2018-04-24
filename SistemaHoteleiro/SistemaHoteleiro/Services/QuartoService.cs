using SistemaHoteleiro.Models;
using System;
using System.Collections.Generic;
using System.Text;
using SistemaHoteleiro.Repositories;

namespace SistemaHoteleiro.Services
{
    public class QuartoService : ServiceBase<Quarto>, IQuartoService
    {
        public QuartoService(IRepositoryBase<Quarto> repositorio) : base(repositorio)
        {
        }
    }
}
