using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Banco
{
    struct Conta
    {
        // Declarar variáveis
        private int _numero;
        public string _nome;
        private double? _saldo;
        public Conta(int numero, string nome, double? saldo) // Contrutor
        {
            _numero = numero;
            _nome = nome;
            _saldo = saldo;
        }
        public void Deposito(double quantidade) // Realizar deposito
        {
            double valor = _saldo ?? 0;
            _saldo = valor + quantidade;
        }
        public void Saque(double quantidade) // Realizar saque
        {
            double valor = _saldo ?? 0;
            _saldo = valor - quantidade - 5;
        }

        // Retornar o ToString dos dados
        public override string ToString()
        {
            return "Dados da Conta: Conta " + _numero
                + ", Titular: " + _nome
                + ", Saldo R$ " + _saldo.GetValueOrDefault().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
