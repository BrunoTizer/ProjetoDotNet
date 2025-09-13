namespace FalxConnectAPI.Entities;

public class Medico
{
    public int Id { get; set; }
    
    public string Nome { get; set; }
    
    public string CRM { get; set; }
    
    public List<Endereco> Enderecos { get; set; }
    
    
 
}