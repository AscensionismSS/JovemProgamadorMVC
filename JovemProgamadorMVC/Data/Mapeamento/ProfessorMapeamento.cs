using JovemProgamadorMVC.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace JovemProgamadorMVC.Data.Mapeamento
{
    public class ProfessorMapeamento : IEntityTypeConfiguration<Professor>
    {
        public void Configure(EntityTypeBuilder<Professor> builder)
        {
            builder.ToTable("Professor");

            builder.HasKey(t => t.Id);

            builder.Property(t => t.Nome).HasColumnType("varchar(30)");
            builder.Property(t => t.Cpf).HasColumnType("varchar(20)");
            builder.Property(t => t.Disciplina).HasColumnType("varchar(20)");

        }
    }
}