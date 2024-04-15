using Biblioteca.Models;
using Biblioteca.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Application
{
    internal class LivroApplication
    {
        public LivrosRepository livrosRepository;

        public LivroApplication(LivrosRepository livrosRepository)
        {
            this.livrosRepository = livrosRepository;
        }

        public Livro GetLivro(int key)
        {
            Livro livro = livrosRepository.GetLivro(key);
            return livro;
        }

        public Livro EditarNomeLivro(int key, string nome)
        {
            var livro = livrosRepository.GetLivro(key);
            livro.Nome = nome;
            return livro;
        }

        public Livro EditarAutorLivro(int key, string autor)
        {
            var livro = livrosRepository.GetLivro(key);
            livro.Autor = autor;
            return livro;
        }

        public Livro EditarDataLivro(int key, DateTime data)
        {
            var livro = livrosRepository.GetLivro(key);
            livro.DataLancamento = data;
            return livro;
        }

        public Livro EditarQtdPaginasLivro(int key, int quantidadePaginas)
        {
            var livro = livrosRepository.GetLivro(key);
            livro.QuantidadePaginas = quantidadePaginas;
            return livro;
        }

        public Livro EditarGeneroLivro(int key, string genero)
        {
            var livro = livrosRepository.GetLivro(key);
            livro.Genero = genero;
            return livro;
        }

        public void AgruparLivrosPorAutor(string autor)
        {
            var livrosFiltrados = livrosRepository.livros.Where(livro => livro.Value.Autor == autor)
                                                         .GroupBy(l => l.Value.Autor);
                                                         

            foreach (var livroFiltradoAutor in livrosFiltrados)
            {
                Console.WriteLine($"Autor: {livroFiltradoAutor.Key}");
                foreach (var livro in livroFiltradoAutor)
                {
                    Console.WriteLine($"\t{livro.Value.Nome} - {livro.Value.Autor}");
                }
            }
        }

        public void AgruparLivrosPorGenero(string genero)
        {
            var livrosFiltrados = livrosRepository.livros.Where(livro => livro.Value.Genero == genero)
                                                         .GroupBy(l => l.Value.Genero);
            foreach (var livroFiltradoGenero in livrosFiltrados)
            {
                Console.WriteLine($"Genêro: {livroFiltradoGenero.Key}");
                foreach (var livro in livroFiltradoGenero)
                {
                    Console.WriteLine($"\t{livro.Value.Nome} - {livro.Value.Genero}");
                }
            }
        }


    }
}
