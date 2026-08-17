using System.ComponentModel.DataAnnotations;
using TechChallenge.Models;

namespace TechChallenge;

public class Professor
{
    [Required (ErrorMessage = "O campo ID é obrigatório")]public int Id { get; set; }
    [Required (ErrorMessage = "O campo do nome é obrigatório.")][StringLength(100)] public string Nome { get; set; }
    [Required (ErrorMessage = "O campo do email é obrigatório.")][EmailAddress] public string Email { get; set; }
    [Required (ErrorMessage = "O campo da especialidade é obrigatório.")][StringLength(50)] public string Especialidade { get; set; }
    [DataType(DataType.Date)] public DateTime DataContratacao { get; set; }
    public bool Ativo { get; set; } = true;
    public ICollection<Projeto>? Projetos { get; set; } = new List<Projeto>();
}