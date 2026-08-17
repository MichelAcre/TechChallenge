using System.ComponentModel.DataAnnotations;

namespace TechChallenge.Models;

public class AlunoEquipe
{
    [Required (ErrorMessage = "O campo ID é obrigatório")] public int AlunoId { get; set; }
    public Aluno? Aluno { get; set; }
    public int EquipeId { get; set; }
    public Equipe? Equipe { get; set; }
    public DateTime DataEntrada { get; set; } = DateTime.Now;
}