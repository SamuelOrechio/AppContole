using AppControle.AplicationCore.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppControle.InfraStructure.EntityConfig
{
    public class PessoaTipoMap : IEntityTypeConfiguration<PessoaTipo>
    {
        public void Configure(EntityTypeBuilder<PessoaTipo> builder)
        {
            builder.HasKey(c => c.PessoaTipoId);

            builder.HasMany(c => c.Pessoas)
                .WithOne(c => c.PessoaTipo)
                .HasForeignKey(c => c.PessoaTipoId)
                .HasPrincipalKey(c=> c.PessoaTipoId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(c => c.Descricao)
                .HasColumnType("Varchar(50)")
                .IsRequired();
        }
    }
}
