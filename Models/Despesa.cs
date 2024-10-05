using System.ComponentModel.DataAnnotations;

namespace FinControl.Models
{
    public class Despesa
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required(ErrorMessage = "Descrição é obrigatória.")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Valor é obrigatório.")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "Data de Emissão é obrigatória.")]
        public DateTime DataEmissao { get; set; }

        [Required(ErrorMessage = "Data de Vencimento é obrigatória.")]
        public DateTime DataVencimento { get; set; }
        public Categoria? Categoria { get; set; }

        [Required(ErrorMessage = "Categoria é obrigatória.")]
        public Guid CategoriaId { get; set; }

        public Despesa(string descricao, decimal valor, DateTime dataEmissao, DateTime dataVencimento, Guid categoriaId)
        {
            Descricao = descricao;
            Valor = valor;
            DataEmissao = dataEmissao;
            DataVencimento = dataVencimento;
            CategoriaId = categoriaId;
        }
    }

}
