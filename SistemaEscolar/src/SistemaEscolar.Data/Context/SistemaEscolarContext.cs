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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Setar o tipo e tamanho defaut de propriedades texto que não estiverem sido mapeadas
        foreach (var property in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetProperties().Where(p => p.ClrType == typeof(string))))
        {
            property.SetColumnType("varchar(100)");
        }

        // Registrar todos os mappings via Reflection
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(SistemaEscolarContext).Assembly);

        // Retirar o DeleteOnCascade dos relacionamentos
        foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
        {
            relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;
        }
    }
}
