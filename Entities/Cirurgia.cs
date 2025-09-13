namespace FalxConnectAPI.Entities;

public class Cirurgia
{
    public int Id { get; set; }
    
    public int PacienteId { get; set; }
    
    public int MedicoId { get; set; }
    
    public DateTime Data { get; set; }
    
}