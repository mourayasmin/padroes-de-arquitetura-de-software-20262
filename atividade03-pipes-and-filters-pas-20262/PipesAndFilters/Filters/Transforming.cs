using PipesAndFilters.Core;
using PipesAndFilters.Models;

namespace PipesAndFilters.Filters;

public class Transforming : IFilter<IEnumerable<Venda>, IEnumerable<VendaProcessada>>
{
    public IEnumerable<VendaProcessada> Executar(IEnumerable<Venda> vendasValidas)
    {
        return vendasValidas
            .Select(linha => new VendaProcessada
            {
                Venda = linha,
                ValorTotal = linha.Quantidade * linha.Preco,
            });
    }
}