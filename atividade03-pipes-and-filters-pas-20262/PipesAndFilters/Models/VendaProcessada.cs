namespace PipesAndFilters.Models;

public record VendaProcessada
{
    public required Venda Venda { get; init; }
    public decimal ValorTotal { get; init; }
}