using System.ComponentModel.DataAnnotations;

namespace FinControl.Models
{
    public class Categoria
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required(ErrorMessage = "Nome é obrigatório.")]
        public string Nome { get; set; }

        public Categoria(string nome)
        {
            Nome = nome;
        }
    }
}
