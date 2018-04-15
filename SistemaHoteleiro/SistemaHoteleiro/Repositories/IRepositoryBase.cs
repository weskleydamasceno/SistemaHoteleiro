using SistemaHoteleiro.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaHoteleiro.Repositories
{
    public interface IRepositoryBase<T> where T : class, IEntidade
    {
        void Add(T entidade);
        IEnumerable<T> GetAll();
        T Find(int id);
        void Remove(int id);
        void Update(T entidade);
    }
}
