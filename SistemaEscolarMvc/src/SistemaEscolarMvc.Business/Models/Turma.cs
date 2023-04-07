namespace SistemaEscolarMvc.Business.Models;

public class Turma : Entity
{
    public Guid CursoId { get; set; }
    public Guid ProfessorId { get; set; }
    public string Nome { get; set; }
    public DateTime DataInicio { get; set; }
    public DateTime DataFim { get; set; }
    public Turno Turno { get; set; }

    /* EF Relation */
    public Curso Curso { get; set; }
    public Professor Professor { get; set; }
    public ICollection<Matricula> Matriculas { get; set; }
    public ICollection<Disciplina> Disciplinas { get; set; }
    public ICollection<Professor> Professores { get; set; }
    public ICollection<Aluno> Alunos { get; set; }
}
