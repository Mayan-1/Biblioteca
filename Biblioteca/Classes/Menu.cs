using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Classes
{
    internal class Menu
    {
        ControllerLivros controllerLivros = new ControllerLivros();


        public void ChamarMenu()
        {
            while(true)
            {
                Console.Clear();
                Console.WriteLine("_-_-_ SEJA BEM VINDO A SUA BIBLIOTECA! _-_-_");
                Console.WriteLine("Aqui você pode...");
                Console.WriteLine("1 - CADASTRAR LIVROS");
                Console.WriteLine("2 - EDITAR LIVROS");
                Console.WriteLine("3 - EXCLUIR LIVROS");
                Console.WriteLine("4 - VER LIVROS CADASTRADOS");
                Console.WriteLine("5 - SAIR");
                Console.WriteLine("O que deseja fazer? ");
                int opcao = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (opcao)
                {
                    case 1:
                        try
                        {
                            Console.WriteLine("Certo, preencha os campos abaixo para cadastrar seu livro...");
                            Console.Write("Nome: ");
                            string nome = Console.ReadLine();
                            Console.Write("Autor: ");
                            string autor = Console.ReadLine();
                            Console.Write("Data de lançamento: ");
                            DateTime dataLancamento = Convert.ToDateTime(Console.ReadLine());
                            Console.Write("Quantidade de páginas: ");
                            int quantidadePaginas = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Genêro: ");
                            string genero = Console.ReadLine();
                            Livro livro = new Livro(nome, autor, dataLancamento, quantidadePaginas, genero);
                            controllerLivros.CadastrarLivro(livro);
                            Console.ReadKey();
                            ChamarMenu();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case 2:
                        Console.Write("Digite o id do livro cadastrado para editar: ");
                        int idProcurado = Convert.ToInt32(Console.ReadLine());
                        Dictionary<int, Livro> livrosCorrigido = controllerLivros.EditarLivro(idProcurado);
                        break;
                    case 5:
                        Console.WriteLine("Saindo da biblioteca...");
                        Thread.Sleep(2000);
                        Environment.Exit(0);
                        break;
                }
            }
            
        }

    }
}
