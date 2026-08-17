using System.ComponentModel.DataAnnotations;

namespace TechChallenge;

public class LoginViewModel
{
    [Required (ErrorMessage = "O campo do email é obrigatório.")][EmailAddress] public string Email { get; set; }
    [Required][DataType(DataType.Password)] public string Senha { get; set; }
    public bool Lembrar { get; set; }
    public string? ReturnUrl { get; set; }
}