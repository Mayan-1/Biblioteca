using Biblioteca.Repositories;
using Biblioteca.Models;
using Biblioteca.Application;

LivrosRepository livrosRepository = new LivrosRepository();
LivroApplication livroApplication = new LivroApplication(livrosRepository);
Livro livro1 = new Livro(1, "O guia do mochileiro das galáxias", "Douglas Adams", new DateTime(01/01/1983), 186, "Comédia");
Livro livro2 = new Livro(2, "O restaurante no fim do universo", "Douglas Adams", new DateTime(01 / 01 / 1985), 211, "Comédia");
Livro livro3 = new Livro(3, "A vida, o universo, e tudo mais", "Douglas Adams", new DateTime(01 / 01 / 1985), 231, "Comédia");
Livro livro4 = new Livro(4, "Eu, Robô", "Isaac Asimov", new DateTime(01 / 01 / 1935), 320, "Ficção Cientifíca");
Livro livro5 = new Livro(5, "Cavernas de aço", "Isaac Asimov", new DateTime(01/01/1941), 378, "Ficção Cientifíca");

livrosRepository.CadastrarLivro(livro1);
livrosRepository.CadastrarLivro(livro2);
livrosRepository.CadastrarLivro(livro3);
livrosRepository.CadastrarLivro(livro4);
livrosRepository.CadastrarLivro(livro5);

livroApplication.AgruparLivrosPorAutor("Douglas Adams");
Console.WriteLine();
livroApplication.AgruparLivrosPorGenero("Comédia");




