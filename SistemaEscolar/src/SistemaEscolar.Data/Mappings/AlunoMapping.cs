using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaEscolar.Business.Models;

namespace SistemaEscolar.Data.Mappings;

public class AlunoMapping : IEntityTypeConfiguration<Aluno>
{
    public void Configure(EntityTypeBuilder<Aluno> builder)
    {
        // Chave Primária
        builder.HasKey(a => a.Id);

        // Colunas
        builder.Property(a => a.Nome)
            .IsRequired()
            .HasColumnType("varchar(100)");

        builder.Property(a => a.Cpf)
            .IsRequired()
            .HasColumnType("varchar(11)");

        builder.Property(a => a.DataNascimento)
            .IsRequired()
            .HasColumnType("date");

        builder.Property(a => a.Sexo)
            .IsRequired();

        builder.Property(a => a.Email)
            .IsRequired(false)
            .HasColumnType("varchar(100)");

        builder.Property(a => a.Telefone)
            .IsRequired(false)
            .HasColumnType("varchar(20)");

        builder.Property(a => a.DataMatricula)
            .IsRequired()
            .HasColumnType("date");

        builder.Property(a => a.DataSaida)
            .IsRequired(false)
            .HasColumnType("date");

        builder.Property(a => a.Foto)
            .IsRequired(false)
            .HasColumnType("varchar(200)");

        // Relacionamentos

        // 1 : 1 => Fornecedor : Aluno
        builder.HasOne(f => f.Endereco)
            .WithOne(e => e.Aluno)
            .HasConstraintName("FK_Aluno_Endereco"); ;

        // Tabela
        builder.ToTable("Alunos");
    }
}
