using System;
using System.Collections.Generic;

// ABSTRAÇÃO: Animal é um conceito abstrato. Não existe um "animal" genérico no mundo real,
// mas sim cães, gatos, etc. A classe não pode ser instanciada.
public abstract class Animal
{
    // ENCAPSULAMENTO: A propriedade Nome é pública, mas a forma como é armazenada
    // poderia ser privada, protegendo o estado interno.
    public string Nome { get; protected set; } // 'protected set' permite que classes filhas alterem o nome.

    // Construtor da classe base.
    public Animal(string nome)
    {
        Nome = nome;
    }

    // Método abstrato. Define um "contrato" que TODA classe filha DEVE implementar.
    public abstract string EmitirSom();
}

// HERANÇA: Cachorro "é um" Animal. Ele herda a propriedade Nome e o construtor.
public class Cachorro : Animal
{
    // Construtor da classe filha que chama o construtor da classe pai (base).
    public Cachorro(string nome) : base(nome) { }

    // POLIMORFISMO (em tempo de execução): Sobrescrevendo o método abstrato da classe pai.
    // O mesmo método 'EmitirSom' tem formas diferentes para cada animal.
    public override string EmitirSom()
    {
        return "Au au!";
    }
}

public class Gato : Animal
{
    public Gato(string nome) : base(nome) { }

    public override string EmitirSom()
    {
        return "Miau!";
    }
}

public class DemonstracaoPOO
{
    public void Executar()
    {
        // Polimorfismo na prática: uma lista da classe base 'Animal'
        // pode conter objetos de qualquer classe filha ('Cachorro', 'Gato').
        List<Animal> animais = new List<Animal>();
        animais.Add(new Cachorro("Rex"));
        animais.Add(new Gato("Frajola"));

        foreach (var animal in animais)
        {
            // A chamada é a mesma (animal.EmitirSom()), mas o resultado
            // é diferente dependendo do tipo real do objeto.
            Console.WriteLine($"O {animal.Nome} faz: {animal.EmitirSom()}");
        }
    }

    // POLIMORFISMO (em tempo de compilação): Sobrecarga de método.
    // O mesmo nome de método, mas com assinaturas (parâmetros) diferentes.
    public void Identificar(Cachorro c)
    {
        Console.WriteLine("Este animal é um cachorro.");
    }

    public void Identificar(Gato g)
    {
        Console.WriteLine("Este animal é um gato.");
    }
}