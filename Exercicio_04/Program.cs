using Exercicio_04.Models;

bool exit = false;
List<PassagemViagem> passagemViagems = new();

while (!exit)
{
    Console.Clear();
    Console.WriteLine("==== MENU CADASTRO DE PASSAGENS ====");
    Console.WriteLine("[1] - CADASTRAR PASSAGEM");
    Console.WriteLine("[2] - LISTAR PASSAGENS CADASTRADAS");
    Console.WriteLine("[3] - BUSCAR PASSAGEM CADASTRADA");
    Console.WriteLine("[4] - SAIR");
    string escolha = Console.ReadLine();

    Console.Clear();
    switch (escolha)
    {
        case "1":
            Console.WriteLine("==== CADASTRO DE PASSAGEM ====");
            Console.Write("Digite o nome do passageiro: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o destino do passageiro: ");
            string destino = Console.ReadLine();

            Console.Write("Digite o valor da viagem: R$ ");
            decimal valorDaPassagem = IsValidDecimal(Console.ReadLine());

            Console.Write("Digite o valor da taxa de embarque: R$ ");
            decimal valorTaxaEmbarque = IsValidDecimal(Console.ReadLine());

            PassagemViagem passagem = new(nome, destino, valorDaPassagem, valorTaxaEmbarque);

            Console.Clear();
            if (passagem.ValidarValores())
            {
                passagemViagems.Add(passagem);
                Console.WriteLine($"Passagem adicionada com sucesso!! ID da passagem = {passagem.Id}");
            }
            else
                Console.WriteLine("Valores passados incorretamentes, processo de cadastro cancelado!!!");

            Console.WriteLine("Digite qualquer tecla para voltar o menu!!!");
            Console.ReadKey();
            break;
        case "2":
            Console.WriteLine("==== PASSAGENS CADASTRADAS ====");
            foreach (var item in passagemViagems)
            {
                Console.WriteLine(item.ResumoPassagem());
            }
            Console.WriteLine("Digite qualquer tecla para voltar o menu!!!");
            Console.ReadKey();
            break;
        case "3":
            Console.WriteLine("==== BUSCAR PASSAGEM ====");
            Console.Write("Digite o ID da passagem: ");
            string buscarId = Console.ReadLine();
            var buscarIdPassagem = passagemViagems.Find(x => x.Id == buscarId);

            if (buscarIdPassagem != null)
                Console.WriteLine(buscarIdPassagem.ResumoPassagem());
            else
                Console.WriteLine("Passagem não cadastrada no sistema!!!");

            Console.WriteLine("Digite qualquer tecla para voltar o menu!!!");
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
    while (!sucess)
    {
        Console.Write("Digite um valor válido: ");
        sucess = decimal.TryParse(Console.ReadLine(), out number);
    }
    return number;
}