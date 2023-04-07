using Microsoft.EntityFrameworkCore;
using SistemaEscolar.Business.Models;

namespace SistemaEscolar.Data.Context;

public class SistemaEscolarContext : DbContext
{
    public SistemaEscolarContext(DbContextOptions options) : base(options)
    {

    }

    public DbSet<Aluno> Alunos { get; set; }
    public DbSet<Endereco> Enderecos { get; set; }
}
