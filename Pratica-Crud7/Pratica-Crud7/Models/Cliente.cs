using System.Drawing;

namespace Pratica_Crud7.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public bool Ativo { get; set; }

        public string hora = DateTime.Now.ToString();
        public string data = DateTime.Now.ToShortDateString();


    }
}
