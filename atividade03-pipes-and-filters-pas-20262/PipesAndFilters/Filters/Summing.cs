using PipesAndFilters.Core;
using PipesAndFilters.Models;

namespace PipesAndFilters.Filters;

public class Summing : IFilter<IEnumerable<VendaProcessada>, ResumoVendas>
{
    public ResumoVendas Executar(IEnumerable<VendaProcessada> vendasValidas)
    {
      var totalProdutos = 0;                                                                                                                                    
      var valorTotal = 0m;                                                                                                                                      
      var vendasContadas = 0;                                                                                                                                   
                                                                                                                                                                
      foreach (var venda in vendasValidas)                                                                                                                      
      {                                                                                                                                                         
          totalProdutos += venda.Venda.Quantidade;                                                                                                              
          valorTotal    += venda.ValorTotal;                                                                                                                    
          vendasContadas++;                                                                                                                                     
      }                                                                                                                                                         
                                                                                                                                                                
      return new ResumoVendas                                                                                                                                   
      {                                                                                                                                                         
          TotalProdutos = totalProdutos,                                                                                                                        
          ValorTotal    = valorTotal,                                                                                                                           
          VendasValidas = vendasContadas                                                                                                                        
      }; 
    }
}