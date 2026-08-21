using atividade02_pas_20261.Domain;

namespace atividade02_pas_20261.Service;

public class ContaService
{
    private readonly IContaRepository _repo;
    public ContaService(IContaRepository repo) => _repo = repo;

    public async Task DepositarAsync(int contaId, decimal valor)
    {
        var conta = await _repo.ObterPorIdAsync(contaId)
                    ?? throw new InvalidOperationException("Conta não encontrada.");
        conta.Depositar(valor);
        await _repo.SalvarAsync();
    }
}