using System.ComponentModel.DataAnnotations;

namespace TechChallenge;

public class Aluno
{
    [Required (ErrorMessage = "O campo ID é obrigatório")] public int Id { get; set; } // Primary Key
    [Required (ErrorMessage = "O campo de nome é obrigatório")][StringLength(100, ErrorMessage = "O nome deve ter entre 3 e 100 caracteres")]public string Nome { get; set; }
    [Required (ErrorMessage = "O campo de Email é obrigatório.")][EmailAddress]public string Email { get; set; }
    [Required (ErrorMessage = "O campo de telefone é obrigatório.")]public string Telefone { get; set; }
    [Required (ErrorMessage = "O campo de data de nascimento é obrigatório.")]public DateTime DataNascimento { get; set; }
    public DateTime DataCadastro { get; set; }
    public bool Ativo { get; set; }
}
