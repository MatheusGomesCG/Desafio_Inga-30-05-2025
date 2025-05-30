using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace Exercicio_03.Models
{
    public class AgendaContatos
    {
        public List<Contato> contatos = new();

        public void Adicionar(Contato c)
        {
            if (contatos.Any(x => x.Nome == c.Nome))
                Console.WriteLine("Contato já existe");
            else
            {
                contatos.Add(c);
                Console.WriteLine("Contato adicionado com sucesso!");
            }
        }
        public string BuscarPorNome(string nome)
        {
            var buscarContato = contatos.Find(x => x.Nome == nome);

            if (buscarContato != null) {
                return buscarContato.ToString();
            }
            return $"Contato não cadastrado";
        }
        public string ListarTodos()
        {
            StringBuilder sb = new();
            foreach (var item in contatos)
            {
                sb.AppendLine($"Nome = {item.Nome}");
                sb.AppendLine($"Telefone = {item.Telefone}");
                sb.AppendLine();
            }

            return sb.ToString();
        }

    }
}