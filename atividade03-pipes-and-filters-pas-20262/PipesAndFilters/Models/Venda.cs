namespace PipesAndFilters.Models;

public record Venda
{
    public required string Id { get; init; }
    public required string Produto { get; init; }
    public int Quantidade { get; init; }
    public decimal Preco { get; init; }
}