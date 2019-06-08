using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace AppControle.AplicationCore.Interfaces.Repository
{
   public interface IRepository<T> where T : class
    {
        T Adicionar(T entity);

        void Atualizar(T entity);

        IEnumerable<T> ObterTodos();

        T ObterPorId(int id);

        IEnumerable<T> Buscar(Expression<Func<T, bool>> predicado);

        void Revover(T entity);
    }
}
