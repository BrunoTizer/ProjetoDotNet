namespace FalxConnectAPI.Entities;

public class Endereco
{
    public int Id {  get; set; }
    public string CEP { get; set; }
    public string Logradouro { get; set; }
    public string Numero { get; set; }
    public string Complemento { get; set; }
    public string Bairro { get; set; }
    public string Cidade { get; set; }
    public string UF { get; set; }
    
    public int PacienteId { get; set; }
    public Paciente Paciente { get; set; }
    
    public int MedicoId { get; set; }
    public Medico Medico { get; set; }
    
}