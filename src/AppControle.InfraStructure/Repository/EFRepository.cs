using AppControle.AplicationCore.Interfaces.Repository;
using AppControle.InfraStructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace AppControle.InfraStructure.Repository
{
    public class EFRepository<T> : IRepository<T> where T : class
    {
        protected readonly DataContext _context;

        public EFRepository(DataContext context)
        {
            _context = context;
        }
        public T Adicionar(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public void Atualizar(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public IEnumerable<T> Buscar(Expression<Func<T, bool>> predicado)
        {
            return _context.Set<T>().Where(predicado).AsEnumerable();
        }

        public T ObterPorId(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public IEnumerable<T> ObterTodos()
        {
            return _context.Set<T>().AsEnumerable();
        }

        public void Revover(T entity)
        {
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }
    }
}
