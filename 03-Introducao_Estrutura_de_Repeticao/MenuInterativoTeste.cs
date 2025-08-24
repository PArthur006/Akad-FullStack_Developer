string opcao;
bool exibirMenu = true;

while (exibirMenu)
{
    Console.WriteLine("Digite a sua opção: ");
    Console.WriteLine("1 - Cadastrar Cliente");
    Console.WriteLine("2 - Buscar Cliente");
    Console.WriteLine("3 - Apagar Cliente");
    Console.WriteLine("4 - Encerrar");

    opcao = Console.ReadLine();

    Console.Clear();
    switch (opcao)
    {
        case "1":
            Console.WriteLine("Cadastro de Cliente");
            break;
        case "2":
            Console.WriteLine("Busca de Cliente");
            break;
        case "3":
            Console.WriteLine("Apagar Cliente");
            break;
        case "4":
            Console.WriteLine("Saindo do Menu...");
            exibirMenu = false;
            break;
        default:
            Console.WriteLine("Opção Inválida!");
            break;

    }
}

/*
int contador = 0;
int numero = 5;
while (contador <= 10)
{
    Console.WriteLine($"{numero} x {contador} = {numero * contador}");

    contador++;
    if (contador == 6)
    {
        break;
    }
}

for (int contador = 0; contador <= 10; contador++)
{
    Console.WriteLine($"{numero} x {contador} = {numero * contador}");
}
*/