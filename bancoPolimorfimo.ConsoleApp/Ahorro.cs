namespace bancoPolimorfismo.ConsoleApp
{
    public class Ahorro : ClaseBase
    {
        private const decimal SaldoMinimo = 3000;

        public Ahorro(decimal saldoI)
        {
            if (saldoI >= SaldoMinimo)
                this.Saldo = saldoI;
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
