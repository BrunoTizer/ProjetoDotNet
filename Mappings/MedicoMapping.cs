using FalxConnectAPI.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FalxConnectAPI.Mappings;

//Entity Framework ORM 
public class MedicoMapping : IEntityTypeConfiguration<Medico>
{
    public void Configure(EntityTypeBuilder<Medico> builder)
    {   
        // PK
        builder.HasKey( x => x.Id );
        builder.Property( x => x.Nome ).IsRequired().HasMaxLength(100);
        
        builder.Property( x => x.CRM ).IsRequired().HasMaxLength(10);
        builder.HasIndex( x => x.CRM ).IsUnique();
        
        builder.HasMany(x => x.Enderecos)
            .WithOne(x => x.Medico)
            .HasForeignKey( x => x.MedicoId );
        
    }
}