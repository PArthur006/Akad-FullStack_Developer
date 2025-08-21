using System;
using System.Collections.Generic;
using System.Linq;

// 1. Definição da classe para representar um sinistro
public class Sinistro
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public decimal Valor { get; set; }
}

public class DesafioGerenciadorDeSinistros
{
    public static void Main()
    {
        // Lê a linha de entrada com os dados dos sinistros
        string entrada = Console.ReadLine();

        // Lista para armazenar os objetos Sinistro processados
        List<Sinistro> sinistros = new List<Sinistro>();

        // 2. Processa a entrada
        string[] sinistrosStr = entrada.Split(',');

        foreach (var str in sinistrosStr)
        {
            // Para cada sinistro, divide por ponto e vírgula para obter os detalhes
            string[] detalhes = str.Split(';');

            // Cria um novo objeto Sinistro e preenche suas propriedades
            Sinistro sinistro = new Sinistro
            {
                Id = int.Parse(detalhes[0]),
                Nome = detalhes[1],
                Valor = decimal.Parse(detalhes[2])
            };

            // Adiciona o objeto à lista
            sinistros.Add(sinistro);
        }

        // 3. Ordena a lista de sinistros pelo ID em ordem crescente
        var sinistrosOrdenados = sinistros.OrderBy(s => s.Id).ToList();

        // 4. Formata a saída
        var sinistrosFormatados = sinistrosOrdenados.Select(s => $"{s.Id}:{s.Nome}:{s.Valor}");

        // Junta todas as strings formatadas com uma vírgula
        string resultado = string.Join(",", sinistrosFormatados);

        // Imprime o resultado final
        Console.WriteLine(resultado);
    }
}