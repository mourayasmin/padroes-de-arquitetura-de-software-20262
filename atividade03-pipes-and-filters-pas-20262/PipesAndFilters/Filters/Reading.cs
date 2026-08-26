using PipesAndFilters.Core;
using PipesAndFilters.Models;

namespace PipesAndFilters.Filters;

public class Reading : IFilter<string, IEnumerable<VendaBruta>>
{
    public IEnumerable<VendaBruta> Executar(string arquivo)
    {
        var linhas = File.ReadLines(arquivo).Skip(1);
        
        foreach (var linha in linhas)
        {
            var partes = linha.Split(',');
            if (partes.Length != 4) continue;
            yield return new VendaBruta { IdVenda = partes[0], Produto = partes[1], Quantidade = partes[2], PrecoUnitario = partes[3] };
        }
    }
}