using PipesAndFilters.Filters;
using PipesAndFilters.Core;
using PipesAndFilters.Models;

IFilter<string, IEnumerable<VendaBruta>> leitor = new Reading();
IFilter<IEnumerable<VendaBruta>, IEnumerable<Venda>> limpador = new Cleaning();
IFilter<IEnumerable<Venda>, IEnumerable<VendaProcessada>> transform = new Transforming();
IFilter<IEnumerable<VendaProcessada>, ResumoVendas> summer = new Summing();
IFilter<ResumoVendas, string> report = new Reporting();

const string arquivoDezLinhas = "vendas_exemplo_10_linhas.csv";
const string arquivoMilLinhas = "vendas_exemplo_1000_linhas_com_invalidas.csv";

var brutas = leitor.Executar(Path.Combine(AppContext.BaseDirectory, arquivoMilLinhas));
var limpas = limpador.Executar(brutas);
var transformadas = transform.Executar(limpas);
var somadas = summer.Executar(transformadas);
var reportadas = report.Executar(somadas);

Console.WriteLine(reportadas);