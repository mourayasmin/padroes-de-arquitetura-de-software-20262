namespace atividade02_pas_20261.Domain;

public class Agencia
{
    public int Id { get; set; }
    public string Numero { get; set; } = string.Empty;
    public List<Conta> Contas { get; set; } = new();
}