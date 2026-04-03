using Microsoft.EntityFrameworkCore;
using dotnet_api_docker_sample.Data;

var builder = WebApplication.CreateBuilder(args);

// 1. Configuração de Serviços
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configura o SQLite
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=app.db"));

var app = builder.Build();

// 2. Configuração do Pipeline (Middleware)

// Habilitamos o Swagger para todos os ambientes (essencial para portfólio)
app.UseSwagger();
app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    // Faz o Swagger ser a página inicial (abre direto no root da URL)
    options.RoutePrefix = string.Empty; 
});

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

// 3. Garantir que o banco de dados seja criado ao iniciar
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    // Isso cria o arquivo .db e as tabelas se elas não existirem
    dbContext.Database.EnsureCreated();
}

app.Run();
