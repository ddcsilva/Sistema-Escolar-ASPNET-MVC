namespace SistemaEscolarMvc.Business.Models;

public class Curso : Entity
{
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public int DuracaoHoras { get; set; }

    /* EF Relations */
    public ICollection<Matricula> Matriculas { get; set; }
    public ICollection<Turma> Turmas { get; set; }
    public ICollection<Disciplina> Disciplinas { get; set; }
}
