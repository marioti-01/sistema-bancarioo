using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sistema_bancario.models;

namespace sistema_bancario.Services
{
    //Camada de serviço
    //O banco não é uma conta, mas ele tem várias contas
    //Aqui vamos estabelecer a lógica que coordena os objetos
    public class Banco
    {
        //A lista é privada
        private readonly List<Conta> _contas = [];

        public void Adicionar(Conta conta)
        {
            _contas.Add(conta);
        }

        //Conta : classe
        //conta : objeto

        public void ProcessarMovimentacoes()
        {
            foreach (Conta c in _contas)
            {
                try
                {
                    c.Depositar(50);
                    c.Sacar(120);
                    Console.WriteLine(c.ToString());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine();
            }
        }
    }
}