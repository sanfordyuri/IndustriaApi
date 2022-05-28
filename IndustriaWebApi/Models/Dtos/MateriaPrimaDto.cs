using System.ComponentModel.DataAnnotations;

namespace IndustriaWebApi.Models.Dtos
{
    public class MateriaPrimaDto
    {
        public MateriaPrimaDto()
            => Id = Guid.NewGuid();

        [Key]
        [Required]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo 'Nome' é obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo 'Quantidade em estoque' é obrigatório.")]
        public int QuantidadeEmEstoque { get; set; }
    }
}
