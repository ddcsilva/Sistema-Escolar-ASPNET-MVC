namespace SistemaEscolar.Business.Models;

public class Endereco : Base
{
    public Guid AlunoId { get; set; }
    public string Rua { get; set; }
    public string Numero { get; set; }
    public string Complemento { get; set; }
    public string Cep { get; set; }
    public string Bairro { get; set; }
    public string Cidade { get; set; }
    public string Estado { get; set; }

    /* EF Relation */
    public Aluno Aluno { get; set; }
}