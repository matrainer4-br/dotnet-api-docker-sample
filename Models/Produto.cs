namespace dotnet_api_docker_sample.Models;

public class Produto
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public decimal Preco { get; set; }
    public DateTime DataCriacao { get; set; } = DateTime.Now;
}