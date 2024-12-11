using System;
using KikoStore.Core.Entities;

namespace KikoStore.Core.Interfaces;

public interface IGenericRepository<T> where T : BaseEntity{

    Task<T?> GetByIdAsync(int id);
    Task<IReadOnlyList<T>> GetAllAsync();
    Task<IReadOnlyList<T>> GetAsync(ISpecification<T> spec);
    Task<T?> GetEntityWithSpec(ISpecification<T> spec);
    Task<IReadOnlyList<TResult>> ListAsync<TResult>(ISpecification<T,TResult> spec);
    Task<TResult?> GetEntityWithSpec<TResult>(ISpecification<T,TResult> spec);
    void Add(T entity);
    void Update(T entity);
    void Delete(T entity);
    Task<bool> SaveChangesAsync();
    bool IsExsits(int id);
    Task<int> CountAsync(ISpecification<T> spec);
}