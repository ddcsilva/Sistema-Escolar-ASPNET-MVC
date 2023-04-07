using Microsoft.EntityFrameworkCore;
using SistemaEscolar.Business.Interfaces;
using SistemaEscolar.Business.Models;
using SistemaEscolar.Data.Context;
using System.Linq.Expressions;

namespace SistemaEscolar.Data.Repository;

public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : Base, new()
{
    protected readonly SistemaEscolarContext _context;
    protected readonly DbSet<TEntity> _dbSet;

    public Repository(SistemaEscolarContext context)
    {
        _context = context;
        _dbSet = _context.Set<TEntity>();
    }

    public async Task<IEnumerable<TEntity>> Buscar(Expression<Func<TEntity, bool>> predicate)
    {
        return await _dbSet.AsNoTracking().Where(predicate).ToListAsync();
    }

    public virtual async Task<TEntity> ObterPorId(Guid id)
    {
        return await _dbSet.FindAsync(id);
    }

    public virtual async Task<List<TEntity>> ObterTodos()
    {
        return await _dbSet.ToListAsync();
    }

    public virtual async Task Adicionar(TEntity entity)
    {
        _dbSet.Add(entity);
        await SaveChanges();
    }

    public virtual async Task Atualizar(TEntity entity)
    {
        _dbSet.Update(entity);
        await SaveChanges();
    }

    public virtual async Task Remover(Guid id)
    {
        _dbSet.Remove(new TEntity { Id = id });
        await SaveChanges();
    }

    public async Task<int> SaveChanges()
    {
        return await _context.SaveChangesAsync();
    }

    public void Dispose()
    {
        _context?.Dispose();
    }
}
