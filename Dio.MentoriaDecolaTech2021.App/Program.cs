using Dio.MentoriaDecolaTech2021.Dominio.Classes;
using System;

namespace Dio.MentoriaDecolaTech2021.App
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Criação da conta
                Endereco endereco = new Endereco("Rua do Joaquim", "44140301", "belo horizonte", "mg");
                Cliente cliente = new Cliente("Joaquim", "17933958703", "1321654987", endereco);
                ContaCorrente conta = new ContaCorrente(cliente, 100);

                Console.WriteLine("Conta " + conta.Situacao + ": " + conta.NumeroConta + "-" +
                    conta.DigitoVerificador);

                // Abertura de conta
                string senha = "abc123456789";
                conta.Abrir(senha);

                Console.WriteLine("Conta " + conta.Situacao + ": " + conta.NumeroConta + "-" +
                    conta.DigitoVerificador);

                // Utilização da conta
                conta.Sacar(10, senha);
                Console.WriteLine(conta.VerSaldo());

                conta.Depositar(50);
                Console.WriteLine(conta.VerSaldo());

                conta.Sacar(20, senha);
                Console.WriteLine(conta.VerSaldo());

                conta.Depositar(10);
                Console.WriteLine(conta.VerExtrato());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
