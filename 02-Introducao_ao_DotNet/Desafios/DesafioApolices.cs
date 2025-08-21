using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class DesafioApolices
{
    public static void Main(string[] args)
    {
        // 1. Recebe a entrada do usuário
        string input = Console.ReadLine();

        // 2. Divide a string de entrada em uma lista de apólices
        List<string> listaApolices = input.Split(',').ToList();

        // 3. Ordena as apólices com base no nome do cliente
        listaApolices.Sort((a, b) =>
        {
            string nomeA = a.Split(':')[0];
            string nomeB = b.Split(':')[0];

            return nomeA.CompareTo(nomeB);
        });

        // 4. Junta as apólices ordenadas em uma única string, separadas por vírgulas
        string resultado = String.Join(",", listaApolices);

        // 5. Exibe o resultado final
        Console.WriteLine(resultado);
    }
}