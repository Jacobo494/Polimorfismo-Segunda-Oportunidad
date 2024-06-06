namespace bancoPolimorfimo.ConsoleApp
{
    public interface CuentaDeBanco
    {
        decimal Saldo { get; }
        void Depositar(decimal cantidad);
        void Retirar(decimal cantidad);
    }
}
