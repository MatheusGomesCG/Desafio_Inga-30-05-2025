using Exercicio_05.Models;

bool exit = false;
Console.Write("Digite o nome: ");
string nome = Console.ReadLine();

Console.Write("Digite o limite do cartão de credito: R$ ");
decimal limiteInicial = IsValidDecimal(Console.ReadLine());

CartaoPrePago cartaoPrePago = new CartaoPrePago(nome, limiteInicial);

while (!exit)
{
    Console.Clear();
    Console.WriteLine("==== MENU CARTÃO DE CREDITO ====");
    Console.WriteLine("[1] - AUMENTAR LIMITE DE CREDITO");
    Console.WriteLine("[2] - REALIZAR COMPRA");
    Console.WriteLine("[3] - EXIBIR RESUMO");
    Console.WriteLine("[4] - SAIR");
    string escolha = Console.ReadLine();

    Console.Clear();
    switch (escolha)
    {
        case "1":
            Console.WriteLine("==== MENU ADICIONAR LIMITE AO CARTAO ====");
            Console.Write("Digite o valor que deseja aumentar o limite: R$ ");
            decimal valor = IsValidDecimal2(Console.ReadLine());

            cartaoPrePago.AdicionarCredito(valor);
            Console.WriteLine("Digite qualquer tecla para voltar ao menu");
            Console.ReadKey();
            break;
        case "2":
            Console.WriteLine("==== MENU DE COMPRA ====");
            Console.Write("Digite o valor da compra: R$ ");
            decimal valorDaCompra = IsValidDecimal2(Console.ReadLine());
            cartaoPrePago.RealizarCompra(valorDaCompra);
            Console.WriteLine("Digite qualquer tecla para voltar ao menu");
            Console.ReadKey();
            break;
        case "3":
            Console.WriteLine("==== EXIBIR RESUMO DO CARTAO ====");
            Console.WriteLine(cartaoPrePago.ExibirResumo());
            Console.WriteLine("Digite qualquer tecla para voltar ao menu");
            Console.ReadKey();
            break;
        case "4":
            exit = true;
            break;
        default:
            Console.WriteLine("Opção incorreta!!! Por favor digite uma opção válida");
            Console.WriteLine("Digite qualquer tecla para voltar ao menu");
            Console.ReadKey();
            break;
    }
}
Console.WriteLine("Obrigado por usar o programa!!!");

static decimal IsValidDecimal(string inputUser)
{
    bool sucess = decimal.TryParse(inputUser, out decimal number);
    while (!sucess || number <= 0)
    {
        Console.Write("Digite um valor válido: ");
        sucess = decimal.TryParse(Console.ReadLine(), out number);
    }
    return number;
}


static decimal IsValidDecimal2(string inputUser)
{
    bool sucess = decimal.TryParse(inputUser, out decimal number);
    while (!sucess)
    {
        Console.Write("Digite um valor válido: ");
        sucess = decimal.TryParse(Console.ReadLine(), out number);
    }
    return number;
}