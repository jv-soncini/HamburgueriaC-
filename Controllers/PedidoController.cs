using HamburgueriaWeb.Models;
using HamburgueriaWeb.Repositorio;
using HamburgueriaWeb.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HamburgueriaWeb.Controllers
{
    public class PedidoController : Controller
    {
        private PedidoRepositorio Repositorio = new PedidoRepositorio();

        private HamburguerRepositorio hamburguerrepositorio = new HamburguerRepositorio();

        private ShakesRepositorio shakerepositorio = new ShakesRepositorio();

        [HttpGet]
        
        public IActionResult Index()
        {
            var hamburgueres = hamburguerrepositorio.Listar();
            var shakes = shakerepositorio.Listar();

            PedidoViewModel pedido = new PedidoViewModel();
            pedido.Hamburgueres = hamburgueres;
            pedido.Shakess = shakes;

            return View(pedido);
        }
        [HttpPost]
        public IActionResult RegistrarPedido(IFormCollection form)
        {
            System.Console.WriteLine(form["nome"]);
            System.Console.WriteLine(form["endereco"]);
            System.Console.WriteLine(form["telefone"]);
            System.Console.WriteLine(form["email"]);
            System.Console.WriteLine(form["hamburguer"]);
            System.Console.WriteLine(form["shake"]);

            Pedido pedido = new Pedido();

            Cliente cliente = new Cliente();
            //Forma 1- mais comum
            cliente.Nome = form["nome"];
            cliente.Endererco = form["endereco"];
            cliente.Telefone = form["telefone"];
            cliente.Email = form["email"];

            pedido.Cliente = cliente;
            // Forma 2- usa parametros nos contrutores
            Hamburguer hamburguer = new Hamburguer(
                Nome: form["hamburguer"]
            );

            pedido.Hamburguer = hamburguer;

            Shake shake = new Shake() {
                Nome = form["shake"]
            };

            pedido.Shake = shake;

            Repositorio.Inserir(pedido);
            ViewData["NomeView"] = "Pedido";

            return View("Sucesso");
        }
    }
}