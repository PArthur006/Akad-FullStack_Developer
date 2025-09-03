using System;
using System.Collections.Generic;

public class DemonstracaoExcecoesEColecoes
{
    public void TestarExcecoes()
    {
        try
        {
            Console.WriteLine("Tentando dividir por zero...");
            int x = 10;
            int y = 0;
            int resultado = x / y; // Isto vai lançar uma exceção.
        }
        catch (DivideByZeroException ex)
        {
            // Bloco que captura a exceção específica.
            Console.WriteLine("Erro capturado: Não é possível dividir por zero.");
            Console.WriteLine($"Detalhes: {ex.Message}");
        }
        finally
        {
            // Este bloco SEMPRE é executado, com ou sem exceção.
            // Ideal para limpar recursos (ex: fechar arquivos).
            Console.WriteLine("Bloco finally executado.");
        }
    }

    public void TestarColecoes()
    {
        // Dictionary (Dicionário): Chave-Valor, chaves únicas.
        Dictionary<string, string> capitais = new Dictionary<string, string>();
        capitais.Add("Brasil", "Brasília");
        capitais.Add("Argentina", "Buenos Aires");
        Console.WriteLine($"A capital do Brasil é: {capitais["Brasil"]}");

        // Queue (Fila): FIFO (First-In, First-Out)
        Queue<string> filaAtendimento = new Queue<string>();
        filaAtendimento.Enqueue("Cliente A"); // Adiciona ao final
        filaAtendimento.Enqueue("Cliente B");
        Console.WriteLine($"Próximo a ser atendido: {filaAtendimento.Dequeue()}"); // Remove do início

        // Stack (Pilha): LIFO (Last-In, First-Out)
        Stack<string> pilhaDeLivros = new Stack<string>();
        pilhaDeLivros.Push("Livro 1"); // Adiciona ao topo
        pilhaDeLivros.Push("Livro 2");
        Console.WriteLine($"Livro no topo da pilha: {pilhaDeLivros.Pop()}"); // Remove do topo
    }
}