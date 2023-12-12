using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace Cadastro
{
    [Table("cadastro")]
    public class Fornecedor
    {
            public int FornecedorId { get; set; }
            public string? Nome { get; set; }
            public string? Endereco { get; set; }
            public string? Contato { get; set; }

            // Lista de Produtos fornecidos pelo Fornecedor
            public ICollection<Produto>? Produtos { get; set; }
    }
}