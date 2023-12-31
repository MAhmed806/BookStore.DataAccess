﻿using System.Linq.Expressions;

namespace BookStore.DataAccess.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll(Expression<Func<T, bool>>? filter=null,string? includeProperties = null);
        T Get(Expression<Func<T, bool>> filter,string? includeProperties=null,bool tracked=false);
        void Add(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
        //void Update(T entity);
        //void SaveChanges();

    }
}
