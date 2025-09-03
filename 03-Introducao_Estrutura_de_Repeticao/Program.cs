using System;

namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayInteiros = new int[3];

            arrayInteiros[0] = 72;
            arrayInteiros[1] = 64;
            arrayInteiros[2] = 50;

            for (int contador = 0; contador < arrayInteiros.Length; contador++)
            {
                Console.WriteLine($"Posição Nº{contador} - {arrayInteiros[contador]}");
            }
            
            foreach (int valor in arrayInteiros)
            {
                Console.WriteLine(valor);
            }
        }

        
    }
}
