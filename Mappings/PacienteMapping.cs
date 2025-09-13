using FalxConnectAPI.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FalxConnectAPI.Mappings;

public class PacienteMapping : IEntityTypeConfiguration<Paciente>
{
    public void Configure(EntityTypeBuilder<Paciente> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).IsRequired();
        
        builder.Property(x => x.Nome).IsRequired().HasMaxLength(100);
        builder.HasIndex(x => x.Nome).IsUnique();
        
        builder.HasMany(x => x.Enderecos)
            .WithOne(x => x.Paciente)
            .HasForeignKey( x => x.PacienteId );
    }
}