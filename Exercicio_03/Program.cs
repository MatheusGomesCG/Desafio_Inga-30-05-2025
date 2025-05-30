using Exercicio_03.Models;

bool exit = false;
AgendaContatos agenda = new();

while (!exit)
{
    Console.Clear();
    Console.WriteLine("==== MENU AGENDA DE CONTATOS ====");
    Console.WriteLine("[1] - ADICIONAR CONTATO");
    Console.WriteLine("[2] - BUSCAR POR NOME");
    Console.WriteLine("[3] - LISTAR TODOS OS CONTATOS");
    Console.WriteLine("[4] - SAIR");
    string escolha = Console.ReadLine();

    Console.Clear();
    switch (escolha)
    {
        case "1":
            Console.WriteLine("==== MENU CADASTRO DE CONTATO ====");
            Console.Write("Digite o nome do contato: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o telefone do contato: ");
            string telefone = Console.ReadLine();

            Console.Clear();
            agenda.Adicionar(new Contato(nome, telefone));

            Console.WriteLine("Digite qualquer tecla para voltar ao menu");
            Console.ReadKey();
            break;
        case "2":
            Console.WriteLine("==== MENU BUSCAR CONTATO ====");
            Console.Write("Digite o nome do contato: ");
            Console.WriteLine(agenda.BuscarPorNome(Console.ReadLine()));
            Console.WriteLine("Digite qualquer tecla para voltar ao menu");
            Console.ReadKey();
            break;
        case "3":
            Console.WriteLine("==== MENU LISTAR CONTATOS ====");
            Console.WriteLine(agenda.ListarTodos());
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
