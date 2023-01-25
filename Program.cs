using SistemaBancario.SistemaBancarioTeste;
using System;

namespace SistemaBancario
{
    public class Program
    {
        public static void Main(String[] args)
        {
            var conta = new Conta();
            conta.NomeConta = "ContaTeste";
            conta.NumeroConta = 1000;
            conta.Agencia = 001;
            conta.Saldo = 1000;

            conta.Titular = new Titular()
            {
                Cpf = "05689525625",
                Rg = "8954566",
                Endereco = "Rua Centro",
                Nome = "Ramon"
            };

            Console.WriteLine($"O saldo atual é de { conta.verSaldo()}");

            conta.Depositar(150);

            Console.WriteLine($"O saldo atual, após o deposito é de {conta.verSaldo()}");

            conta.Sacar(900);

            Console.WriteLine($"O saldo atual, após o saque é de {conta.verSaldo()}");

            conta.Sacar(2000);

            Console.ReadKey();
        }
    }
}