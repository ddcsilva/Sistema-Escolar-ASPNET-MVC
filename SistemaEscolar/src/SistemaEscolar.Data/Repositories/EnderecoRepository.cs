using Microsoft.EntityFrameworkCore;
using SistemaEscolar.Business.Interfaces;
using SistemaEscolar.Business.Models;
using SistemaEscolar.Data.Context;

namespace SistemaEscolar.Data.Repository;

public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
{
    public EnderecoRepository(SistemaEscolarContext context) : base(context) { }

    public async Task<Endereco> ObterEnderecoPorAluno(Guid alunoId)
    {
        return await _context.Enderecos.AsNoTracking()
            .FirstOrDefaultAsync(e => e.AlunoId == alunoId);
    }
}
