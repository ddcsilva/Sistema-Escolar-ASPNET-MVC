using SistemaEscolar.Business.Models;
using System.Linq.Expressions;

namespace SistemaEscolar.Business.Interfaces;

public interface IRepository<TEntity> : IDisposable where TEntity : Base
{
    Task<IEnumerable<TEntity>> Buscar(Expression<Func<TEntity, bool>> predicate);
    Task<List<TEntity>> ObterTodos();
    Task<TEntity> ObterPorId(Guid id);
    Task Adicionar(TEntity entity);
    Task Atualizar(TEntity entity);
    Task Remover(Guid id);
    Task<int> SaveChanges();
}