using System;

namespace sistema_bancario.models
{
    public class ContaCorrente : Conta
    {
        private readonly decimal limite = 200;

        public ContaCorrente(string? titular, decimal saldo) : base(titular, saldo)
        {
        }

        public override void Sacar(decimal valor)
        {
            if (valor <= 0)
                throw new ArgumentException("Valor de saque deve ser maior que zero.");

            if (valor > Saldo + limite)
                throw new ArgumentException("Saldo insuficiente.");

            Saldo -= valor;
        }
    }
}