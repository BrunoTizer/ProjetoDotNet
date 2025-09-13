using FalxConnectAPI.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FalxConnectAPI.Mappings;

public class EnderecoMapping : IEntityTypeConfiguration<Endereco>
{
    public void Configure(EntityTypeBuilder<Endereco> builder)
    {
        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.Id).IsRequired();
        
        builder.Property(x => x.Logradouro).IsRequired();
        
        builder.Property(x => x.Bairro).IsRequired().HasMaxLength(200);
        
        builder.Property(x => x.CEP).IsRequired().HasMaxLength(20);
        
        builder.Property(x => x.Cidade).IsRequired().HasMaxLength(100);
        
    }
}