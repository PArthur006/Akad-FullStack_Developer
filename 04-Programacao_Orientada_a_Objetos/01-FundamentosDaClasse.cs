using System;
using System.Globalization;

// Demonstração dos blocos de construção de uma classe em C#.
public class ContaBancaria
{
    // PROPRIEDADES
    // Auto-Property simples. O compilador cria um campo privado (backing field) automaticamente.
    public string Titular { get; set; }

    // Propriedade com lógica customizada de validação no SET.
    private decimal _saldo; // Backing field explícito e privado.
    public decimal Saldo
    {
        get { return _saldo; }
        private set // O 'private set' torna a propriedade somente leitura para o mundo exterior.
        {
            if (value < 0)
            {
                throw new ArgumentException("O saldo não pode ser negativo.");
            }
            _saldo = value;
        }
    }

    // Propriedade somente leitura (get-only) que calcula um valor.
    public string SaldoFormatado => Saldo.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"));

    // CONSTRUTORES
    // Construtor padrão que inicializa o objeto com valores básicos.
    public ContaBancaria(string titular)
    {
        Titular = titular;
        Saldo = 0; // O 'set' privado pode ser usado dentro da própria classe.
    }

    // Construtor sobrecarregado que permite iniciar com um saldo.
    public ContaBancaria(string titular, decimal saldoInicial)
    {
        Titular = titular;
        Saldo = saldoInicial;
    }

    // MÉTODOS
    // Método 'void' (sem retorno) que modifica o estado do objeto.
    public void Depositar(decimal valor)
    {
        if (valor <= 0)
        {
            throw new ArgumentException("O valor do depósito deve ser positivo.");
        }
        Saldo += valor;
        Console.WriteLine($"Depósito de {valor:C} realizado. Novo saldo: {SaldoFormatado}");
    }

    // Método com retorno 'bool' que também modifica o estado.
    public bool Sacar(decimal valor)
    {
        if (valor <= 0)
        {
            Console.WriteLine("Valor de saque inválido.");
            return false;
        }

        if (Saldo >= valor)
        {
            Saldo -= valor;
            Console.WriteLine($"Saque de {valor:C} realizado. Novo saldo: {SaldoFormatado}");
            return true;
        }
        else
        {
            Console.WriteLine("Saldo insuficiente.");
            return false;
        }
    }
}