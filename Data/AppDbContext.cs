using Microsoft.EntityFrameworkCore;
using dotnet_api_docker_sample.Models;

namespace dotnet_api_docker_sample.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Produto> Produtos { get; set; }
}