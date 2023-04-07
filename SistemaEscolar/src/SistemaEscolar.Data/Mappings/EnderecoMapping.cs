using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaEscolar.Business.Models;

namespace SistemaEscolar.Data.Mappings;

public class EnderecoMapping : IEntityTypeConfiguration<Endereco>
{
    public void Configure(EntityTypeBuilder<Endereco> builder)
    {
        // Chave Primária
        builder.HasKey(e => e.Id);

        // Colunas
        builder.Property(e => e.Rua)
           .IsRequired()
           .HasColumnType("varchar(200)");

        builder.Property(e => e.Numero)
            .IsRequired()
            .HasColumnType("varchar(50)");

        builder.Property(e => e.Cep)
            .IsRequired()
            .HasColumnType("varchar(8)");

        builder.Property(e => e.Complemento)
            .HasColumnType("varchar(250)");

        builder.Property(e => e.Bairro)
            .IsRequired()
            .HasColumnType("varchar(100)");

        builder.Property(e => e.Cidade)
            .IsRequired()
            .HasColumnType("varchar(100)");

        builder.Property(e => e.Estado)
            .IsRequired()
            .HasColumnType("varchar(50)");

        // Index
        builder.HasIndex(e => e.AlunoId)
            .HasDatabaseName("IX_Endereco_AlunoId")
            .IsUnique();

        // Tabela
        builder.ToTable("Enderecos");
    }
}
