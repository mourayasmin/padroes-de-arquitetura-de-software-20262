namespace atividade02_pas_20261.Domain;

public class Cliente
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Cpf { get; set; } = string.Empty;
    public TipoConta TipoConta { get; set; }
    public DateTime DataNascimento { get; set; }
    public string Telefone { get; set; } = string.Empty;
    public List<Conta> Contas { get; set; } = new();
}