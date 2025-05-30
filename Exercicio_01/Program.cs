using System.Text;
using Exercicio_01.Models;

List<Funcionario> list = new();
bool exit = false;

while (!exit)
{
    Console.Clear();
    Console.WriteLine("==== MENU FUNCIONARIO ====");
    Console.WriteLine("[1] - CADASTRAR FUNCIONARIO");
    Console.WriteLine("[2] - LISTAR FUNCIONARIO");
    Console.WriteLine("[3] - PESQUISAR FUNCIONARIO");
    Console.WriteLine("[4] - APLICAR BONUS AO FUNCIONARIO");
    Console.WriteLine("[5] - SAIR");
    string choice = Console.ReadLine();

    Console.Clear();
    switch (choice)
    {
        case "1":
            Console.WriteLine("==== MENU CADASTRO ====");
            Console.Write("Digite o nome do funcionário: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o salário base do funcionário: R$ ");
            decimal salario = IsValidDecimal(Console.ReadLine());

            Console.Write("Digite o cargo do funcionário: ");
            string cargo = Console.ReadLine();

            Funcionario funcionario = new Funcionario(nome, salario, cargo);
            list.Add(funcionario);
            Console.Clear();
            Console.WriteLine($"O funcionario foi cadastrado com sucesso!! O ID dele é {funcionario.Id}");
            Console.WriteLine("Digite qualquer tecla para voltar ao menu");
            Console.ReadKey();
            break;
        case "2":
            Console.WriteLine("==== LISTA DE FUNCIONARIO ====");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Digite qualquer tecla para voltar ao menu");
            Console.ReadKey();
            break;
        case "3":
            Console.WriteLine("==== BUSCAR FUNCIONARIO ====");
            Console.Write("Digite o ID do funcionário que deseja buscar: ");
            int buscaId = IsValidInt(Console.ReadLine());
            var buscaFuncionario = list.Find(x => x.Id == buscaId);

            if (buscaFuncionario != null)
                Console.WriteLine(buscaFuncionario);
            else
                Console.WriteLine("Funcionário não cadastrado!!!");

            Console.WriteLine("Digite qualquer tecla para voltar ao menu");
            Console.ReadKey();
            break;
        case "4":
            Console.WriteLine("==== BONIFICAR FUNCIONARIO ====");
            Console.Write("Digite o ID do funcionário que deseja bonificar: ");
            int bonificarId = IsValidInt(Console.ReadLine());
            var bonificarFuncionario = list.Find(x => x.Id == bonificarId);

            if (bonificarFuncionario != null)
                bonificarFuncionario.CalcularBonus();
            else
                Console.WriteLine("Funcionário não cadastrado!!!");

            Console.WriteLine("Digite qualquer tecla para voltar ao menu");
            Console.ReadKey();
            break;
        case "5":
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


static int IsValidInt(string inputUser)
{
    bool sucess = int.TryParse(inputUser, out int number);
    while (!sucess || number <= 0)
    {
        Console.Write("Digite um valor válido: ");
        sucess = int.TryParse(Console.ReadLine(), out number);
    }
    return number;
}


