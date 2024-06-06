namespace bancoPolimorfismo.ConsoleApp
{
    public class Cheques : ClaseBase
    {
        private const decimal SaldoMinimo = 5000;
        private const decimal InteresAnual = 0.02m;
        private const int MaximoDeCheques = 5;
        private const decimal CargoPorCheque = 10;
        private const decimal CargoPorChequeRebotado = 200;

        private int chequesEmitidos;

        public Cheques(decimal saldoI)
        {
            if (saldoI >= SaldoMinimo)
                this.Saldo = saldoI;
        }

        public override void Retirar(decimal cantidad)
        {
            if (cantidad <= Saldo)
                this.Saldo -= cantidad;
        }

        public void EmitirCheque(decimal cantidad)
        {
            if (chequesEmitidos < MaximoDeCheques)
            {
                chequesEmitidos++;
                Retirar(cantidad);
            }
            else
            {
                Saldo -= cantidad + CargoPorChequeRebotado;
            }
        }

        public decimal CalcularInteresMensual()
        {
            return Saldo * InteresAnual / 12;
        }
    }
}
