using SistemaHoteleiro.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaHoteleiro.Services
{
    public interface IServiceBase<T> where T : class, IEntidade
    {
        void Add(T entidade);
        IEnumerable<T> GetAll();
        T Find(int id);
        void Remove(int id);
        void Update(T entidade);
    }
}
