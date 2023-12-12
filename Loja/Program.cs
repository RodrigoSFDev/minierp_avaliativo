using Cadastro;

    while (true)
    {
        Console.WriteLine("\n1. Cadastro de produtos");
        Console.WriteLine("2. Atualizar produto");
        Console.WriteLine("3. Deletar produto");
        Console.WriteLine("4. Cadastro de Fornecedores");
        Console.WriteLine("5. Cadastro de clientes");
        Console.WriteLine("6. Lançamento de nota");
        Console.WriteLine("7. Sair\n");

        Console.Write("Escolha uma opção: ");
        string opcao = Console.ReadLine()!;

        switch (opcao)
        {
            case "1":
                CadastroProdutos();
                break;
            case "2":
                AtualizarProduto();
                break;
            case "3":
                DeletarProduto();
                break;
            case "4":
                CadastroFornecedores();
                break;
            case "5":
                CadastroClientes();
                break;
            case "6":
                LancamentoNota();
                break;
            case "7":
                return;
            default:
                Console.WriteLine("Opção inválida. Tente novamente.");
                break;
        }
    }

    static void AtualizarProduto()
    {
    Console.WriteLine("Atualizar produto");

    Console.Write("Digite o ID do produto: ");
    int id = int.Parse(Console.ReadLine()!);

    var produto = new Produto { ProdutoId = id };

    using (var context = new Contexto())
    {
        var produtoExistente = context.Produtos.Find(id);
        if (produtoExistente != null)
        {
            produtoExistente.Nome = produto.Nome;
            produtoExistente.Preco = produto.Preco;
            produtoExistente.FornecedorId = produto.FornecedorId;

            context.Produtos.Update(produtoExistente);
            context.SaveChanges();

            Console.WriteLine("Produto atualizado com sucesso!");
        }
        else
        {
            Console.WriteLine("Produto não encontrado.");
        }
    }
    }

    static void DeletarProduto()
    {
    Console.WriteLine("Deletar produto");

    Console.Write("Digite o ID do produto: ");
    int id = int.Parse(Console.ReadLine()!);

    using (var context = new Contexto())
    {
        var produto = context.Produtos.Find(id);
        if (produto != null)
        {
            context.Produtos.Remove(produto);
            context.SaveChanges();

            Console.WriteLine("Produto deletado com sucesso!");
        }
        else
        {
            Console.WriteLine("Produto não encontrado.");
        }
    }
    }
static void CadastroProdutos()
{
    Console.WriteLine("Cadastro de produtos");

    Console.Write("Digite o nome do produto: ");
    string nome = Console.ReadLine()!;
    Console.Write("Digite o preço do produto: ");
    decimal preco = decimal.Parse(Console.ReadLine()!);
    Console.Write("Digite o ID do fornecedor: ");
    int fornecedorId = int.Parse(Console.ReadLine()!);

    var produto = new Produto { Nome = nome, Preco = preco, FornecedorId = fornecedorId };

    using (var context = new Contexto())
    {
        context.Produtos.Add(produto);
        context.SaveChanges();
    }

    Console.WriteLine("Produto cadastrado com sucesso!");
}

static void CadastroFornecedores()
{
    Console.WriteLine("Cadastro de Fornecedores");

    Console.Write("Digite o nome do fornecedor: ");
    string nome = Console.ReadLine()!;

    var fornecedor = new Fornecedor { Nome = nome };

    using (var context = new Contexto())
    {
        context.Fornecedores.Add(fornecedor);
        context.SaveChanges();
    }

    Console.WriteLine("Fornecedor cadastrado com sucesso!");
}

static void CadastroClientes()
{
    Console.WriteLine("Cadastro de clientes");

    Console.Write("Digite o nome do cliente: ");
    string nome = Console.ReadLine()!;
    Console.Write("Digite o email do cliente: ");
    string email = Console.ReadLine()!;

    var cliente = new Cliente { Nome = nome, Contato = email };

    using (var context = new Contexto())
    {
        context.Clientes.Add(cliente);
        context.SaveChanges();
    }

    Console.WriteLine("Cliente cadastrado com sucesso!");
    }

    static void LancamentoNota()
    {
    Console.WriteLine("Lançamento de nota");

    Console.Write("Digite o ID do cliente: ");
    int clienteId = int.Parse(Console.ReadLine()!);

    var nota = new Nota { ClienteId = clienteId };

    using (var context = new Contexto())
    {
        context.Notas.Add(nota);
        context.SaveChanges();
    }

    Console.WriteLine("Nota lançada com sucesso!");
    }

