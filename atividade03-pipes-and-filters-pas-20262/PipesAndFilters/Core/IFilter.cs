using PipesAndFilters.Models;

namespace PipesAndFilters.Core;

public interface IFilter<TEntrada, TSaida>                                                                                                                                                                                                   
{                                                                                                                                                                                                                                            
    TSaida Executar(TEntrada entrada);                                                                                                                                                                                                       
}   