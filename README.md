# dotnet-api-docker-sample

Uma Web API simples em .NET 8 usando SQLite com Entity Framework Core, containerizada com Docker e documentada com Swagger.

## Estrutura do Projeto

- `Models/Produto.cs`: Modelo da entidade Produto.
- `Data/AppDbContext.cs`: Contexto do banco de dados.
- `Controllers/ProdutosController.cs`: Controller com endpoints CRUD para Produtos.
- `Program.cs`: Configuração da aplicação, incluindo DB e Swagger.
- `Dockerfile`: Dockerfile multi-stage para build e execução.

## Como Executar

1. Construa a imagem Docker:
   ```
   docker build -t dotnet-api-sample .
   ```

2. Execute o container, mapeando a porta 5000 para 8080:
   ```
   docker run -p 5000:8080 -v $(pwd)/data:/app dotnet-api-sample
   ```
   Nota: Monte um volume para persistir o banco de dados SQLite.

3. Acesse o Swagger em `http://localhost:5000/swagger`.

## Endpoints

- `GET /api/produtos`: Lista todos os produtos.
- `GET /api/produtos/{id}`: Obtém um produto por ID.
- `POST /api/produtos`: Cria um novo produto.
- `PUT /api/produtos/{id}`: Atualiza um produto.
- `DELETE /api/produtos/{id}`: Deleta um produto.

## Dependências

- .NET 8
- Entity Framework Core com SQLite
- Swashbuckle para Swagger