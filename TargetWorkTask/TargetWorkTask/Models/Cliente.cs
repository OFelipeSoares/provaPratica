using TargetWorkTask.Models;

namespace TargetWorkTask.Models
{
    public class Cliente : BaseId
    {
        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public string Email { get; set; }

        public bool Ativo { get; set; }
    }
}
