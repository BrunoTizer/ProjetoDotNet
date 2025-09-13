namespace FalxConnectAPI.Entities;

public class Paciente
{
    public int Id { get; set; }
    
    public string Nome { get; set; }
    
    public List<Endereco> Enderecos { get; set; }
}