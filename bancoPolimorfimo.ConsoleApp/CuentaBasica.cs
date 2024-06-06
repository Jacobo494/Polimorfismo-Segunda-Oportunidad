namespace bancoPolimorfimo.ConsoleApp
{
    public class CuentaBasica : ClaseBase
    {
        public CuentaBasica(decimal saldoM)
        {
            this.Saldo = saldoM;
        }
        public new void Depositar(decimal cantidad)
        {
            if (cantidad > 0)
                Saldo += cantidad;
        }

        public override void Retirar(decimal cantidad)
        {
            if (cantidad <= Saldo)
                this.Saldo -= cantidad;
        }
    }
}
