using Microsoft.EntityFrameworkCore;
using SistemaEscolar.Business.Interfaces;
using SistemaEscolar.Business.Models;
using SistemaEscolar.Data.Context;

namespace SistemaEscolar.Data.Repository;

public class AlunoRepository : Repository<Aluno>, IAlunoRepository
{
    public AlunoRepository(SistemaEscolarContext context) : base(context) { }

    public async Task<Aluno> ObterAlunoEndereco(Guid id)
    {
        return await _context.Alunos.AsNoTracking()
            .Include(f => f.Endereco)
            .FirstOrDefaultAsync(f => f.Id == id);
    }
}
