using System.ComponentModel;

namespace Pratica_Crud7.Models
{
    public class Produtos
    {
        public string Nome { get; set; }

        public decimal Valor { get; set; }

        public bool Active { get; set; }

        public bool IdCategory { get; set; }

        public virtual Category Category { get; set; }
    }
}
