using AppControle.AplicationCore.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppControle.InfraStructure.EntityConfig
{
    public class PessoaMap : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.HasKey(c => c.PessoaId);

            builder.HasOne(c => c.PessoaTipo)
                .WithMany(c => c.Pessoas)
                .HasForeignKey(c => c.PessoaTipoId)
                .HasPrincipalKey(c => c.PessoaTipoId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
