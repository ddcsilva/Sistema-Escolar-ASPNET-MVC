namespace SistemaEscolar.Business.Models;

public class Aluno : Base
{
    public string Nome { get; set; }
    public string Documento { get; set; }
    public DateTime DataNascimento { get; set; }
    public Sexo Sexo { get; set; }
    public Endereco Endereco { get; set; }
    public string Email { get; set; }
    public string Telefone { get; set; }
    public bool Ativo { get; set; }
    public DateTime DataMatricula { get; set; }
    public DateTime? DataSaida { get; set; }
}