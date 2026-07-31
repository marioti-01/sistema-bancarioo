using System;

namespace sistema_bancario.models
{
    public abstract class Conta
    {
        public string? Titular { get; }
        public decimal Saldo { get; protected set; }

        protected Conta(string? titular, decimal saldoInicial)
        {
            Titular = titular;
            Saldo = saldoInicial;
        }

        public void Depositar(decimal valor)
        {
            if (valor <= 0)
                throw new ArgumentException("Valor de depósito deve ser maior que zero.");

            Saldo += valor;
        }

        public abstract void Sacar(decimal valor);
    }
}