namespace atividade02_pas_20261.Domain;

public class Conta
{
    public int Id { get; set; }
    public string Numero { get; set; } = string.Empty;
    public decimal Saldo { get; set; }
    
    public int ClienteId { get; set; }
    public Cliente? Cliente { get; set; }

    public int AgenciaId { get; set; }
    public Agencia? Agencia { get; set; }
    
    public void Depositar(decimal valor)
    {
        if (valor <= 0) throw new ArgumentException("Valor de depósito deve ser positivo.");
        Saldo += valor;
    }

    public void Sacar(decimal valor)
    {
        if (valor <= 0) throw new ArgumentException("Valor de saque deve ser positivo.");
        if (valor > Saldo) throw new InvalidOperationException("Saldo insuficiente.");
        Saldo -= valor;
    }
}