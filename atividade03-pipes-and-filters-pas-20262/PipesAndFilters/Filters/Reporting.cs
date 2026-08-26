using System.Globalization;
using PipesAndFilters.Core;
using PipesAndFilters.Models;

namespace PipesAndFilters.Filters;

public class Reporting : IFilter<ResumoVendas, string>
{
    public string Executar(ResumoVendas resumoVendas)
    {
        string report = "Vendas válidas: " + resumoVendas.VendasValidas + "\n Produtos vendidos: " + resumoVendas.TotalProdutos + "\n Valor total: " + resumoVendas.ValorTotal.ToString("C2", new CultureInfo("pt-BR"));
        return report;
    }
}