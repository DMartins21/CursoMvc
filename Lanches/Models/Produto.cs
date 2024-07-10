using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lanches.Models
{
    [Table("Produtos")]
    public class Produto
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Descricao { get; set; }
        public int Quantidade { get; set; }

    }
}
