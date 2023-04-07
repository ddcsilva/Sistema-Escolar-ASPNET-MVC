namespace SistemaEscolarMvc.Business.Models;

public class Aluno : Entity
{
    public string Nome { get; set; }
    public string Email { get; set; }
    public DateTime DataNascimento { get; set; }

    /* EF Relations */
    public ICollection<Matricula> Matriculas { get; set; }
    public ICollection<Turma> Turmas { get; set; }
}
