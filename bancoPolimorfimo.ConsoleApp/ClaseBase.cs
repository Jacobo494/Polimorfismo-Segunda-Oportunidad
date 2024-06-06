namespace bancoPolimorfimo.ConsoleApp
{
    public abstract class ClaseBase : CuentaDeBanco
    {
        private decimal saldo;

        public decimal Saldo
        {
            get { return saldo; }
            protected set { saldo = value; }
        }

        public void Depositar(decimal cantidad)
        {
            if (cantidad > 0)
                Saldo += cantidad;
        }

        public abstract void Retirar(decimal cantidad);
    }
}
