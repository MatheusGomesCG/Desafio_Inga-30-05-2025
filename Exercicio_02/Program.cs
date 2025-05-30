using System.Security.Cryptography.X509Certificates;
using Exercicio_02.Models;


List<Livro> livros = new();
bool exit = false;
int buscaId;

while (!exit)
{
    Console.Clear();
    Console.WriteLine("==== MENU LIVRARIA ====");
    Console.WriteLine("[1] - ADICIONAR LIVROS");
    Console.WriteLine("[2] - LISTAR LIVROS CADASTRADOS");
    Console.WriteLine("[3] - VENDER LIVROS");
    Console.WriteLine("[4] - REPOR O ESTOQUE");
    Console.WriteLine("[5] - SAIR");
    string escolha = Console.ReadLine();

    Console.Clear();
    switch (escolha)
    {
        case "1":
            Console.WriteLine("=== MENU CADASTRO DE LIVRO ====");
            Console.Write("Digite o nome do Titulo do livro: ");
            string titulo = Console.ReadLine();

            Console.Write("Digite o nome do Autor do livro: ");
            string autor = Console.ReadLine();

            Console.Write("Digite a quantidade que deseja cadastrar: ");
            int quantidade = IsValidInt(Console.ReadLine());

            var existeLivro = livros.Any(x => x.Titulo == titulo && x.Autor == autor);

            Console.Clear();
            if (existeLivro)
            {
                Console.WriteLine("Livro já está cadastrado no nosso sistema");
                Console.WriteLine("Digite qualquer tecla para voltar ao menu");
                Console.ReadKey();
                break;
            }

            Livro livro = new Livro(titulo, autor, quantidade);
            livros.Add(livro);

            Console.WriteLine($"Livro Cadastrado com sucesso!!! O ID é {livro.Id}");
            Console.WriteLine("Digite qualquer tecla para voltar ao menu");
            Console.ReadKey();
            break;
        case "2":
            Console.WriteLine("==== LISTAR LIVROS ====");
            foreach (var item in livros)
                Console.WriteLine(item);
            Console.WriteLine("Digite qualquer tecla para voltar ao menu");
            Console.ReadKey();
            break;
        case "3":
            Console.WriteLine("==== VENDA DE LIVROS ====");
            Console.Write("Digite o ID do livro que deseja vender: ");
            buscaId = IsValidInt(Console.ReadLine());
            var buscarLivro = livros.Find(x => x.Id == buscaId);

            Console.Clear();
            if (buscarLivro != null)
            {
                Console.Write("Digite quantos livros deseja comprar: ");
                int quantidadeDesejada = IsValidInt(Console.ReadLine());
                buscarLivro.Vender(quantidadeDesejada);
            }
            else
                Console.WriteLine("Livro não cadastrado!!!");
            Console.WriteLine("Digite qualquer tecla para voltar ao menu");
            Console.ReadKey();
            break;
        case "4":
            Console.WriteLine("==== REPOR ESTOQUE DE LIVROS ====");
            Console.Write("Digite o ID do livro que deseja repor: ");
            buscaId = IsValidInt(Console.ReadLine());
            var buscarLivroRepor = livros.Find(x => x.Id == buscaId);

            Console.Clear();
            if (buscarLivroRepor != null)
            {
                Console.Write("Digite quantos livros deseja repor: ");
                int quantidadeDesejada = IsValidInt(Console.ReadLine());
                buscarLivroRepor.AdicionarEstoque(quantidadeDesejada);
            }
            else
                Console.WriteLine("Livro não cadastrado!!!");
            
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