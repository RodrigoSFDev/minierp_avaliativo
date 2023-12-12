using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastro
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public decimal Preco { get; set; }

        // Relacionamento com Fornecedor
        public int FornecedorId { get; set; }
        public Fornecedor? Fornecedor { get; set; }
    }
} 