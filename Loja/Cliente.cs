using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastro
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string? Nome { get; set; }
        public string? Endereco { get; set; }
        public string? Contato { get; set; }

        // Lista de Notas associadas ao Cliente
        public ICollection<Nota>? Notas { get; set; }
    }
}