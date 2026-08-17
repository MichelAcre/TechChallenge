using System.ComponentModel.DataAnnotations;

namespace TechChallenge.Models;
public class Equipe
{
    [Required (ErrorMessage = "O campo ID é obrigatório")]public int Id { get; set; }
    [Required (ErrorMessage = "O campo do nome é obrigatório.")][StringLength(50)] public string Nome { get; set; }
    [StringLength(200)] public string? Descricao { get; set; }
    public DateTime DataCriacao { get; set; } = DateTime.Now;
    public bool Ativa { get; set; } = true;
    public ICollection<AlunoEquipe> AlunosEquipes { get; set; } = new List<AlunoEquipe>();
    public ICollection<Projeto> Projetos { get; set; } = new List<Projeto>();
}