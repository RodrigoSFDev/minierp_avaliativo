using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastro
{
    public class Nota
    {
        public int NotaId { get; set; }
        public int ClienteId { get; set; }
        public Cliente? Cliente { get; set; }
        public DateTime Data { get; set; }
        public decimal ValorTotal { get; set; }

        // Relacionamento N:N com Produto
        public ICollection<Produto>? Produtos { get; set; }
    }
}