using System.Globalization;
using PipesAndFilters.Core;
using PipesAndFilters.Models;

namespace PipesAndFilters.Filters;

public class Reporting : IFilter<ResumoVendas, string>
{
    public string Executar(ResumoVendas resumoVendas)
    {
        string headline = "========================================\n RELATÓRIO DE VENDAS\n========================================";
        string report = "\n Vendas válidas: " + resumoVendas.VendasValidas + "\n Produtos vendidos: " + resumoVendas.TotalProdutos + "\n Valor total: " + resumoVendas.ValorTotal.ToString("C2", new CultureInfo("pt-BR"));
        string endline = "\n========================================";
        return headline + report + endline;
    }
}