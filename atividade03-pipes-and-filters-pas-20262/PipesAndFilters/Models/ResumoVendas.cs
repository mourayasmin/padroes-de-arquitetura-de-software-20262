namespace PipesAndFilters.Models;

public record ResumoVendas
{
    public int VendasValidas { get; init; }
    public int TotalProdutos { get; init; }
    public decimal ValorTotal { get; init; }
}