using FalxConnectAPI.Entities;
using FalxConnectAPI.Mappings;
using Microsoft.EntityFrameworkCore;

namespace FalxConnectAPI;

public class CirurgiaContext : DbContext
{

    public CirurgiaContext(DbContextOptions<CirurgiaContext> options) : base(options)
    {
      
    }

  
    public DbSet<Paciente> Pacientes { get; set; }
    
    public DbSet<Endereco> Enderecos { get; set; }
    
    public DbSet<Medico> Medicos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new PacienteMapping());
        modelBuilder.ApplyConfiguration(new EnderecoMapping());
        modelBuilder.ApplyConfiguration(new MedicoMapping());
    }
}