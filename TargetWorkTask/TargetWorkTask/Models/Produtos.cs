using System.ComponentModel.DataAnnotations.Schema;
using TargetWorkTask.Models;

namespace TargetWorkTask.Models
{
    [Table("Produtos")]
    public class Produtos : BaseId
    {
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public bool Ativo { get; set; }
        public int IdCategory { get; set; }

        [ForeignKey("Nome")]
        [Column(Order =1)]

        public virtual Category Category { get; set; }

        [NotMapped]
        public List<Produtos> ItemProdutos { get; set; }
    }
}
