using Microsoft.EntityFrameworkCore;
using SistemaHoteleiro.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaHoteleiro.Repositories
{
    public class FuncionarioRepository : RepositoryBase<Funcionario>, IFuncionarioRepository
    {
        public FuncionarioRepository(SistemaHoteleiroContexto contexto) : base(contexto)
        {
            contexto.Funcionarios.Include(f => f.Pessoa);
        }
    }
}
