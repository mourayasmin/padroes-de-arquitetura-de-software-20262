namespace PipesAndFilters.Models;

public record VendaBruta
{
    public required string IdVenda { get; init; }
    public required string Produto { get; init; }
    public required string Quantidade { get; init; }
    public required string PrecoUnitario { get; init; }
}
