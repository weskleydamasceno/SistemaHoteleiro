using SistemaHoteleiro.Models;
using System;
using System.Collections.Generic;
using System.Text;
using SistemaHoteleiro.Repositories;

namespace SistemaHoteleiro.Services
{
    public class FuncionarioService : ServiceBase<Funcionario>, IFuncionarioService
    {
        public FuncionarioService(IRepositoryBase<Funcionario> repositorio) : base(repositorio)
        {
        }
    }
}
