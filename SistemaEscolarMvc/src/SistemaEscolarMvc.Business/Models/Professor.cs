namespace SistemaEscolarMvc.Business.Models;

public class Professor : Entity
{
    public string Nome { get; set; }
    public string Email { get; set; }
    public ICollection<Turma> Turmas { get; set; }
    public ICollection<Disciplina> Disciplinas { get; set; }
}
