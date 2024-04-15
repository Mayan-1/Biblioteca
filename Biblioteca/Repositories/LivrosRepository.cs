using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Models;

namespace Biblioteca.Repositories
{
    internal class LivrosRepository
    {

        public Dictionary<int, Livro> livros { get; set; }

        
        public LivrosRepository()
        {
            livros = new Dictionary<int, Livro>();
        }

        public void CadastrarLivro(Livro livro)
        {
            try
            {
                livros.Add(livro.Key, livro);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /*public Dictionary<int, Livro> EditarLivro(int key)
        {
            if (livros.ContainsKey(key))
            {
                Console.WriteLine("O que você quer editar?");
                Console.WriteLine("Nome[1]");
                Console.WriteLine("Autor[2]");
                Console.WriteLine("Data de lançamento[3]");
                Console.WriteLine("Quantidade de páginas[4]");
                Console.WriteLine("Genêro[5]");
                int opcao = Convert.ToInt32(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        Console.Write("Digite o nome do livro: ");
                        string nome = Console.ReadLine();
                        livros[key].Nome = nome;
                        break;
                    case 2:
                        Console.Write("Digite o nome do autor: ");
                        string autor = Console.ReadLine();
                        livros[key].Autor = autor;
                        break;
                    case 3:
                        Console.Write("Digite a data de lançamento: ");
                        DateTime data = Convert.ToDateTime(Console.ReadLine());
                        livros[key].DataLancamento = data;
                        break;
                    case 4:
                        Console.Write("Digite a quantidade de páginas: ");
                        int quantidade = Convert.ToInt32(Console.ReadLine());
                        livros[key].QuantidadePaginas = quantidade;
                        break;
                    case 5:
                        Console.Write("Digite o genêro: ");
                        string genero = Console.ReadLine();
                        livros[key].Genero = genero;
                        break;
                    default:
                        Console.WriteLine("Opção inválida... Tente novamente!");
                        Console.ReadKey();
                        break;
                }
                Console.WriteLine(livros[key].ToString());
                Console.ReadKey();
                return livros;
            }
            else
            {
                Console.WriteLine("O livro não existe na lista...");
                Console.ReadKey();
                return livros;
            }
        }
        */
        public Dictionary<int, Livro> ExcluirLivro(int key)
        {
            if (livros.ContainsKey(key))
            {
                try
                {
                    livros.Remove(key);
                }catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.ReadKey();
            return livros;
        }

        public void VerTodosOsLivros()
        {
            foreach (var livro in livros)
            {
                string? livroInfo = livro.Value.ToString();
                Console.WriteLine($"\n{livroInfo}");
            }
            Console.ReadKey();
        }

        public List<Livro> GetLivros() 
        {

            List<Livro> colecaoDeLivros = livros.Values.ToList();
            if (colecaoDeLivros.Count == 0)
                throw new NullReferenceException();
            return colecaoDeLivros;
            
        }

        public Livro GetLivro( int key)
        {
            if (livros.ContainsKey(key))
            {
                return livros[key];
            }
            else
            {
                throw new KeyNotFoundException($"Não foi encontrado nenhum livro com a chave {key}.");
            }
        }


    }
}
