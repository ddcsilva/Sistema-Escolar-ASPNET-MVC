using SistemaEscolar.Business.Models;

namespace SistemaEscolar.Business.Interfaces;

public interface IAlunoRepository : IRepository<Aluno>
{
    Task<Aluno> ObterAlunoEndereco(Guid id);
}
