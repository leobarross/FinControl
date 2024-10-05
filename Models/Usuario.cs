using System.ComponentModel.DataAnnotations;

namespace FinControl.Models
{
    public class Usuario
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required(ErrorMessage = "Nome é obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Email é obrigatório.")]
        [EmailAddress(ErrorMessage = "Email inválido.")]
        public string Email { get; set; }
        [Required]
        public string Senha { get; set; }

        public Usuario (string nome, string email, string senha)
        {
            Nome = nome;
            Email = email;
            Senha = senha;

        }
    }
}
