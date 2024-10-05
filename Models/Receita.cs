using System.ComponentModel.DataAnnotations;

namespace FinControl.Models
{
    public class Receita
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required(ErrorMessage = "Descrição é obrigatória.")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Valor é obrigatório.")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "Usuário é obrigatório.")]
        public Guid UsuarioId { get; set; }

        public Usuario? Usuario { get; set; }

        public Receita(string descricao, decimal valor, Guid usuarioId)
        {
            Descricao = descricao;
            Valor = valor;
            UsuarioId = usuarioId;
        }
    }
}
