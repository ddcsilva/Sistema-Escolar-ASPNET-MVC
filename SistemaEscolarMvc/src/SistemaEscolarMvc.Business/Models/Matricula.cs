namespace SistemaEscolarMvc.Business.Models;

public class Matricula : Entity
{
    public Guid AlunoId { get; set; }
    public Guid CursoId { get; set; }
    public Guid TurmaId { get; set; }
    public DateTime DataMatricula { get; set; }

    /* EF Relation */
    public Aluno Aluno { get; set; }
    public Curso Curso { get; set; }
    public Turma Turma { get; set; }
}
