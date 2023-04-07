using SistemaEscolar.Business.Models;

namespace SistemaEscolar.Business.Interfaces;

public interface IEnderecoRepository : IRepository<Endereco>
{
    Task<Endereco> ObterEnderecoPorAluno(Guid alunoId);
}
