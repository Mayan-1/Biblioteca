using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Models
{
    internal class Livro
    {
        public int Key { get; private set; }
        public string? Nome { get; set; }
        public string? Autor { get; set; }
        public DateTime DataLancamento { get; set; }
        public int QuantidadePaginas { get; set; }
        public string Genero { get; set; }

        public Livro(int key, string nome, string autor, DateTime dataLancamento, int quantidadePaginas, string genero)
        {
            Key = key;
            Nome = nome;
            Autor = autor;
            DataLancamento = dataLancamento;
            QuantidadePaginas = quantidadePaginas;
            Genero = genero;
        }

        public override string ToString()
        {
            return $"ID - {Key}" +
                    $"\n{Nome}" +
                    $"\n{DataLancamento.ToString("dd/MM/yyyy")}" +
                    $"\nAutor - {Autor}" +
                    $"\nGenêro - {Genero}" +
                    $"\n{QuantidadePaginas} páginas";
        }




    }
}
