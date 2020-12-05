using ASP.NET_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_MVC.Controllers
{
    public class HomeController : Controller
    {
        //Como nao vou utilizar banco de dados por enquanto
        //Criei uma Lista estatica para persistir os dados contidos nela
        //E usei um construtor que verifica se a lista estiver vazia
        //Se cair no if vai ir para o metodo onde sera adicionado os valores contidos nela
        private static List<Livro> Livros;

        public HomeController()
        {
            if (Livros == null)
            {
                Livros = new Livro().GetLivros();
            }
        }


        //Esse metodo vai disparar para chamar uma classe responsavel
        //por mostrar os dados ao usuario na camada View(Visualização) do projeto
        public ActionResult Index()
        {
            return View(Livros);
        }
    }
}