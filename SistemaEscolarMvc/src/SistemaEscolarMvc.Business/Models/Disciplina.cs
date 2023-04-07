namespace SistemaEscolarMvc.Business.Models;

public class Disciplina : Entity
{
    public string Nome { get; set; }
    public int DuracaoHoras { get; set; }
    public Guid TurmaId { get; set; }
    public Guid ProfessorId { get; set; }
    public Guid CursoId { get; set; }
    public Professor Professor { get; set; }
    public Curso Curso { get; set; }
    public ICollection<Turma> Turmas { get; set; }
}
