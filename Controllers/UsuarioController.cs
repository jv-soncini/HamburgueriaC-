using System;
using AppEstacionamento.Models;
using AppEstacionamento.Repositorio;
using AppEstacionamento.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppEstacionamento.Controllers
{
    public class UsuarioController : Controller
    {

        private RegistroRepositorio Repositorio = new RegistroRepositorio();

        private MarcaRepositorio marcarepositorio = new MarcaRepositorio();

        private ModeloRepositorio modelorepositorio = new ModeloRepositorio();
        
        [HttpGet]
        public IActionResult Index() {
            var marcas = marcarepositorio.Listar();
            var modelos = modelorepositorio.Listar();

            RegistroViewModel registro = new RegistroViewModel();
            registro.Marcas = marcas;
            registro.Modelos = modelos;

            return View(registro);
        }
        [HttpPost]
        public IActionResult Registrar(IFormCollection form)
        {
            System.Console.WriteLine(form["nome"]);
            System.Console.WriteLine(form["placa"]);
            System.Console.WriteLine(form["modelo"]);
            System.Console.WriteLine(form["marca"]);

            Registro registro = new Registro();

            Cliente cliente = new Cliente();
            CarroModel carro = new CarroModel();
            cliente.NomeCondutor = form["nome"];
            carro.Placa = form["placa"];
            registro.DataEntrada = DateTime.Parse(form["dataNascimento"]);
            
            

            registro.Cliente = cliente;


            Marca marca = new Marca(
                NomeDaMarca: form["marca"]
            );

            registro.Carro.marca = marca;

            Modelo modelo = new Modelo() {
                NomeDoModelo = form["modelo"]
                
            };

            registro.Carro.modelo = modelo;

            Repositorio.Inserir(registro);


            return RedirectToAction("Sucesso");
        }
    }
}