 # Projeto de Cadastro

Este projeto é um sistema de cadastro de produtos, fornecedores, clientes e notas. Ele é construído usando C# e Entity Framework Core para acessar o banco de dados.

## Pré-requisitos

Antes de começar, certifique-se de ter o seguinte instalado em sua máquina:

- .NET 6.0 SDK
- Docker
- Docker Compose

## Como iniciar o banco de dados

O banco de dados está definido no arquivo `docker-compose.yml`. Para iniciar o banco de dados, siga as etapas abaixo:

1. Navegue até o diretório do projeto no terminal.
2. Execute o seguinte comando para construir e iniciar o banco de dados:
```
docker-compose up --build
```

Este comando irá construir a imagem do banco de dados (se necessário) e iniciar o banco de dados. O banco de dados estará acessível no endereço `localhost` na porta especificada no arquivo `docker-compose.yml`.

## Como executar o projeto

Depois de iniciar o banco de dados, você pode executar o projeto usando o seguinte comando:
```
dotnet run
```

Este comando irá compilar e executar o projeto. O projeto estará acessível no endereço `localhost` na porta especificada no arquivo `launchSettings.json`.

## Estrutura do projeto

O projeto é estruturado da seguinte maneira:

- `Fornecedor`: Classe que representa um fornecedor.
- `Cliente`: Classe que representa um cliente.
- `Nota`: Classe que representa uma nota.
- `Produto`: Classe que representa um produto.
- `Contexto`: Classe que representa o contexto do banco de dados.

Cada classe tem propriedades que correspondem às colunas da tabela correspondente no banco de dados.


## Licença

Este projeto está licenciado sob a licença MIT. Consulte o arquivo `LICENSE` para mais detalhes.

