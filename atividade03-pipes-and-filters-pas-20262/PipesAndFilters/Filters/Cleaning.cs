using System.Globalization;
using PipesAndFilters.Core;
using PipesAndFilters.Models;

namespace PipesAndFilters.Filters;

public class Cleaning : IFilter<IEnumerable<VendaBruta>, IEnumerable<Venda>>
{
    public IEnumerable<Venda> Executar(IEnumerable<VendaBruta> vendas)
    {
        foreach (var linha in vendas)
        {
            if (string.IsNullOrWhiteSpace(linha.Produto))
            {
                Console.WriteLine("Produto com nome vazio" + linha.IdVenda);
                continue;   
            }

            if (!int.TryParse(linha.Quantidade, out var quantidade) || quantidade <= 0)
                continue;

            if (!decimal.TryParse(linha.PrecoUnitario, NumberStyles.Any,
                                  CultureInfo.InvariantCulture, out var preco) || preco <= 0)
                continue;

            yield return new Venda
            {
                Id = linha.IdVenda,
                Produto = linha.Produto,
                Quantidade = quantidade,
                Preco = preco
            };
        }
    }
}
