using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASP.NET_MVC.Models
{
    public class Livro
    {
        //Estou usando Data Notation que serve para forçar o usuario a
        //inserir todos os dados
        [Required(ErrorMessage = "O Código é obrigatório")]
        public int ID { get; set; }
        [Required(ErrorMessage = "O Título é obrigatório")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O Autor é obrigatório")]
        public string Autor { get; set; }

        //Estou usando expressão regular para forcar o usuario a inserir
        //um númerico de 0 a 9 com 4 numeros.
        [RegularExpression(@"[0-9]{4}", ErrorMessage = "O ano deve possuir 4 números!")]
        [Required(ErrorMessage = "O Ano de publicação é obrigatório")]
        public int anoPublicacao { get; set; }

        //Para comecar os testes decidi criar um metodo que 
        //possui uma Lista que contém 3 livros

        public List<Livro> GetLivros()
        {
            return new List<Livro>
            {
                new Livro
                {
                    ID =1,
                    Titulo = "Domain-Driven Design: Tacling complexity in the Heart of Software",
                    Autor = "Eric Evans",
                    anoPublicacao = 2003
                },
                new Livro
                {
                    ID = 2,
                    Titulo = "Agile Principles, Patterns, and Practices in C#",
                    Autor = "Rober C. Martin",
                    anoPublicacao = 2006
                },
                new Livro
                {
                    ID = 3,
                    Titulo = "Clean Code",
                    Autor = "Rober C. Martin",
                    anoPublicacao = 2008
               }

            };
        }

    }

}