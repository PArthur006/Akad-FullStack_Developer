using System;

// INTERFACE: Define um "contrato". Qualquer classe que implementar 'ILigavel'
// DEVE obrigatoriamente ter os métodos Ligar() e Desligar().
public interface ILigavel
{
    void Ligar();
    void Desligar();
}

// Uma classe pode herdar de UMA classe base, mas implementar MÚLTIPLAS interfaces.
public class Smartphone : ILigavel
{
    public string Modelo { get; set; }

    public void Ligar()
    {
        Console.WriteLine("Smartphone ligado.");
    }

    public void Desligar()
    {
        Console.WriteLine("Smartphone desligado.");
    }
}

// CLASSE SELADA (SEALED): Impede que outras classes herdem dela.
// É um ponto final na hierarquia de herança. Útil por segurança e otimização.
public sealed class CalculadoraCientifica
{
    public double Somar(double a, double b) => a + b;
}

// A linha abaixo causaria um erro de compilação:
// public class MinhaCalculadora : CalculadoraCientifica { }