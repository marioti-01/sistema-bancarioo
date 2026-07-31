using System;

namespace sistema_bancario.models
{
    public class ContaPoupanca : Conta
    {
        public ContaPoupanca(string? titular, decimal saldo) : base(titular, saldo)
        {
        }

        public override void Sacar(decimal valor)
        {
            if (valor <= 0)
                throw new ArgumentException("Valor de saque deve ser maior que zero.");

            if (valor > Saldo)
                throw new ArgumentException("Saldo insuficiente.");

            Saldo -= valor;
        }
    }
}