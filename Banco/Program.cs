using System;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            // Informações da conta
            Console.Write("Entre com o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (S/N): ");
            string boolDeposito = Console.ReadLine();

            // Deposito inicial
            double? deposito = null;
            if (boolDeposito == "S")
            {
                Console.Write("Entre o valor de depósito: ");
                deposito = double.Parse(Console.ReadLine());
            }

            // Instanciar struct
            Conta n = new Conta(numero, titular, deposito);
            Console.WriteLine("\n" + n + "\n");

            // Realizar depósito
            Console.Write("Entre com um valor para depósito: ");
            n.Deposito(double.Parse(Console.ReadLine()));
            Console.WriteLine(n + "\n");

            // Realizar saque
            Console.Write("Entre com um valor para saque: ");
            n.Saque(double.Parse(Console.ReadLine()));
            Console.WriteLine(n);

            Console.ReadKey();
        }
    }
}
