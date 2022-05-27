using System.ComponentModel.DataAnnotations;

namespace IndustriaWebApi.Models.Dtos
{
    public class ProdutoDto
    {
        [Key]
        [Required]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo 'Nome' é obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo 'Valor' é obrigatório.")]
        public double Valor { get; set; }
    }
}
